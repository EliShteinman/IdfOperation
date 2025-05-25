namespace IdfOperation.Forces;

public abstract class WeaponBase
{
    public string Type { get; protected set; }
    public int Score { get; protected set; }

    protected WeaponBase(string type)
    {
        Type = type;
        Score = CalculateScore(type); // ⬅️ קובע את הדרגה לפי סוג הנשק
    }

    protected abstract int CalculateScore(string type);

}