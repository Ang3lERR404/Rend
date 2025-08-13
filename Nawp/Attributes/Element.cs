using Rend;
using Rend.Classes;
namespace Rend.Attributes;

public class AElement: Attribute {
  public AElement(string name, int id) {
    this.name = name;
    this.id = id;
    Elements.Add(this.name, this.id);
  }
  public
    string name { get; set; }
    int id { get; set; }
}