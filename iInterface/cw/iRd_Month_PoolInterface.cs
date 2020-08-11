using iData.cw;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vModel;
using vModel.chart;

namespace iInterface.cw
{
    public interface iRd_Month_PoolInterface
    {
        Task<LineChart> GetAll(string company);
        Task<List<vKeyValue>> GetCompanyList();

    }
}
