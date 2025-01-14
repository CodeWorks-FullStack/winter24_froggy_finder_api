namespace froggy_finder_api.Controllers;

[ApiController]
[Route("api/frogs")] // super('api/frogs')
public class FrogsController : ControllerBase // FrogsController extends BaseController
{
  [HttpGet] // .get('', this.test)
  public string Test()
  {
    return "Frogs Controller is working!";
  }
}