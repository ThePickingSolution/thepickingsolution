﻿using Business.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Picking.Interface.Operators
{
    public interface IOperatorRepository
    {
        Operator Get(string id);
    }
}
