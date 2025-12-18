## 다중폼 리팩터링 진행 상황 (2024-xx-xx 기준)

### 완료
- **다중폼 호스팅**: 원재료/요리 탭 UI를 Form(`RawMaterialsForm`, `RecipesForm`)으로 감싸 TabPage에 임베드.
- **식단 탭 UI 래핑**: `MealPlansTabPage`를 `MealPlansForm`으로 감싸 TabPage에 임베드(로직 미이전).
- **원재료 로직 이동**: `RawMaterialsForm.Logic.cs`에 원재료 데이터 로딩/필터/그리드/상세/추가/분류 토글/영양 로딩 로직을 이동. 메인 폼은 호출 위임만 수행.
- **요리(레시피) 로직 이동**: `RecipesForm.Logic.cs`에 레시피 데이터 로드/영양 요약/필터/상세/구성/컨텍스트 메뉴 로직을 이동. 메인은 폼 메서드 호출 및 영양 데이터 참조만 수행.
- **DB 헬퍼**: 원재료 폼에 `ExecuteDataTable/ExecuteNonQuery/ExecuteScalar` 포함하여 독립성 확보, ID 발급은 `GetNextId`.
- **안정화**: 원재료 추가 시 분류 콤보박스 바인딩 타이밍으로 인한 `SelectedIndex` 예외를 방지 (`SelectedIndex=-1` 후 Items 확인).
- **문서**: 
  - `multi_form_refactor.md`: 다중폼 리팩터링 패턴/역할.
  - `multi_form_ui_hosting.md`: UserControl→Form 임베드 패턴/디자이너 주의점.

### 메인 폼 정리 사항
- 원재료 관련 이벤트/로딩/상세/필터 코드 제거 및 `RawMaterialsForm` 위임.
- 발주 요청 시 원재료 목록/선택 ID를 `RawMaterialsForm`에서 받음.

### 남은 작업 / 계획
- **식단 탭 로직 이동**: 식단 데이터 로드, 주차 선택, 식단 등록/승인/삭제, 알레르기 경고/대체메뉴 할당, 영양 요약 계산 등을 `MealPlansForm`으로 이전.
- **레시피 등록/편집 구현**: 현재 `BtnRegisterRecipe_Click`는 안내만 표시. 신규/수정 다이얼로그 및 DB 연동 필요.
- **교차 연동 검증**: 원재료→레시피, 레시피→원재료 이동 경로 동작/필터 상태 확인.
- **공통 헬퍼 통합**: FormatDecimal/ExecuteDataTable/이벤트 유틸 등 중복을 공유 유틸 클래스로 이동 검토.
- **테스트/안정화**: 필터/정렬/컨텍스트 메뉴/영양 요약 계산 값 검증, 경고 정리.
