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

    protected string Style =>
        StyleBuilder.Default()
            .With("height", SelectSize == SelectSize.Medium
                ? "32px"
                : "40px")
            .With("color", Enabled
                ? "var(--select-color-normal)"
                : "var(--select-color-disabled)")
            .With("min-width", MinWidth == null
                ? "auto"
                : MinWidth.Value.ToString())
            .With("cursor", Enabled
                ? "pointer"
                : "not-allowed")
            .ToString();
}
