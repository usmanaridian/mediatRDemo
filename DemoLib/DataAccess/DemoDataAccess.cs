using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _persons = new();

        public DemoDataAccess()
        {
            _persons.Add(new PersonModel() { Id = 1, FirstName = "Ali", LastName = "Ahmad" });
            _persons.Add(new PersonModel() { Id = 2, FirstName = "Yaseen", LastName = "Ali" });
        }

        public List<PersonModel> GetAll()
        {
            return _persons;
        }

        public PersonModel AddPerson(string firstName, string lastName)
        {
            PersonModel model = new() { FirstName = firstName, LastName = lastName };

            model.Id = _persons.Max(x => x.Id) + 1;

            _persons.Add(model);

            return model;
        }
    }
}
