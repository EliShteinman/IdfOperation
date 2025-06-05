namespace Lite.Core.Intelligence;

public class Aman
{
    private static Aman? _instance;
    public List<IntelligenceMessage> Messages { get; private set; }

    public void AddMessage(IntelligenceMessage message)
    {
        Messages.Add(message);
    }

    private Aman()
    {
        Messages = [];
    }

    public static Aman CreateInstance()
    {
        if (_instance is null)
        {
            _instance = new Aman();
        }
        return _instance;
    }

    public static Aman Instance
    {
        get
        {
            if (_instance is null)
            {
                throw new InvalidOperationException("Must call CreateInstance(...) before accessing the instance.");
            }
            return _instance;
        }
    }
}