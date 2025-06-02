using Lite.Domain.Combat.Weapons;
namespace Lite.Tests.Combat;

public class WeaponsTests
{
    [Theory]
    [InlineData(typeof(Knife), 1, "Knife")]
    [InlineData(typeof(Gun),   2, "Gun")]
    [InlineData(typeof(M16),   3, "M16")]
    [InlineData(typeof(Ak47),  3, "Ak47")]
    public void Weapon_Score_Should_Match_Expectation(Type weaponType, int expectedScore, string expectedName)
    {
        var weapon = (WeaponBase)Activator.CreateInstance(weaponType)!;
        Assert.Equal(expectedScore, weapon.Score);
        Assert.Equal(expectedName, weapon.Name);
    }
}