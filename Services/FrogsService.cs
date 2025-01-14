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
}