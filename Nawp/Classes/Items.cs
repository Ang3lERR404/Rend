using System;
using BepInEx;
using Data;
using HarmonyLib;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Tilemaps;

#nullable disable
namespace Rend.Classes;

[CreateAssetMenu(fileName = "Items", menuName = "Rend/Items", order = 1)]
public class Items : ScriptableObject {
  public
    string name;
    string desc;
    EntityData e;
    int id;
    Material mat;
    VisualEffectAsset vfxa;
    Gradient fxgrad;
    Gradient collGrad;
    bool isStruct;
    bool craftable;
    #if isStruct == true
      StructureData sdt;
      bool crafter;
      #if crafter == true
      #endif
    #endif

    [Serializable]
    public class DensitySpriteList {
      public
        int thrshDens;
        TileBase tileRule;
    }
}