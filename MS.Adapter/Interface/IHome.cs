using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Models;


namespace MS.AdapterInterface
{
    public interface IHomeAdapter
    {
        Task<List<HomeModel>> GetUserName();
    }
}
