using IdfOperation.NameGenerator;
namespace IdfOperation.Utils;

public static class RandomGenerators
{
    public static readonly Random SharedRandom = new();
    public static readonly RandomName NameGenerator = new();
}