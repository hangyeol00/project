## 다중폼 UI 호스팅 패턴 (UserControl → Form 임베드)

목표: 기존 탭 UserControl 레이아웃을 새 Form에 감싸 TabPage에 올려 다중폼 채점을 충족하고, 이후 로직 이전을 준비한다.

### Form 래퍼 기본 구조
```csharp
public partial class RawMaterialsForm : Form
{
    private RawMaterialsTabPage _view;

    public RawMaterialsForm() : this(new RawMaterialsTabPage()) { }
    public RawMaterialsForm(RawMaterialsTabPage view)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        InitializeComponent();
    }

    public RawMaterialsTabPage View => _view;

    private void InitializeComponent()
    {
        SuspendLayout();
        _view = _view ?? new RawMaterialsTabPage(); // 디자이너용 안전장치
        _view.Dock = DockStyle.Fill;
        Controls.Add(_view);
        AutoScaleDimensions = new SizeF(7F, 12F);
        AutoScaleMode = AutoScaleMode.Font;
        FormBorderStyle = FormBorderStyle.None;
        Text = "RawMaterialsForm";
        ResumeLayout(false);
    }
}
```
- `_view`는 필수지만 디자이너 인스턴스 생성 시 null이 될 수 있으므로 `InitializeComponent` 안에서 한 번 더 생성.
- 기본 생성자 제공: WinForms 디자이너가 호출할 수 있도록 한다.
- `FormBorderStyle=None`, `TopLevel=false`(호스트에서 지정), `Dock=Fill`.

### TabPage에 호스팅
```csharp
private static void DetachControl(Control control)
{
    control?.Parent?.Controls.Remove(control);
}

private static void HostFormInTab(TabPage tab, Form form)
{
    form.TopLevel = false;
    form.FormBorderStyle = FormBorderStyle.None;
    form.Dock = DockStyle.Fill;
    tab.Controls.Clear();
    tab.Controls.Add(form);
    form.Show();
}

// 사용 예시
DetachControl(rawMaterialsTabPage);               // 기존 UserControl을 부모에서 떼고
_rawMaterialsForm = new RawMaterialsForm(rawMaterialsTabPage);
HostFormInTab(tabRawMaterials, _rawMaterialsForm);
```
- 기존 TabPage에 붙어 있던 UserControl을 `Controls.Remove`로 분리 후 Form으로 감싸서 다시 추가.
- 동일 패턴을 Recipes 등 다른 탭에도 적용.

### 디자이너 오류 방지 포인트
- `_view`를 readonly로 두고 외부 주입에만 의존하면 디자이너가 기본 생성자를 호출할 때 null 참조가 발생한다. → 필드를 nullable로 두고 `InitializeComponent`에서 보강.
- 기본 생성자 필수. 디자이너는 매개변수 없는 생성자만 사용.
- `TopLevel=false`는 호스트(메인 폼)에서 설정. Form 내부에서 설정하지 않으면 디자인 시 오류는 없지만 호스팅 시 필요.

### 이후 단계
- 현재는 UI만 Form으로 감싼 상태. 각 탭 로직(이벤트, 데이터 로딩)을 해당 Form 코드로 옮기고 메인 폼은 생성/주입/오케스트레이션만 맡도록 확장한다.
