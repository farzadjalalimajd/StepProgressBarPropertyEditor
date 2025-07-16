using DevExpress.ExpressApp.Blazor.Components.Models;
using JMTech.ExpressApp.Blazor.Editors.Renderers;

namespace JMTech.ExpressApp.Blazor.Editors.Models;

public class StepProgressBarModel : ComponentModelBase
{
    public int Value
    {
        get => GetPropertyValue<int>(0);
        set => SetPropertyValue(value);
    }

    public List<string> Steps
    {
        get => GetPropertyValue<List<string>>([]);
        set => SetPropertyValue(value);
    }

    public override Type ComponentType => typeof(StepProgressBarRenderer);
}
