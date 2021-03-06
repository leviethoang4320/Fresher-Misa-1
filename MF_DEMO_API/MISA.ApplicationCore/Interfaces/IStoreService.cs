﻿using System;
using System.Collections.Generic;
using System.Text;
using MISA.Common.Models;

namespace MISA.Service.Interfaces
{
    public interface IStoreService: IBaseService<Store>
    {
        public IEnumerable<Store> GetFilter(object filter);
    }
}
