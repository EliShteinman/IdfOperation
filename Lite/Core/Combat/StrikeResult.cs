using Lite.Core.Enum;

namespace Lite.Core.Combat;

public class StrikeResult
{
    public bool WasSuccess { get; }
    
    public BombType? BombUsed { get; }

    public string OutcomeMessage { get; }

    public StrikeResult(bool wasSuccess, BombType? bombUsed, string outcomeMessage)
    {
        WasSuccess = wasSuccess;
        BombUsed = bombUsed;
        OutcomeMessage = outcomeMessage;
    }
}