using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MonoMod;
using Mono.Cecil;
using Mono.Cecil.Cil;

public static class patch_BotlabUtilities
{
    [MonoModReplace]
    static patch_BotlabUtilities()
    {
        patch_BotlabUtilities.decimalDigits = 7;
    }
    private static int decimalDigits;
}