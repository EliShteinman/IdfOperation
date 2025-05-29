using IdfOperation.Idf.Commands.AirForce.Forces.F16;
using IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;
using IdfOperation.Idf.Commands.GroundForces.Forces.M109;
using IdfOperation.Idf.Commands.Soldiers;
using IdfOperation.TerrorOrganization.Hamas;
using IdfOperation.TerrorOrganization.Hamas.Forces;
using IdfOperation.Utils;

namespace IdfOperation;

/// <summary>
/// נקודת הכניסה הראשית למערכת הסימולציה
/// </summary>
class Program
{
    /// <summary>
    /// מאתחל את ארגוני חמאס וצה"ל, יוצר חיילים ויחידות תקיפה לצורך סימולציה בסיסית
    /// </summary>
    public static void Main()
    {
        // יצירת מופע של חמאס עם תאריך התחלה לפני 15 שנה
        var hamas = Hamas.CreateInstance("hamas", new TerroristRandomizer(), DateTime.Now.AddYears(-15));

        // יצירת מופע של צה"ל עם רמטכ"ל ותאריך הקמה לפני 78 שנה
        var idf = Idf.Idf.CreateInstance("idf", new ChiefOfStaff(), DateTime.Now.AddYears(-78));

        // הוספת מחבלים אקראיים לחמאס (בין 5 ל־10)
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(5, 11); i++)
        {
            hamas.Terrorists.Add(new TerroristRandomizer());
        }

        // הוספת יחידות תקיפה לצה"ל: מטוס קרב, רחפן וארטילריה
        idf.StrikeUnits.Add(new F16FullyLoaded());
        idf.StrikeUnits.Add(new Hermes460FullyLoaded());
        idf.StrikeUnits.Add(new M109FullyLoaded());
    }
}