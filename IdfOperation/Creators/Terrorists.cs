using IdfOperation.Forces;
namespace IdfOperation.Creators;
// ;
public class Terrorists : ITerrorist
{
    string name;
    int rank;
    bool status;
    List<IWeapon> weapons;

    public Terrorists()
    {
        Random r = new Random();
        rank = r.Next(1, 5);
        status = true;
        
    }
}
