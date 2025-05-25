using IdfOperation.Forces;
namespace IdfOperation.Creators;

public class WeaponsRandom : WeaponBase
{
    public WeaponsRandom() : base(GetRandomType() )
        {
            
        }

        private static string GetRandomType()
        {
            string[] weapons = new[] {"knife", "gun", "M16", "AK47"};
            Random r = new Random();
            return weapons[r.Next(weapons.Length)];
        }

        protected override int CalculateScore(string type)
        {
            switch (type)
            {
                case "knife":
                    return  1;
                    break;
                case "gun":
                    return 2;
                    break;
                case "M16":
                    return 3;
                    break;
                case "AK47":
                    return 3;
                    break;
                default:
                    return 0;
                    break;
            }

            
        }

    
}