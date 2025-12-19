# Nutritionist Project Brief

## Purpose & Roles
- The WinForms entry point (`Program.cs:20-35`) launches `LoginForm`, then routes admins to `AdminForm` and dietitians to `NutritionistForm`, so every workflow hangs off a logged-in `UserSession` (`UserSession.cs:3-17`).
- The solution targets school meal planning, recipe analysis, and procurement tracking for nutrition staff; administrators are intended to approve plans and purchases rather than create them.

## Technology Stack & Dependencies
- .NET Framework 4.7.2 with C# 9 compiler features, Windows Forms, and x64 builds are defined in `nutritionist.csproj:4-35`.
- Oracle is accessed directly through `Oracle.DataAccess.dll` stored under `lib/Oracle` (`nutritionist.csproj:36-52`), with the connection string hard-coded to a local `FREEPDB1` instance and `school/1324` credentials in `DatabaseConfig.cs:5-8`.
- UI assets live in the auto-generated designer files under `AdminForm`, `NutritionistForm`, and `Tabs/*`, while runtime dialogs (`MealPlanDialog.cs`, `RawMaterialDialog.cs`, `PurchaseRequestDialog.cs`) are hand-authored for critical flows.

## Database Landscape
### Master & Ingredient Data
- Core identities include `AppUser`, `RawCategory`, `RawMaterial`, `Nutrient`, and `RawNutrient` (`schema.sql:4-54`).
- Ingredient recipes are modeled by `Ingredient`, `IngredientComp`, `FinalMenu`, and `MenuComp`, plus tagging through `MenuTag`/`MenuTagMap` (`schema.sql:70-118`).
- Seed data truncates every table then inserts example admins, dietitians, raw categories, materials, nutrients, and more for demo use (`seed_data.sql:20-55`).

### Meal Production & Feedback
- Weekly plans are stored in `MealPlan`, `Meal`, and `MealComp`, with allergy alternatives (`AltAssign`), consumers, and review tables ready for future UX (`schema.sql:120-201`).

### Procurement & Vendors
- Vendors, contracts, and purchase requests rely on `Vendor`, `RawContract`, and `PurchaseRequest` to track sourcing and approvals (`schema.sql:204-242`).

### Maintenance Scripts
- `cleanup.sql:4-43` provides a safe PL/SQL block that drops tables in reverse dependency order, and `seed_data.sql` provides deterministic sample content so the WinForms app can always reset to a known state during demos.

## Application Components
### Entry & Session Flow
- `UserSession` exposes `IsAdmin`, letting the UI toggle dietitian-only features at runtime (`UserSession.cs:3-17`).
- `LoginForm` enforces Oracle credential checks, increments login failure counts, and resets `LastLoginAt` when successful (`LoginForm.cs:105-199`).

### Authentication UX & Security
- Passwords are verified with PBKDF2 (`LoginForm.cs:167-199`), but the form currently shows a debug `MessageBox` containing the plain password, computed hash, and stored hash for every attempt (`LoginForm.cs:178-185`), which is a major security risk in production.
- Oracle client misconfiguration is surfaced to the user with actionable guidance (`LoginForm.cs:135-144`).

### Admin Toolkit Status
- `AdminForm` simply removes its dashboard tab and updates the title with the admin’s name; none of the multi-tab management surfaces have backing logic yet (`AdminForm.cs:6-26`).
- The numerous `Tabs/Management/*.cs` user controls only define layout; every functional handler lives inside `NutritionistForm`, so the admin shell is effectively a placeholder.

### Nutritionist Workspace
#### Dashboard & Data Loading
- `ReloadAll` orchestrates every refresh: summary KPIs, raw data, recipes, final menus, meal plans, and purchase requests (`NutritionistForm.cs:1050-1182`). The summary cards show counts of materials, meal plans, and pending purchase approvals (`NutritionistForm.cs:1124-1138`).

#### Raw Ingredient Management
- `LoadRawMaterials` joins `RawMaterial` and `Ingredient` rows into a unified grid, builds an in-memory list of `RawMaterialOption`, and feeds filtering state (`NutritionistForm.cs:1141-1182`).
- Nutrient filters are derived from `RawNutrient`, including calorie lookups stored in `_rawCalorieMap` (`NutritionistForm.cs:1184-1217`).
- `ApplyRawMaterialView` supports search, nutrient tag filtering, calorie ranges, and optional grouping by category; collapsed groups are tracked by `_collapsedCategories` (`NutritionistForm.cs:2800-2884`).
- `AddRawMaterial` launches `RawMaterialDialog` to validate user input before inserting into `RawMaterial` with `CreateRawMaterial` (`NutritionistForm.cs:3795-3843`, `RawMaterialDialog.cs:9-183`).

#### Recipe Explorer & Nutrient Math
- `LoadRecipesManagement` pulls `FinalMenu` rows into `_recipeTable`, then `LoadRecipeNutrientSummary` flattens `MenuComp` entries (raw and ingredient components) to compute nutrient totals per serving (`NutritionistForm.cs:1221-1294`).
- Detailed nutrient and component grids are populated via `LoadRecipeNutrients` and `LoadAggregatedRecipeComponents`, with a context menu that jumps straight to the raw-material manager (`NutritionistForm.cs:2583-2755`).

#### Menu Tags, Sorting, and Filtering
- Menu type filters, nutrient-based sort options, and checklist tags are created from in-memory lists populated by `LoadMenuTags`, `PopulateMenuTypeFilter`, and `PopulateMenuSortOptions` (`NutritionistForm.cs:1296-1448`).
- `ApplyMenuFilter` evaluates each `FinalMenuOption` against menu type, selected tags, and nutrient sort preferences before binding the available menu list (`NutritionistForm.cs:1496-1589`).

#### Weekly Meal Planning Experience
- `_nutrientTargets` define default per-meal targets (calories, macronutrients, calcium) for the live nutrient summary (`NutritionistForm.cs:48-55`).
- The week selector (`WeekOption` with Monday–Friday spans) and grid updates keep the plan constrained to the selected `MealPlan` date range (`NutritionistForm.cs:540-761`, `NutritionistForm.cs:2225-2265`).
- Dietitians drag `FinalMenuOption` items from the filtered list into the `ListView`-based meal board, which groups by menu type and shows applied tags (`NutritionistForm.cs:3846-3947`).
- `_nutrientSummary` recomputes totals whenever `_selectedMealMenus` changes to visualize target coverage (`NutritionistForm.cs:3963-3995`).

#### Plan Lifecycle & Approvals
- Dietitians can seed a weekly plan via `MealPlanDialog`, which enforces contiguous date ranges (`MealPlanDialog.cs:9-111`). `CreateMealPlan` inserts drafts with manual `MAX+1` IDs (`NutritionistForm.cs:2128-2143`).
- The UI toggles availability of editing controls and approval requests based on role, current plan status (`DRAFT/PENDING/APPROVED`), and whether the current week is fully populated (`NutritionistForm.cs:1888-2033`).
- `RequestMealPlanApproval` flips a draft to `PENDING` once a week is complete, while admins use `ApproveSelectedMealPlan` to mark it `APPROVED` (`NutritionistForm.cs:2146-2182`, `NutritionistForm.cs:3412-3445`).

#### Meal Persistence & Notes
- `RegisterMealForCurrentPlan` validates date boundaries and requires at least one menu before calling `PersistMeal` (`NutritionistForm.cs:2058-2223`).
- `PersistMeal` opens an Oracle transaction, upserts into `Meal`, wipes any previous `MealComp` entries, and re-inserts the selected menus with their per-serving quantity (`NutritionistForm.cs:2301-2355`, `NutritionistForm.cs:2360-2418`).

#### Purchase Requests & Approvals
- `LoadPurchaseRequests` joins users and raw materials to show latest statuses inside the Ingredients tab grid (`NutritionistForm.cs:1472-1494`).
- Dietitians launch `PurchaseRequestDialog` to capture quantities, optional contract IDs, and expected delivery dates before `CreatePurchaseRequest` inserts a `REQUESTED` row (manual `MAX+1` ID) (`PurchaseRequestDialog.cs:9-115`, `NutritionistForm.cs:3449-3509`).
- Admins reuse the same buttons to approve pending purchase requests via `ApproveSelectedPurchaseRequest`, which stamps `ApprovedBy`/`ApprovedDate` and changes status to `APPROVED` (`NutritionistForm.cs:2050-2064`, `NutritionistForm.cs:3510-3535`).

## Shared Dialogs & Models
- `MealPlanDialog` wraps weekly plan naming and date previews so the planner always covers Monday–Friday (`MealPlanDialog.cs:9-111`).
- `RawMaterialDialog` supports dropdown categories, numeric validation, and optional storage metadata before persisting new rows (`RawMaterialDialog.cs:9-183`).
- `PurchaseRequestDialog` ties into `_rawMaterials`, storing the selection via `RawMaterialOption` (`PurchaseRequestDialog.cs:9-115`, `RawMaterialOption.cs:3-17`).
- `FinalMenuOption` and `RawCategoryOption` provide friendly `ToString` overrides so combo boxes and list controls show human-readable names (`FinalMenuOption.cs:3-26`, `RawCategoryOption.cs:3-17`).

## Data Access & ID Management
- Every query builds ad-hoc SQL strings and runs them via `OracleCommand`, wrapped by helper methods such as `ExecuteDataTable`/`ExecuteNonQuery` (`NutritionistForm.cs:1067-1110`). There is no ORM or repository abstraction.
- IDs are generated client-side by selecting `MAX(id)+1` (e.g., `CreateMealPlan`, `CreatePurchaseRequest`, `GetNextMealId`), which is simple but vulnerable to race conditions under concurrent users (`NutritionistForm.cs:2301-2367`, `NutritionistForm.cs:2128-2143`, `NutritionistForm.cs:3485-3509`).
- Connections are opened per call, so long-running interactions (like saving a meal) explicitly wrap their own transactions as needed (`NutritionistForm.cs:2308-2338`).

## Current Gaps & Risks
- The login debug pop-up exposes plaintext passwords and salts to anyone at the kiosk, so it must be removed before shipping (`LoginForm.cs:178-185`).
- Admin-facing tabs (vendors, allergies, evaluations, etc.) exist only in layout; no CRUD logic references those controls, so the administrator experience is incomplete (`AdminForm.cs:6-26`, `Tabs/Management/*.cs`).
- Manual `MAX+1` key generation can produce duplicate IDs if two users create records simultaneously; switching to Oracle sequences would harden concurrency (`NutritionistForm.cs:2128-2143`, `NutritionistForm.cs:3485-3509`).
- Oracle thick-client dependencies require matching x64 installs, and the connection string is fixed to localhost credentials, so deployment outside the developer’s machine needs additional instrumentation (`DatabaseConfig.cs:5-8`).
- Many schema tables (consumer management, allergies, feedback) are not surfaced yet in `NutritionistForm`, indicating future scope or technical debt.
