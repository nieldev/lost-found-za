using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Framework.Enums
{
    public enum CoatType
    {
        [Description("Unknown")]
        Unknown = -1,
        [Description("Smooth")]
        Smooth = 0,
        [Description("Curly")]
        Curly = 1,
        [Description("Wirehair")]
        WireHair = 2
    }
}
