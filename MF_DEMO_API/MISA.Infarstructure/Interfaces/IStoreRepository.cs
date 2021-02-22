using System;
using System.Collections.Generic;
using System.Text;
using MISA.Common.Models;

namespace MISA.DataLayer.Interfaces
{
    public interface IStoreRepository: IDbContext<Store>
    {
        public IEnumerable<Store> GetFilter(Object filter);
    }
}
