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
    public class ZjbChartRdMonthController:ControllerBase
    {
        private readonly iRd_Month_PoolInterface _iRd_Month_PoolInterface;

        public ZjbChartRdMonthController(iRd_Month_PoolInterface iRd_Month_PoolInterface) {
            _iRd_Month_PoolInterface = iRd_Month_PoolInterface;
        }

        [HttpPost]
        public Task<LineChart> rdLineChartAll([FromBody] vKeyValue vKeyValue)
        {
            return Task.Run(() => _iRd_Month_PoolInterface.GetAll(vKeyValue.Key));
        }
    }
}
