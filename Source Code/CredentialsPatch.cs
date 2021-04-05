using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOtherRoles
{
    [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
    public static class VersionShowerPatch
    {
        static void Postfix(VersionShower __instance) {
            string spacer = new String('\n', 15);
            string text = "[FCCE03FF]MadMod [] v1.0.0:\n- Modded by [FCCE03FF]mattmilesi[] and the [FFEB91FF]MadBit Coding GVNG[]\n- Based on [FFEB91FF]TheOtherRoles";
            if (__instance.text.Text.Contains(spacer))
                __instance.text.Text += "\n" + text;
            else
                __instance.text.Text += spacer + text;
        }
    }

    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingTrackerPatch
    {
        static void Postfix(VersionShower __instance)
        {
            __instance.text.Text += "\n[FCCE03FF]MadMod[FFFFFFFF]";
            __instance.text.Text += "\nModded by the [FCCE03FF]MadBit Coding GVNG[FFFFFFFF]";
        }
    }
}
