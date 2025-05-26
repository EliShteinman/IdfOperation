using IdfOperation.Forces.Idf.Soldiers;
using IdfOperation.Forces.Terror;
using IdfOperation.Organization;
using IdfOperation.Utils;

namespace IdfOperation;
class Program
{
    public static void Main()
    {
        var hamas = new TerrorOrg();
        hamas.Name = "hamas";
        hamas.Commander = new TerroristRandomizer(hamas);
        hamas.Date = DateTime.Now;
        var idf = new Idf();
        idf.Name = "idf";
        idf.Commander = new ChiefOfStaff();
        idf.Date = DateTime.Now;
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(5, 10); i++)
        {
            new TerroristRandomizer(hamas);
        }
    }
}