using Lite.Core.Contracts;
using Lite.Core.Enum;
using Lite.Core.Forces.Idf;
using Xunit;

file sealed class DummyPilot : ISoldier
{
    public string Name => "P";
    public IdfRanks  IdfRank => IdfRanks.Capt;
    public Assignments Assignment => Assignments.Pilot;
}

file sealed class DummyPlane : Plane
{
    public DummyPlane(int ammo, double fuel, int limit)
        : base("D", ammo, fuel, limit, new[] { "X" }, new DummyPilot()) { }

    public override bool IsAvailableForStrike()
        => Ammunition > 0 && Fuel > 0 && StrikeCycleLimit > 0;

    protected override void ExecuteStrike()
    {
        Ammunition--;
        Fuel--;
        StrikeCycleLimit--;
    }
}

public class StrikeUnitTests
{
    [Fact]
    public void Strike_Should_Return_False_When_No_Ammo()
    {
        var plane = new DummyPlane(0, fuel: 1, limit: 1);
        Assert.False(plane.Strike());
    }
}