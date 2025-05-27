namespace IdfOperation.TerrorOrganization.Hamas.Forces;

public abstract class WeaponBase
{
    public string Type { get; protected set; }
    public int Score { get; protected set; }

    protected WeaponBase(string type)
    {
        Type = type;
        Score = CalculateScore(type);
    }

    protected abstract int CalculateScore(string type);

}