using Lite.Domain.Combat.Weapons;
namespace Lite.Tests.Combat;

public class WeaponsTests
{
    [Theory]
    [InlineData(typeof(Knife), 1)]
    [InlineData(typeof(Gun),   2)]
    [InlineData(typeof(M16),   3)]
    [InlineData(typeof(Ak47),  3)]
    public void Weapon_Score_Should_Match_Expectation(Type weaponType, int expected)
    {
        var weapon = (WeaponBase)Activator.CreateInstance(weaponType)!;
        var actual = weapon.Score;
        Assert.Equal(expected, actual);
    }
}