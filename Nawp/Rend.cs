using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Rend.Classes;

// ReSharper disable InvertIf

#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Rend;

[BepInPlugin(GUID, Name, VERSION)]
public class Rend {
  const string GUID = "ang3l404";
  const string Name = "Rend";
  const string VERSION = "1.1.0";
  internal static ManualLogSource Log;
  readonly Harmony h = new(GUID);

  void Awake() {
    Log = Logger;
    Log.LogInfo($"Plugin {Name} loaded");
    h.PatchAll();
  }

  [HarmonyPatch(typeof(Upgrades), "Awake")]
  class UpgradesAwakePatch {
    [HarmonyPostfix]
    public static void Postfix(Upgrades inst) {
      Log.LogInfo("Upgrades.Awake() Completed, Running postfix.");
      if (inst == null) {
        Log.LogError("The instance was null");
        return;
      }
    }
  }
  
}