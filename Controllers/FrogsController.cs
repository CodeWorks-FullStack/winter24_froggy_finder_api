namespace froggy_finder_api.Controllers;


[ApiController]
[Route("api/frogs")] // super('api/frogs')
public class FrogsController : ControllerBase // FrogsController extends BaseController
{

  // NOTE startup will pass a frogsService through the constructor of our controller (dependency injection)
  public FrogsController(FrogsService frogsService)
  {
    _frogsService = frogsService;
  }

  // NOTE you need a placeholder on your controller so it can hold a service object
  private readonly FrogsService _frogsService;

  [HttpGet("test")] // .get('/test', this.test)
  public string Test()
  {
    return "Frogs Controller is working!";
  }

  // NOTE ActionResult represents an HTTP response with a List of Frog as the response body
  [HttpGet]
  public ActionResult<List<Frog>> GetAllFrogs() // .get('', this.getAllFrogs)
  {
    try
    {
      List<Frog> frogs = _frogsService.GetAllFrogs();
      // 200 ok
      return Ok(frogs);
    }
    catch (Exception error)
    {
      // 400 bad request
      return BadRequest(error.Message); // next(error)
    }
  }

  [HttpGet("{frogId}")] // .get('/:frogId', this.getFrogById)
  public ActionResult<Frog> GetFrogById(int frogId) // request.params.frogId
  {
    try
    {
      Frog frog = _frogsService.GetFrogById(frogId);
      return Ok(frog);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPost]
  public ActionResult<Frog> CreateFrog([FromBody] Frog frogData) // request.body
  {
    try
    {
      Frog frog = _frogsService.CreateFrog(frogData);
      return Ok(frog);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{frogId}")]
  public ActionResult<string> DeleteFrog(int frogId)
  {
    try
    {
      string message = _frogsService.DeleteFrog(frogId);
      return Ok(message);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}