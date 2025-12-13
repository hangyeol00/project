## NutritionistForm 대시보드 UserControl 분리 지시서

### 1. 목표
- `NutritionistForm` 본체에서 대시보드 UI 블록을 `UserControl`로 분리하여 폼 디자이너 부담을 줄이고, 관리 탭과 동일한 구조로 확장성을 확보한다.
- 분리 이후에도 기존 `NutritionistForm.cs` 로직(이벤트, 데이터 로딩)은 최대한 유지하고, 필요한 컨트롤은 UserControl에서 `internal` 속성으로 노출한다.

### 2. 준비 사항
1. `Tabs/Dashboard` 폴더 하위에 새 UserControl 파일(`NutritionDashboardControl.cs` + `.Designer.cs` + `.resx`)을 생성한다.
2. `nutritionist.csproj`에 새 파일을 `<Compile>`/`<EmbeddedResource>` 항목으로 추가한다. (관리 탭 추가 방식과 동일)

### 3. 구현 단계
1. **대시보드 영역 파악**
   - `NutritionistForm.Designer.cs` 내 `tabDashboard`에 포함된 컨트롤(통계 요약, 학생/메뉴/급식 로그 그리드, 액션 버튼 등)을 모두 식별한다.
   - `menuStrip`, `panelNav`, `tabMain` 등 폼 전역 요소는 그대로 두고, 탭 내부 컨트롤만 사용자 컨트롤로 이동한다.
2. **UserControl 생성 및 레이아웃 이동**
   - 새 UserControl의 `InitializeComponent`에 현재 `tabDashboard` 안의 컨트롤 정의를 그대로 옮긴다.
   - 루트 컨테이너를 `Dock = DockStyle.Fill`로 유지하여 `tabDashboard.Controls.Add(new NutritionDashboardControl());` 형태로 교체했을 때 기존 레이아웃이 동일하게 표현되도록 한다.
3. **컨트롤 노출 설계**
   - `NutritionistForm.cs`가 직접 참조하는 컨트롤(예: `dgvStudents`, `dgvMealLogs`, `btnServeMeal`, 요약 레이블 등)을 UserControl에서 `internal` 프로퍼티로 노출한다.
   - 예) `internal DataGridView DgvStudents => dgvStudents;`
   - 이후 `NutritionistForm.cs`에서는 기존 필드 대신 `NutritionDashboardControl.DgvStudents` 형태를 사용하도록 래퍼 속성을 정의한다.
4. **NutritionistForm 수정**
   - `tabDashboard` 초기화 시 `Controls.Clear()` 후 새 UserControl 인스턴스를 추가한다.
   - Dashboard 관련 필드를 `private NutritionDashboardControl Dashboard => dashboardTabControl;`로 교체하고, 종속 컨트롤 접근자를 UserControl의 노출된 속성을 이용하도록 바꾼다.
   - 이벤트 연결(`dgvStudents.CellClick`, `btnServeMeal.Click` 등)은 `Dashboard` 속성에서 가져온 컨트롤에 대해 수행한다.
5. **리소스 및 네임스페이스 정리**
   - 이동한 컨트롤 리소스를 `NutritionDashboardControl.resx`로 옮기고, `NutritionistForm.resx`에서는 해당 항목 삭제.
   - 새 파일에 `namespace nutritionist.Tabs`를 적용하여 기존 `using nutritionist.Tabs;` 참조와 일치시킨다.

### 4. 테스트 및 검증
1. Visual Studio에서 `NutritionistForm` 디자이너를 열어 오류가 없는지 확인한다.
2. `Build > Rebuild Solution`으로 전체 빌드.
3. 실행 시 대시보드 UI가 기존과 동일하게 표시되고, 학생/메뉴/로그/버튼 이벤트가 정상 동작하는지 수동 확인한다.

### 5. 후속 작업 제안
- 대시보드 외에도 `panelNav` 또는 상단 메뉴/정보 패널을 별도 UserControl로 분리할 필요가 있다면 동일 패턴으로 확장한다.
- 유지보수를 위해 UserControl 내부에서도 로직/이벤트를 캡슐화할 수 있는지 검토한다. (예: 요약 통계 계산을 UserControl 메서드로 노출)
