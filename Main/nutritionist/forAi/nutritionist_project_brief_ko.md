# Nutritionist 프로젝트 개요

## 목적과 역할
- WinForms 진입점은 `LoginForm` 실행 뒤 관리자라면 `AdminForm`, 영양사라면 `NutritionistForm`을 띄우도록 구성돼 있어 모든 화면이 로그인한 `UserSession`에 매달린다 (`Program.cs:20-35`, `UserSession.cs:3-17`).
- 이 솔루션은 학교 급식의 식단 작성·레시피 분석·발주 추적을 지원하며, 관리자는 계획과 발주를 승인하는 역할로 설계됐다.

## 기술 스택과 의존성
- 프로젝트는 .NET Framework 4.7.2, C# 9, Windows Forms, x64 빌드를 사용한다 (`nutritionist.csproj:4-35`).
- Oracle은 `lib/Oracle`에 포함된 `Oracle.DataAccess.dll`을 직접 참조하며, `DatabaseConfig`에는 로컬 `FREEPDB1` 인스턴스와 `school/1324` 계정이 하드코딩돼 있다 (`nutritionist.csproj:36-52`, `DatabaseConfig.cs:5-8`).
- UI는 디자이너 파일(`AdminForm`, `NutritionistForm`, `Tabs/*`)로 정의되고, 핵심 흐름용 다이얼로그(`MealPlanDialog.cs`, `RawMaterialDialog.cs`, `PurchaseRequestDialog.cs`)는 수작업으로 작성됐다.

## 데이터베이스 구성
### 마스터 및 원재료 데이터
- 사용자·원재료·영양소·원재료별 영양소 테이블이 기본 도메인을 이룬다 (`schema.sql:4-54`).
- 레시피는 `Ingredient`, `IngredientComp`, `FinalMenu`, `MenuComp`로 모델링되며 메뉴 태그 연계는 `MenuTag`/`MenuTagMap`이 담당한다 (`schema.sql:70-118`).
- `seed_data.sql`은 모든 테이블을 비운 뒤 관리자/영양사 계정, 원재료 분류·목록, 영양소 등 데모 데이터를 주입한다 (`seed_data.sql:20-55`).

### 식단 작성과 피드백
- 주간 계획은 `MealPlan`, `Meal`, `MealComp`에 저장되고, 알레르기 대체식·학생·만족도 조사를 위한 테이블이 후속 UX를 위해 준비돼 있다 (`schema.sql:120-201`).

### 조달과 공급업체
- 공급업체, 계약, 발주 요청은 `Vendor`, `RawContract`, `PurchaseRequest`로 추적한다 (`schema.sql:204-242`).

### 유지 보수 스크립트
- `cleanup.sql:4-43`은 의존 관계 역순으로 드롭하는 PL/SQL 블록을 제공하며, `seed_data.sql`은 데모 초기화를 위해 결정론적 샘플 데이터를 넣는다.

## 애플리케이션 구성요소
### 진입과 세션 흐름
- `UserSession`의 `IsAdmin` 플래그로 런타임에 기능을 나눌 수 있다 (`UserSession.cs:3-17`).
- `LoginForm`은 Oracle 자격 증명을 검증하고 실패 횟수를 누적하며 성공 시 `LastLoginAt`을 갱신한다 (`LoginForm.cs:105-199`).

### 인증 UX와 보안
- 비밀번호는 PBKDF2로 검증되지만 현재는 입력 비밀번호·계산 해시·DB 해시를 모두 보여 주는 디버그 팝업이 남아 있어 보안상 위험하다 (`LoginForm.cs:167-199`, `LoginForm.cs:178-185`).
- Oracle 클라이언트 구성이 잘못되면 구체적인 해결 가이드를 메시지박스로 안내한다 (`LoginForm.cs:135-144`).

### 관리자 도구 현황
- `AdminForm`은 대시보드 탭을 제거하고 제목만 사용자명으로 꾸미며, 다중 탭에 대한 동작 코드는 존재하지 않는다 (`AdminForm.cs:6-26`).
- `Tabs/Management/*.cs`는 모두 레이아웃 정의만 있고 실제 이벤트 로직은 `NutritionistForm`에 집중돼 있어 관리자 화면은 사실상 뼈대에 가깝다.

### 영양사 작업 공간
#### 대시보드와 데이터 로드
- `ReloadAll`은 요약 지표, 원재료, 레시피, 완성 메뉴, 식단 계획, 발주 요청을 한 번에 다시 로드한다 (`NutritionistForm.cs:1050-1182`). 카드에는 원재료 수, 계획 수, 승인 대기 발주 수가 표시된다 (`NutritionistForm.cs:1124-1138`).

#### 원재료 관리
- `LoadRawMaterials`는 `RawMaterial`과 `Ingredient`를 합쳐 그리드에 바인딩하고 `_rawMaterials` 옵션 목록을 채워 필터 상태를 만든다 (`NutritionistForm.cs:1141-1182`).
- 영양 필터는 `RawNutrient`에서 로드되며 칼로리는 `_rawCalorieMap`에 저장된다 (`NutritionistForm.cs:1184-1217`).
- `ApplyRawMaterialView`는 검색어, 영양 체크박스, 칼로리 범위, 분류별 그룹 접기/펼치기를 지원한다 (`NutritionistForm.cs:2800-2884`).
- `AddRawMaterial`은 `RawMaterialDialog`를 호출해 입력값을 검증하고 `CreateRawMaterial`로 DB에 저장한다 (`NutritionistForm.cs:3795-3843`, `RawMaterialDialog.cs:9-183`).

#### 레시피 탐색과 영양 계산
- `LoadRecipesManagement`는 `FinalMenu`를 `_recipeTable`에 적재한 뒤 `LoadRecipeNutrientSummary`가 `MenuComp`를 풀어 1인분 영양량을 계산한다 (`NutritionistForm.cs:1221-1294`).
- 세부 영양/구성 그리드는 `LoadRecipeNutrients`, `LoadAggregatedRecipeComponents`로 채워지며, 컨텍스트 메뉴로 해당 원재료 관리 화면을 바로 열 수 있다 (`NutritionistForm.cs:2583-2755`).

#### 메뉴 태그, 정렬, 필터링
- 메뉴 타입, 영양 기반 정렬, 태그 체크 리스트는 `LoadMenuTags`, `PopulateMenuTypeFilter`, `PopulateMenuSortOptions`에서 인메모리 목록으로 구성된다 (`NutritionistForm.cs:1296-1448`).
- `ApplyMenuFilter`는 선택한 타입·태그·정렬 조건을 모두 만족하는 `FinalMenuOption`만 리스트에 노출한다 (`NutritionistForm.cs:1496-1589`).

#### 주간 식단 보드 경험
- `_nutrientTargets`는 칼로리·3대 영양소·칼슘 목표치를 정의해 라이브 요약에 활용된다 (`NutritionistForm.cs:48-55`).
- `WeekOption` 기반 주차 선택과 그리드 업데이트는 선택한 `MealPlan` 기간 내로 제한된다 (`NutritionistForm.cs:540-761`, `NutritionistForm.cs:2225-2265`).
- 필터된 메뉴를 끌어 `ListView` 보드에 놓으면 메뉴 타입별 그룹과 태그가 함께 표시된다 (`NutritionistForm.cs:3846-3947`).
- `_selectedMealMenus`가 바뀔 때마다 `_nutrientSummary`가 재계산돼 목표 대비 충족률을 보여 준다 (`NutritionistForm.cs:3963-3995`).

#### 계획 수명주기와 승인
- 주간 계획은 `MealPlanDialog`로 이름·기간을 입력받고, `CreateMealPlan`은 `MAX+1` 방식으로 초안을 저장한다 (`MealPlanDialog.cs:9-111`, `NutritionistForm.cs:2128-2143`).
- 역할, 현재 상태(DRAFT/PENDING/APPROVED), 주간 완성 여부에 따라 편집/승인 버튼이 활성화된다 (`NutritionistForm.cs:1888-2033`).
- `RequestMealPlanApproval`은 주차가 완료된 초안을 `PENDING`으로 바꾸고, 관리자는 `ApproveSelectedMealPlan`으로 `APPROVED` 처리한다 (`NutritionistForm.cs:2146-2182`, `NutritionistForm.cs:3412-3445`).

#### 식단 저장과 비고
- `RegisterMealForCurrentPlan`은 날짜와 메뉴가 유효한지 검사한 후 `PersistMeal`을 호출한다 (`NutritionistForm.cs:2058-2223`).
- `PersistMeal`은 트랜잭션을 열어 `Meal`을 업서트하고 기존 `MealComp`를 삭제한 뒤 선택된 메뉴들을 다시 삽입한다 (`NutritionistForm.cs:2301-2355`, `NutritionistForm.cs:2360-2418`).

#### 발주 요청과 승인
- `LoadPurchaseRequests`는 사용자·원재료 정보를 조인해 최신 발주 현황을 보여 준다 (`NutritionistForm.cs:1472-1494`).
- 영양사는 `PurchaseRequestDialog`에서 수량·계약·납기 정보를 입력하고 `CreatePurchaseRequest`가 `REQUESTED` 상태로 삽입한다 (`PurchaseRequestDialog.cs:9-115`, `NutritionistForm.cs:3449-3509`).
- 관리자는 동일 화면에서 `ApproveSelectedPurchaseRequest`로 승인하며 승인자/일자를 저장한다 (`NutritionistForm.cs:2050-2064`, `NutritionistForm.cs:3510-3535`).

## 공용 다이얼로그와 모델
- `MealPlanDialog`는 주간 범위를 한눈에 보여 주며 월~금 고정 기간을 강제한다 (`MealPlanDialog.cs:9-111`).
- `RawMaterialDialog`는 분류 선택, 숫자 검증, 보관 정보 입력 후 새 원재료를 넘겨 준다 (`RawMaterialDialog.cs:9-183`).
- `PurchaseRequestDialog`는 `_rawMaterials` 목록과 `RawMaterialOption`을 활용해 선택값을 저장한다 (`PurchaseRequestDialog.cs:9-115`, `RawMaterialOption.cs:3-17`).
- `FinalMenuOption`, `RawCategoryOption`은 콤보박스/리스트에서 읽기 쉬운 문자열을 제공한다 (`FinalMenuOption.cs:3-26`, `RawCategoryOption.cs:3-17`).

## 데이터 액세스와 ID 관리
- 모든 쿼리는 `OracleCommand`로 직접 실행하며, 헬퍼 `ExecuteDataTable`/`ExecuteNonQuery`가 얇은 래퍼 역할만 한다 (`NutritionistForm.cs:1067-1110`). 별도의 ORM이나 리포지토리는 없다.
- ID는 `MAX(id)+1` 방식으로 생성돼 동시성에 취약하다 (`NutritionistForm.cs:2128-2143`, `NutritionistForm.cs:2301-2367`, `NutritionistForm.cs:3485-3509`).
- 각 호출이 자체적으로 커넥션을 열고 필요 시 트랜잭션을 직접 관리한다 (`NutritionistForm.cs:2308-2338`).

## 현재 공백과 위험 요소
- 로그인 디버그 팝업이 평문 비밀번호와 솔트를 노출하므로 배포 전 반드시 제거해야 한다 (`LoginForm.cs:178-185`).
- 공급업체·알레르기·만족도 등 관리자용 탭은 레이아웃만 있고 로직이 없어 관리자 경험이 미완성 상태다 (`AdminForm.cs:6-26`, `Tabs/Management/*.cs`).
- `MAX+1` 키 생성은 동시 생성 시 중복을 일으킬 수 있으므로 Oracle 시퀀스로 옮기는 것이 안전하다 (`NutritionistForm.cs:2128-2143`, `NutritionistForm.cs:3485-3509`).
- Oracle 두꺼운 클라이언트(x64) 설치와 로컬 고정 연결 문자열 때문에 다른 환경 배포 시 추가 구성이 필요하다 (`DatabaseConfig.cs:5-8`).
- 스키마에는 소비자·알레르기·피드백 테이블이 이미 존재하지만 `NutritionistForm` UI에서 다루지 않아 향후 범위 또는 기술 부채로 남아 있다.
