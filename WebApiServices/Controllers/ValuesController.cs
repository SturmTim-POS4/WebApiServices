namespace WebApiServices.Controllers;

[Route("[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
  private readonly NORTHWNDContext _db;
  public ValuesController(NORTHWNDContext db)
  {
    _db = db;
  }
  
  [HttpGet("Products")]
  public object GetProducts()
  {
    Console.WriteLine($"{DateTime.Now:HH:mm:ss} GetProducts");
    try
    {
  	  int nr = _db.Products.Count();
  	  return new { IsOk = true, Nr = nr };
    }
    catch (Exception exc)
    {
  	  return new { IsOk = false, Nr = -1, Error = exc.Message };
    }
  }

}
