using Lite.Core.Combat.Weapons;
using Lite.Core.Enemy;
using Xunit;

namespace Lite.Tests.Domain;

public class HamasFighterTests
{
    [Fact]
    public void Constructor_Should_Throw_On_Null_Weapons()
    {
        Assert.Throws<ArgumentException>(() =>
            new HamasFighter("Abu", 1, null!));
    }

    [Fact]
    public void Constructor_Should_Throw_On_Empty_Weapons()
    {
        Assert.Throws<ArgumentException>(() =>
            new HamasFighter("Zaki", 3, Array.Empty<WeaponBase>()));
    }
}