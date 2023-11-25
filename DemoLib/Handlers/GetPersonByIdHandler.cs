using DemoLib.DataAccess;
using DemoLib.Models;
using DemoLib.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data;
        private readonly IMediator _mediator;

        public GetPersonByIdHandler(IDataAccess data, IMediator mediator)
        {
            _data = data;
            _mediator = mediator;
        }

        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            //return Task.FromResult(_data.GetAll().FirstOrDefault(x => x.Id == request.Id));

            var result = await _mediator.Send(new GetPersonListQuery());

            var output = result.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}
