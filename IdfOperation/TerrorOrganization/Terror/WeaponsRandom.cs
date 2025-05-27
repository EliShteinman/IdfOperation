using IdfOperation.Utils;

namespace IdfOperation.TerrorOrganization.Terror;

public class WeaponsRandom : WeaponBase
{
    public WeaponsRandom() : base(GetRandomType())
    {

    }

    private static string GetRandomType()
    {
        string[] weapons = new[] { "knife", "gun", "M16", "AK47" };
        return weapons[RandomGenerators.SharedRandom.Next(weapons.Length)];
    }

    protected override int CalculateScore(string type)
    {
        switch (type)
        {
            case "knife":
                return 1;
            case "gun":
                return 2;
            case "M16":
                return 3;
            case "AK47":
                return 3;
            default:
                return 0;
        }
    }

}