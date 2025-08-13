using System.Collections.Generic;
using Rend;

namespace Rend.Classes;
/// <summary>
/// This is more or less the Element Manager
/// allowing for easy adding, management, or even deletion.
/// It's made as a Dictionary to more easily extend upon it
/// Since the process of making an enum at runtime- forsomefuckingreason
/// is complicated.
/// </summary>
public class Elements {
  public
    static Dictionary<string, int> elems = new();

  public Elements() {
    elems.Add("Life", 0);
    elems.Add("Earth", 1);
    elems.Add("Fire", 2);
    elems.Add("Shadow", 3);
    elems.Add("Air", 4);
    elems.Add("Water", 5);
    elems.Add("Salt", 6);
  }

  /// <summary>
  /// Adds a new element to the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  /// <param name="v">The integer value of the element</param>
  public static void Add(string name, int v) {
    if (has(name)) {
      Rend.Log.LogError($"Element '{name}' already exists");
      return;
    }
    elems.Add(name, v);
  }

  /// <summary>
  /// Checks if the given element is in the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  /// <returns></returns>
  public static bool has(string name) {
    return elems.ContainsKey(name);
  }

  /// <summary>
  /// Removes an element from the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  public void rem(string name) {
    if (!has(name)) {
      Rend.Log.LogError($"Element '{name}' does not exist");
      return;
    }
    elems.Remove(name);
  }

  /// <summary>
  /// Planned, hides an element from the ui.
  /// </summary>
  /// <param name="name">The name of the element</param>
  public static void hide(string name) {
    //noop
  }
}