namespace froggy_finder_api.Controllers;

[ApiController]
[Route("api/frogs")] // super('api/frogs')
public class FrogsController : ControllerBase // FrogsController extends BaseController
{
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
      List<Frog> frogs = [];
      return Ok(frogs);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message); // next(error)
    }
  }
}