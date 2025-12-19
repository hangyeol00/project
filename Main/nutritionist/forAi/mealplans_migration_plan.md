# MealPlansForm 로직 분리 계획

현재 상황
- MealPlans UI는 `Forms/MealPlansForm`으로 이식했지만, 식단 계획 관련 로직/이벤트 대부분이 `NutritionistForm.cs`에 남아 있음.
- `NutritionistForm`은 `MealPlansForm`의 컨트롤을 직접 조작(그리드, 리스트, 버튼 이벤트 등)하고, 데이터 로드/저장/승인 로직도 가지고 있음.

목표
- MealPlans 관련 UI/이벤트/데이터 로직을 `MealPlansForm` 내부로 완전 이전.
- `NutritionistForm`은 MealPlansForm 생성/호스팅 및 세션·RecipesForm 주입만 담당.

이전 단계
1) 컨트롤/이벤트 초기화 이동  
   - `InitializeMealPlannerControls`, `InitializePlanSelectionControls` 등에서 주간 식단 그리드/일정/버튼 이벤트를 `MealPlansForm`으로 옮긴다.  
   - `NutritionistForm`에서 MealPlans 컨트롤 프록시/이벤트 연결 코드 제거.

2) 데이터 로드/저장 로직 이동  
   - `LoadMealPlans`, `LoadMealMenusFromDatabase`, `LoadMealRecipesForCurrentPlan`, `SaveMealRecipesForCurrentPlan`, `LoadAltAssignmentsForMealDate` 등을 `MealPlansForm` 메서드로 이관.  
   - 공개 API로 `LoadMealPlans()`, `ReloadMenus()`, `ApplyMenuFilter()` 등을 노출하고 `NutritionistForm`에서는 호출만 한다.

3) 승인/태그/알레르기 요약 이동  
   - 승인/요청(승인 버튼 핸들러), 태그/메뉴 알레르기 요약(현재 `LoadMenuAllergySummary`, `LoadAllergyConsumerCounts`) 중 MealPlans 전용 부분을 `MealPlansForm`으로 옮긴다.  
   - 공용 캐시/다른 탭에서 써야 하는 요약은 별도 서비스/헬퍼로 분리하거나 `MealPlansForm`에서 읽기 전용 프로퍼티로 제공.

4) `NutritionistForm` 슬림화  
   - MealPlans 관련 프록시/필드/메서드 제거.  
   - 탭 초기화에서 `new MealPlansForm(_session, _recipesForm)`만 호스팅하고, 필요한 때 공개 메서드만 호출.

검증 체크리스트
- MealPlans 탭 열기/데이터 로드/필터/드래그·더블클릭/승인/메모가 정상 동작.
- 다른 탭(식단 보드 요약, 알레르기/영양 요약)이 필요로 하는 데이터가 끊기지 않았는지 확인.
- 불필요해진 TabPage/리소스/프록시 코드가 모두 제거되었는지 확인.
