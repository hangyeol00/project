# 탭 분리 작업 보고

## 1. 개요
- `NutritionistForm`가 보유하던 모든 탭 UI를 개별 `TabPage`/`UserControl` 파일로 이동하여 폼 디자이너에서 탭 단위 편집이 가능하도록 재구성했다.
- 메인 대시보드는 `NutritionDashboardControl`(UserControl)로 교체하고, 관리 탭의 하위 탭은 `Tabs/Management` 폴더의 `*TabPage`로 각각 분리했다.
- `NutritionistForm`에서는 각 탭 컨트롤을 직접 참조하지 않고, 탭 클래스가 노출하는 `internal` 컨트롤을 전달받는 래퍼 속성을 통해 로직을 유지하였다.

## 2. 구조 변경 요약
| 탭 | 신규 클래스 |
| --- | --- |
| 대시보드 | `Tabs/Dashboard/NutritionDashboardControl` |
| 원재료/발주/영양/레시피/식단/사용자/알레르기/알레르기연결/평가 | `Tabs/Management/*TabPage` |

- 각 `TabPage`는 자체 `InitializeComponent`/`Designer` 파일을 가지며, `nutritionist.csproj`에 `Component`로 포함시켜 별도 디자이너에서 편집 가능.
- `NutritionistForm.Designer`에서는 각 탭을 새 클래스로 인스턴스화하고, 기존 거대한 컨트롤 정의를 제거하여 가독성을 확보했다.
- `NutritionistForm.cs`에는 탭별 컨트롤에 접근하기 위한 프록시 속성 블록을 추가하여 기존 로직(이벤트, 데이터 바인딩)을 큰 변경 없이 유지하였다.

## 3. 주의 사항 및 향후 작업
- 새 탭 클래스들은 `internal` 컨트롤을 노출하므로, 다른 곳에서 동일한 컨트롤을 직접 사용하는 경우에는 `NutritionistForm.cs`에 프록시 속성이 있어야 한다. 새 컨트롤을 탭에 추가하는 경우, 필요 시 동일한 패턴으로 래퍼 속성을 추가해야 한다.
- 현재 환경에는 `dotnet` CLI가 없어 빌드를 수행하지 못했다. 로컬 개발 PC에서 `dotnet build` 또는 Visual Studio로 한 번 전체 빌드를 수행해 UI 디자이너/리소스가 정상적으로 연결되는지 확인하는 것을 권장한다.
- Admin/MealEvaluation 등 아직 로직이 비어 있는 탭은 UI만 분리되어 있으며, 추후 기능 구현 시 각 탭 클래스 안에 필요한 컨트롤을 추가하고 `NutritionistForm`과의 연동 방법을 결정해야 한다.

## 4. 테스트
- CLI 환경에 `dotnet`이 설치되어 있지 않아 컴파일·실행 검증 불가. 로컬 개발 환경에서 전체 빌드 및 주요 시나리오(UI 표시, 데이터 로딩)를 확인해야 한다.
