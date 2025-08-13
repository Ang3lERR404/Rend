using System.Collections.Generic;

namespace Rend;
/// <summary>
/// This is more or less the Element Manager
/// allowing for easy adding, management, or even deletion.
/// It's made as a Dictionary to more easily extend upon it
/// Since the process of making an enum at runtime- forsomefuckingreason
/// is complicated.
/// </summary>
public class Elements {
  public
    Dictionary<string, int> elems = new();

  public Dictionary<string, int> constructor() {
    this.elems.Add("Life", 0);
    this.elems.Add("Earth", 1);
    this.elems.Add("Fire", 2);
    this.elems.Add("Shadow", 3);
    this.elems.Add("Air", 4);
    this.elems.Add("Water", 5);
    this.elems.Add("Salt", 6);
    return this.elems;
  }

  /// <summary>
  /// Adds a new element to the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  /// <param name="v">The integer value of the element</param>
  public void Add(string name, int v) {
    this.elems.Add(name, v);
  }

  /// <summary>
  /// Checks if the given element is in the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  /// <returns></returns>
  public bool has(string name) {
    return this.elems.ContainsKey(name);
  }

  /// <summary>
  /// Removes an element from the dictionary.
  /// </summary>
  /// <param name="name">The name of the element</param>
  public void rem(string name) {
    this.elems.Remove(name);
  }

  /// <summary>
  /// Planned, hides an element from the ui.
  /// </summary>
  /// <param name="name">The name of the element</param>
  public void hide(string name) {
    //noop
  }
}