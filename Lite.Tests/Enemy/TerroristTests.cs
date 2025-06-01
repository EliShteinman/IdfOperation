using Lite.Domain.Enemy;
using Lite.Domain.Combat.Weapons;
namespace Lite.Tests.Enemy;

public class TerroristTests
{
    [Fact]
    public void Ctor_Should_Throw_When_No_Weapons()
    {
        var weapons = Array.Empty<WeaponBase>();
        Assert.Throws<ArgumentException>(() =>
            new HamasFighter("Ali", 1, weapons));
    }
}