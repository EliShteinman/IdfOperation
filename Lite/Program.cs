using Lite.Application.Services;
using Lite.Core.Combat.Weapons;
using Lite.Core.Enemy;

namespace Lite;

class Program
{
    static void Main(string[] args)
    {
        var initializer = new SimulationInitializer();
        initializer.Initialize();

    }
}