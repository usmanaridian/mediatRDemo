﻿using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
    
}
