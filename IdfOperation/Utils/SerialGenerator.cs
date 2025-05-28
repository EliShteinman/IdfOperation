namespace IdfOperation.Utils;

public class SerialGenerator
{
    private int counter = 1;

    public string GetNext(string prefix = "UNIT")
    {
        string date = DateTime.Now.ToString("yyyyMMdd");
        return $"{prefix}-{date}-{counter++:D4}";
    }
    public void Reset() => counter = 1;
}
