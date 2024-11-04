using KafkaSpy.Web.Styling;
using Microsoft.AspNetCore.Components;

namespace KafkaSpy.Web.Components.Controls;

public partial class Select
{
    [Parameter]
    public SelectSize SelectSize { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool Enabled { get; set; }

    [Parameter]
    public int? MinWidth { get; set; }

    [Parameter]
    public bool ShowOptions { get; set; }

    protected string ClassName => 
        ClassBuilder.Default()
            .With(Enabled, "enabled", "disabled")
            .With(SelectSize == SelectSize.Medium, "medium", "large")
            .ToString();

    protected string StyleName =>
        StyleBuilder.Default()
            .With("min-width", MinWidth == null
                ? "auto"
                : MinWidth.Value.ToString())
            .ToString();
}
