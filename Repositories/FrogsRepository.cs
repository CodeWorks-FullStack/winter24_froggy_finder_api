

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

  public Frog GetFrogById(int frogId)
  {
    // NOTE string interpolation is very very VERY bad for sql statements
    // string sql = $"SELECT * FROM frogs WHERE id = {frogId};";

    string sql = "SELECT * FROM frogs WHERE id = @frogId;";

    //                                   {frogId: 3}
    Frog frog = _db.Query<Frog>(sql, new { frogId = frogId }).SingleOrDefault();
    return frog;
  }

  internal Frog CreateFrog(Frog frogData)
  {
    string sql = @"INSERT INTO 
                  frogs(species, name, size, is_poisonous, bio)
                  VALUES(@Species, @Name, @Size, @IsPoisonous, @Bio);
                  
                  SELECT * FROM frogs WHERE id = LAST_INSERT_ID();";

    Frog frog = _db.Query<Frog>(sql, frogData).SingleOrDefault();

    return frog;

  }
}