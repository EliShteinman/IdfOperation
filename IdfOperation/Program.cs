using IdfOperation.Forces.Terror;
using IdfOperation.Organization;

namespace IdfOperation;
class Program
{
    static void Main()
    {
        Random ran = new Random();
        Terror hamas = new Terror();
        hamas.Name = "hamas";
        hamas.Commander = new TerroristRandomali(hamas);
        hamas.Date = DateTime.Now;
        Idf idf = new Idf();

    }
}