using DemoLib.Commands;
using DemoLib.DataAccess;
using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Handlers
{
    public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public AddPersonCommandHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddPerson(request.FirstName, request.LastName));
        }
    }
}

