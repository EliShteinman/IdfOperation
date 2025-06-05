using Lite.Core.Enum;
namespace Lite.Core.Validation;

public static class TargetValidation
{
    public static void EnsureExactMatch(KnownLocationType[] actual, KnownLocationType[] allowed, string unitName)
    {
        if (actual == null || actual.Length == 0)
            throw new ArgumentException($"{unitName} must have at least one target");

        if (!actual.OrderBy(x => x).SequenceEqual(allowed.OrderBy(x => x)))
        {
            var allowedList = string.Join(", ", allowed);
            throw new ArgumentException($"{unitName} must target only: {allowedList}");
        }
    }
}
