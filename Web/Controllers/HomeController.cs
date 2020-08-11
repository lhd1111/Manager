using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using iInterface;
using iData.cw;
using iInterface.rs;
using iData.rs;
using vModel.rs;

namespace Web.Controllers
{
    
    public class HomeController:ControllerBase
    {
        private readonly ihr_hi_personInterface _ihr_Hi_PersonInterface;

        //private readonly iInventoryClassInterface _iInventoryClassInterface;

        //public HomeController(iInventoryClassInterface iInventoryClassInterface) {
        //    _iInventoryClassInterface = iInventoryClassInterface;
        //}
        //public IEnumerable<InventoryClass> Index() {
        //    var vt= _iInventoryClassInterface.GetAll();
        //    return vt;
        //}
        public HomeController(ihr_hi_personInterface ihr_hi_personInterface) {
            _ihr_Hi_PersonInterface = ihr_hi_personInterface;
        }
        public IActionResult Index() {
            return Ok("启动成功");
        }
        public async Task<IEnumerable<vPerson>> Test()
        {
            var vt = await _ihr_Hi_PersonInterface.GetAll("重庆");
            return vt;
        }

        public async Task<IEnumerable<vPerson>> GetByName() {
            return await _ihr_Hi_PersonInterface.GetByName("李四");
        }
    }
}
