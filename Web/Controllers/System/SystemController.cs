using iData.rs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vModel;
using vModel.rs;

namespace Web.Controllers.system
{
    [Area("System")]
    [Route("System/[controller]/[action]")]
    public class SystemController:ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public SystemController(SignInManager<User> signInManager, UserManager<User> userManager) {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        [HttpPost]
        public async Task<vResult> Login([FromBody]vUser vUser) {
            vResult vr = new vResult();
            var res = await _userManager.FindByNameAsync(vUser.LoginName);
            if (res != null)
            {
                var login = await _signInManager.PasswordSignInAsync(res, vUser.Password, false, false);
                if (login.Succeeded)
                {
                    vr.State = StateType.Ok;
                    vr.Message="成功登录";
                }
                else
                {
                    vr.State = StateType.Error;
                    vr.Message="登录密码错误";
                }
            }
            vr.State = StateType.Error;
            vr.Message="未找到用户名";
            return vr;
        }

        public async Task<vResult> CreateUser([FromBody]vUser vUser)
        {
            vResult rv = new vResult();
            User iu = new User
            {
                UserName = vUser.LoginName,
                NormalizedUserName = vUser.Name,
                DepartmentId = vUser.DepartmentId
            };
            var res = await _userManager.CreateAsync(iu, vUser.Password);
            if (!res.Succeeded)
            {

                rv.State = StateType.Error;
                rv.Message = "创建失败";
            }
            rv.State = StateType.Ok;
            rv.Message = "创建成功";
            return rv;
        }
    }
}
