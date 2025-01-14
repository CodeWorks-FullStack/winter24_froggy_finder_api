namespace froggy_finder_api.Repositories;

public class FrogsRepository
{
  public FrogsRepository(IDbConnection db)
  {
    _db = db;
  }

  private readonly IDbConnection _db; // dbContext


  public List<Frog> GetAllFrogs()
  {
    string sql = "SELECT * FROM frogs;";

    // NOTE query is a dapper method, dapper is the ORM we are using in our dotnet webapi
    List<Frog> frogs = _db.Query<Frog>(sql).ToList();
    return frogs;
  }
}