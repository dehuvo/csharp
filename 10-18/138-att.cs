using System;

[AttributeUsage(AttributeTargets.Class)]
class AdditionalInfoAttribute : Attribute {
  public string Name { get; }
  public string Update { get; }
  public string Download { get; set; }

  public AdditionalInfoAttribute(string name, string update) {
    this.Name = name;
    this.Update = update;
  }
}