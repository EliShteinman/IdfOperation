namespace IdfOperation.Forces.Idf;

public abstract class IdfSoldier : ISoldier
{
    public string Name { get; set; }
    public IdfRank Rank { get; set; }
    public IdfAssignment Assignment { get; set; }

    protected IdfSoldier(string name, string rank, string assignment)
    {
        Name = name;

        if (!Enum.TryParse(rank, true, out IdfRank parsedRank))
            throw new ArgumentException($"Rank '{rank}' is not valid.");

        if (!Enum.TryParse(assignment, true, out IdfAssignment parsedAssignment))
            throw new ArgumentException($"Assignment '{assignment}' is not valid.");

        Rank = parsedRank;
        Assignment = parsedAssignment;
    }
    public enum IdfRank
    {
        Turai,       // טוראי
        RavTarai,    // רב"ט
        Samal,       // סמל
        SamalRishon, // סמל ראשון
        Seren,       // סרן
        RavSeren,    // רב סרן
        SganAluf,    // סגן אלוף
        AlufMishne,  // אלוף משנה
        Aluf,        // אלוף
        RavAluf,     // רב אלוף
        Ramatkal     // רמטכ"ל
    }
    public enum IdfAssignment
    {
        Tayyas,         // טייס
        Mefaked,        // מפקד
        Lohem,          // לוחם
        Tanksit,        // טנקיסט
        Chovesh,        // חובש
        Tatzpitan,      // תצפיתן
        Modiin,         // מודיעין
        Kasher,         // קשר
        MafilRafan,     // מפעיל רחפן
        Handasa,        // הנדסה
        Madrich         // מדריך
    }
}