namespace froggy_finder_api.Models;

// NOTE your model needs to support all column types from your respective sql table
public class Frog
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Species { get; set; }
  public int Size { get; set; }
  public bool IsPoisonous { get; set; }
  public string Bio { get; set; }
}