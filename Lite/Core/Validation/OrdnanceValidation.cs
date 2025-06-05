using Lite.Core.Enum;
namespace Lite.Core.Validation;

public class OrdnanceValidation
{
    public static void EnsureExactMatch(BombType[] actual, BombType[] allowed, string unitName)
    {
        if (actual == null || actual.Length == 0)
            throw new ArgumentException($"{unitName} must have at least one type");
        if (!actual.OrderBy(x => x).SequenceEqual(allowed.OrderBy(x => x)))
        {
            var allowedList = string.Join(", ", allowed);
            throw new ArgumentException($"{unitName} must types ammo only: {allowedList}");

        }

    }
}