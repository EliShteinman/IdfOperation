using IdfOperation.Forces.Idf.Soldiers;
using IdfOperation.Forces.Terror;
using IdfOperation.Organization;

namespace IdfOperation;
class Program
{
    static void Main()
    {
        Random ran = new Random();
        TerrorOrg hamas = new TerrorOrg();
        hamas.Name = "hamas";
        hamas.Commander = new TerroristRandomizer(hamas);
        hamas.Date = DateTime.Now;
        Idf idf = new Idf();
        idf.Name = "idf";
        idf.Commander = new ChiefOfStaff();
        idf.Date = DateTime.Now;
        for (int i = 0; i < ran.Next(5,10); i++)
        {
            new TerroristRandomizer(hamas);
        }
    }
}