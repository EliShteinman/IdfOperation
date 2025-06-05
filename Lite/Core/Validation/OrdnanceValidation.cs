using Lite.Core.Enum;
namespace Lite.Core.Validation;

public class OrdnanceValidation
{
    public static void EnsureAllOrdnanceTypesArePermitted(BombType[] actualLoadout, BombType[] permittedTypesForUnit, string unitName)
    {
        if (actualLoadout == null)
        {
            return;
        }

        foreach (var bombType in actualLoadout)
        {
            if (!permittedTypesForUnit.Contains(bombType))
            {
                var allowedList = string.Join(", ", permittedTypesForUnit);
                throw new ArgumentException($"{unitName} cannot carry type {bombType}. Permitted types are: {allowedList}");
            }
        }
    }
}