
namespace froggy_finder_api.Services;

// NOTE services are responsible for sending data back to controller, business logic, and calling to the repository layer
public class FrogsService
{

  public FrogsService(FrogsRepository frogsRepository)
  {
    _frogsRepository = frogsRepository;
  }


  private readonly FrogsRepository _frogsRepository;


  public List<Frog> GetAllFrogs()
  {
    List<Frog> frogs = _frogsRepository.GetAllFrogs();
    return frogs;
  }

  public Frog GetFrogById(int frogId)
  {
    Frog frog = _frogsRepository.GetFrogById(frogId);

    if (frog == null) throw new Exception($"No frog with the id of {frogId}"); //throw new Error()

    return frog;
  }

  public Frog CreateFrog(Frog frogData)
  {
    Frog frog = _frogsRepository.CreateFrog(frogData);
    return frog;
  }
}