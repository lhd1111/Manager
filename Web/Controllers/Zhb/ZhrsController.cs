using iInterface.rs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vModel;
using vModel.rs;

namespace Web.Controllers
{
    [Area("Zhb")]
    [Route("Zhb/[controller]/[action]")]
    public class ZhrsController:ControllerBase
    {
        private readonly ihr_hi_personInterface _ihr_Hi_PersonInterface;

        public ZhrsController(ihr_hi_personInterface ihr_hi_personInterface) {
            _ihr_Hi_PersonInterface = ihr_hi_personInterface;
        }
        [HttpPost]
        public async Task<PageList<vPerson>> GetList([FromBody]PageList<vPerson> vPersonPage) {
            return await _ihr_Hi_PersonInterface.GetByPage(vPersonPage);
        }


    }
}
