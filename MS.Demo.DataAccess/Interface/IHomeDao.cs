using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Demo.EntitiyModel.Module;

namespace MS.Demo.DataAccess.Interface
{
    public interface IHomeDao
    {
        Task<List<HomeEntity>> GetHomeAsync();
    }
}
