using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using AvTex.ExpressApp.Blazor.Editors.Models;

namespace AvTex.ExpressApp.Blazor.Editors;

public class StepProgressBarPropertyEditor : BlazorPropertyEditorBase
{
    public StepProgressBarPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
    {
    }

    public override StepProgressBarModel ComponentModel => (StepProgressBarModel)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new StepProgressBarModel();

    protected override void ReadValueCore()
    {
        base.ReadValueCore();
        ComponentModel.Value = (int)PropertyValue;
    }
}