using iData.rs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vModel;
using vModel.rs;

namespace iInterface.rs
{
    public interface ihr_hi_personInterface
    {
        Task<IEnumerable<vPerson>> GetAll(string company);
        Task<IEnumerable<vPerson>> GetByName(string name);

        Task<PageList<vPerson>> GetByPage(PageList<vPerson> vPersonPage);
    }
}
