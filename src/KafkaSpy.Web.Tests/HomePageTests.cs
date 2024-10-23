using KafkaSpy.Web.Components.Pages;

namespace KafkaSpy.Web.Tests;

public class HomePageTests : TestContext
{
    [Fact]
    public void CounterStartsAtZero()
    {
        var cut = RenderComponent<Home>();

        cut.Find("h1").MarkupMatches("<h1>Hello, world!</h1>");
    }
}
