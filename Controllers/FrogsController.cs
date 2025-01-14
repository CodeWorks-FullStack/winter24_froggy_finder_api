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
}