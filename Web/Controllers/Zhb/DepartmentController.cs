using iInterface.rs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vModel.rs;

namespace Web.Controllers.zhb
{
    [Area("Zhb")]
    [Route("Zhb/[controller]/[action]")]
    public class DepartmentController:ControllerBase
    {
        private readonly iDepartmentInterface _iDepartment;

        public DepartmentController(iDepartmentInterface iDepartment) {
            _iDepartment = iDepartment;
        }

        public async Task<IEnumerable<vDepartment>> GetAll() {
            return await _iDepartment.GetAll();
        }

        [HttpPost]
        public Task<vDepartment> AddOrEdit([FromBody]vDepartment vDepartment) {
            return Task.Run(() => {
                return _iDepartment.AddorEdit(vDepartment);
            });
        }
    }
}
