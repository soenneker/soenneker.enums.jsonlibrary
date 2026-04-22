using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.JsonLibrary.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class JsonLibraryTypeTests : HostedUnitTest
{
    public JsonLibraryTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
