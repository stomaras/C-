﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repositories
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Shop GetShopByName(string name);
    }
}