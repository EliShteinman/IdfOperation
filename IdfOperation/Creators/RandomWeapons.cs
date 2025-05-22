namespace IdfOperation.Creators;

public class RandomWeapons : Weapons
{
    int Score { get; }
    string Type { get; }
    public RandomWeapons()
    {
        Random r = new Random();
        string[] weapons = ["knife", "gun", "M16", "AK47"];
        this.Type = weapons[r.Next(weapons.Length)];
        this.Score = 0;
        switch (Type)
        {
            case "knife":
                this.Score = 1;
                break;
            case "gun":
                this.Score = 2;
                break;
            case "M16":
                this.Score = 3;
                break;
            case "AK47":
                this.Score = 3;
                break;
        }
        
    }
}