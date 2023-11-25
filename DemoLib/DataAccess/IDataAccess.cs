using DemoLib.Models;

namespace DemoLib.DataAccess
{
    public interface IDataAccess
    {
        PersonModel AddPerson(string firstName, string lastName);
        List<PersonModel> GetAll();
    }
}