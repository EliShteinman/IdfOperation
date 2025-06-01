using Lite.Domain.Enemy;
using Lite.Domain.Combat.Weapons;
using Lite.Application.Services;
namespace Lite.Tests.Services;

public class ThreatAnalysisTests
{
    [Fact]
    public void CalculateRisk_Should_Return_SumScore_Times_Rank()
    {
        var fighter = new HamasFighter(
            "Ali", 2, new WeaponBase[] { new Gun(), new Knife() });
        var risk = ThreatAnalysis.CalculateRisk(fighter);
        Assert.Equal(6, risk);
    }
}