﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repositories
{
    public interface ITrainerRepository : IGenericRepository<Trainer>
    {

        IEnumerable<Trainer> GetTrainersByAscending();

        
    }
}