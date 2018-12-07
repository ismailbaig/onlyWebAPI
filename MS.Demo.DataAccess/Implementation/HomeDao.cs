using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Demo.DataAccess.Interface;
using MS.Demo.EntitiyModel.Module;

namespace MS.Demo.DataAccess.Implementation
{
    public class HomeDao : IHomeDao
    {
        public async Task<List<HomeEntity>> GetHomeAsync()
        {
            List<HomeEntity> lsthomeEO = new List<HomeEntity>();
            HomeEntity homeEO = new HomeEntity()
            {
                Name = "Hi from EO"
            };

            return lsthomeEO;
        }
    }
}
