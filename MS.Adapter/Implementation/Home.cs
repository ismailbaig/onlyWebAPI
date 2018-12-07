using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Models;
using MS.Demo.DataAccess.Implementation;
using MS.Demo.DataAccess.Interface;
using MS.Demo.EntitiyModel.Module;
using AutoMapper;

namespace MS.AdapterInterface.Implementation
{
    public class HomeAdapter : IHomeAdapter
    {
        private IHomeDao homeDAO = new HomeDao();

        public async Task<List<HomeModel>> GetUserName()
        {
           

            List<HomeModel> homeModel =  new List<HomeModel>();
            List<HomeEntity> homeEO = await homeDAO.GetHomeAsync();

            Mapper.Map<List<HomeEntity>, List<HomeModel>>(homeEO, homeModel);

            return homeModel;
        }
    }
}
