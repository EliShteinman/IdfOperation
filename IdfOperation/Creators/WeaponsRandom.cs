using IdfOperation.Forces.Terror;
namespace IdfOperation.Creators;

public class WeaponsRandom : WeaponBase
{
    private static readonly Random SharedRandom = new Random();
    public WeaponsRandom() : base(GetRandomType())
    {

    }

    private static string GetRandomType()
    {
        string[] weapons = new[] { "knife", "gun", "M16", "AK47" };
        return weapons[SharedRandom.Next(weapons.Length)];
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