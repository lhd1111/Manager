using iInterface.cw;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vModel;
using vModel.chart;

namespace Web.Controllers
{
    [Area("Zjb")]
    [Route("Zjb/[controller]/[action]")]
    public class ChartController:ControllerBase
    {
        private readonly iRd_PoolInterface _ird_PoolInterface;

        public ChartController(iRd_PoolInterface ird_PoolInterface) {
            _ird_PoolInterface = ird_PoolInterface;
        }
        [HttpPost]
        public Task<LineChart> rdLineChartAll([FromBody] vKeyValue vKeyValue) {
            return Task.Run(() => _ird_PoolInterface.GetAll(vKeyValue.Key));
        }
        public Task<List<vKeyValue>> GetCompanys()
        {
            return Task.Run(()=>_ird_PoolInterface.GetCompanyList());
        }
    }
}