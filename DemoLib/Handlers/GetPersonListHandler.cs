﻿using DemoLib.DataAccess;
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
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;

        public GetPersonListHandler(IDataAccess dataAccess)
        {
            _data = dataAccess;
        }
               

        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetAll());
        }
    }
}
