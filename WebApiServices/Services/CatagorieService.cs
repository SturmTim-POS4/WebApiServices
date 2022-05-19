namespace WebApiServices.Controllers;

public class CatagorieService : ICatagorieService
{
    private readonly NORTHWNDContext _db;

    public CatagorieService(NORTHWNDContext db)
    {
        _db = db;
    }

    public IEnumerable<Category> GetAll()
    {
        return _db.Categories.AsEnumerable();
    }

    public Category Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Category GetSingle(int id)
    {
        throw new NotImplementedException();
    }

    public Category Insert(int id)
    {
        throw new NotImplementedException();
    }

    public Category Update(int id)
    {
        throw new NotImplementedException();
    }
}