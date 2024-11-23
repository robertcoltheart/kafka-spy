using KafkaSpy.Web.Components.Pages;
using Microsoft.AspNetCore.Components.Web;

namespace KafkaSpy.Web.Tests;

public class HomePageTests : TestContext
{
    [Fact]
    public void PageHasTitle()
    {
        var cut = RenderComponent<Home>();

        var title = cut.FindComponent<PageTitle>();

        Assert.NotNull(title);
    }
}
