## 다중폼 리팩터링 패턴 가이드

### 목표
- 채점 기준의 “다중폼” 사용을 충족하면서, 탭별 로직을 해당 Form으로 이동해 `NutritionistForm.cs` 복잡도를 낮춘다.
- 기존 `Tabs/Management/*TabPage` UserControl 레이아웃을 재사용하고, Form은 컨테이너 + 로직 소유자가 되도록 한다.

### 역할 분리
- **메인 폼(NutritionistForm)**: 메뉴/탭 전환, 세션·서비스 생성 및 전달, 폼 임베드(TopLevel=false, FormBorderStyle=None, Dock=Fill), 폼 간 오케스트레이션 이벤트만 보유.
- **각 기능 Form(예: RawMaterialsForm, RecipesForm)**: 해당 영역 UI(UserControl) 소유, 데이터 로딩/필터/이벤트 핸들링/상태 보관. 메인에 콜백이 필요하면 이벤트로 노출.
- **UserControl(TabPage)**: 순수 레이아웃. 내부 컨트롤은 `internal`로 노출해 Form 코드비하인드가 접근.

### 탭→폼 변환 절차
1. **폼 생성**: `Forms/*Form.cs`를 만들고, 생성자에서 대응 UserControl을 받아 `Controls.Add(...)` + `Dock = Fill`로 붙인다. `public <TabPageType> View => _view;` 식으로 노출.
2. **메인 폼에서 임베드**: 기존 TabPage가 가진 UserControl을 `TabPage.Controls.Remove(view);`로 떼어낸 뒤 Form을 생성하고 `TopLevel=false`, `FormBorderStyle=None`, `Dock=Fill`로 TabPage에 추가 후 `Show()`.
3. **로직 이동**: 메인 폼의 해당 영역 필드/메서드/이벤트를 Form으로 옮긴다. 공통 의존성(세션, 데이터 서비스)은 Form 생성자 주입. 메인과 상호작용이 필요하면 Form 이벤트를 구독하도록 변경.
4. **중복 방지**: 폼 인스턴스는 필드에 캐시하여 재사용(`if (form == null || form.IsDisposed) form = new ...`).
5. **검증**: 임베드 후 UI가 기존과 동일하게 보이는지, 이벤트/데이터 로딩이 정상 동작하는지 확인.

### 호스트 헬퍼 예시
```csharp
private static void HostForm(TabPage tab, Form form)
{
    form.TopLevel = false;
    form.FormBorderStyle = FormBorderStyle.None;
    form.Dock = DockStyle.Fill;
    tab.Controls.Add(form);
    form.Show();
}
```

### 후속 제안
- Raw/Recipe 폼에서 시작해 패턴을 확립하고, 나머지 탭도 동일 방식으로 확장.
- 공통 DB 접근/헬퍼는 별도 서비스 클래스로 올려 각 폼에 주입.
- 폼 간 데이터 갱신이 필요하면 메인 폼이 이벤트를 받아 다른 폼의 `Reload` 메서드를 호출하는 식으로 연결.
