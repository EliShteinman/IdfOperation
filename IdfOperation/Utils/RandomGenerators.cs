using IdfOperation.Utils.NameGenerator;

namespace IdfOperation.Utils;

public static class RandomGenerators
{
    public static readonly Random SharedRandom = new Random();
    public static readonly RandomName NameRandom = new RandomName();
    public static readonly SerialGenerator Serial = new();
}