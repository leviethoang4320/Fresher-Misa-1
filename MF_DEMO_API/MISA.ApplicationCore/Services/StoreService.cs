using System;
using System.Collections.Generic;
using System.Text;
using MISA.Common.Models;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;

namespace MISA.Service.Services
{
    public class StoreService: BaseService<Store>,IStoreService
    {
            public StoreService(IStoreRepository dbContext) : base(dbContext)
            {

            }
      
    }
}
