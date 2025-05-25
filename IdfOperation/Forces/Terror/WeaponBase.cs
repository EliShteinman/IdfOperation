namespace IdfOperation.Forces.Terror;

public abstract class WeaponBase : IWeapon
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