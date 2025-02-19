using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDB
{
    internal static class TypeExtensions
    {
        public static bool IsRecord(this Type type)
            => type.GetMethods().Any(m => m.Name == "<Clone>$");

        public static bool IsFSharpOption(this Type type)
            => type.Name == "FSharpOption`1" && type.Module.Name == "FSharp.Core.dll";
    }
}
