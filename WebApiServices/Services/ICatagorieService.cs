namespace WebApiServices.Controllers;

public interface ICatagorieService
{
    IEnumerable<Category> GetAll();
    Category Delete(int id);
    Category GetSingle(int id);
    Category Insert(int id);
    Category Update(int id);
}