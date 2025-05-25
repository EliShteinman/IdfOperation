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
        hamas.Commander = new TerroristRandomali(hamas);
        hamas.Date = DateTime.Now;
        Idf idf = new Idf();

    }
}