﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using VFECore;

namespace VanillaGenesExpanded
{
    [HarmonyPatch(typeof(Pawn), "BodySize", MethodType.Getter)]
    public static class Pawn_BodySize
    {
        public static void Postfix(ref float __result, Pawn __instance)
        {
            if (ScaleCache.GetScaleCache(__instance) is SizeData data)
            {
                __result = data.totalSize;
            }
        }
    }
}