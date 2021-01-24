using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace TwitchsItems
{
    [StaticConstructorOnStartup]
    public static class TestMod
    {
        static TestMod()
        {
            Log.Message("Hello World!");
        }
    }
}
