using KafkaSpy.Api.Controllers;

namespace KafkaSpy.Api.Tests.Controllers;

public class ClustersControllerTests
{
    [Fact]
    public void CanCreate()
    {
        var controller = new ClustersController();

        Assert.NotNull(controller);
    }
}
