using Data;
using UnityEngine;

namespace Rend.Interfaces;

public interface IElement {
  string name;
  int id;
  EntityData e;
  ElementData e2;
  Material mat;
}