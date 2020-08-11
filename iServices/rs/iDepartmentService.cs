using iData.Context;
using iInterface.rs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vModel.rs;
using System.Linq;
using iData.rs;
using vModel;
using Microsoft.EntityFrameworkCore;

namespace iServices.zjb
{
    public class iDepartmentService : iDepartmentInterface
    {
        private readonly TestDbContext _testContext;

        public iDepartmentService(TestDbContext testContext)
        {
            _testContext = testContext;
        }

        public Task<vDepartment> AddorEdit(vDepartment vDepartment)
        {
            return Task.Run(() => { 
                Department dept = new Department();
                if (vDepartment.Id !=0) {
                    dept= _testContext.Departments.Include(x => x.Parent).ThenInclude(x=>x.Children).Where(x => x.Id == vDepartment.Id).FirstOrDefault();
                }
                dept.Name = vDepartment.Name;
                dept.ParentId = vDepartment.ParentId;
                _testContext.Departments.Add(dept);
                _testContext.SaveChanges();
                dept = _testContext.Departments.Include(x => x.Parent).ThenInclude(x => x.Children).Where(x => x.Id == dept.Id).FirstOrDefault();
                if (vDepartment.Id == 0)
                {
                    if (dept.ParentId == null)
                    {
                        dept.Scope = dept.Id.ToString() + "$";
                        dept.Level = 1;
                        dept.Parent.IsLeaf = false;
                    }
                    else
                    {
                        dept.Scope = dept.Parent.Scope + dept.Id.ToString() + "$";
                        dept.Level = dept.Parent.Level + 1;
                    }

                    _testContext.SaveChanges();
                }          
                return Dto(dept);
            });

        }

        public vResult DelById(int Id)
        {
            
            vResult vr= new vResult();
            var d = _testContext.Departments.Any(x => x.ParentId == Id);
            if (d) 
            {
                vr.State = StateType.Error;
                vr.Message = "因含有子集，删除失败";
                return vr;
            }
            var del = _testContext.Departments.Where(x => x.Id == Id).FirstOrDefault();
            if (del != null)
            {
                _testContext.Departments.Remove(del);
                vr.State = StateType.Ok;
                vr.Message = "删除成功";
            }
            else {
                vr.State = StateType.Error;
                vr.Message = "因未找到记录，删除失败";
            }
            return vr;
        }

        public Task<IEnumerable<vDepartment>> GetAll()
        {
            return Task.Run(() => {
                return _testContext.Departments.AsEnumerable().Select(x => Dto(x)) ;
            });
        }

        public Task<vDepartment> GetById(int Id)
        {
            return Task.Run(() => {
                return Dto(_testContext.Departments.Find(Id));
            });
        }

        public Task<IEnumerable<vDepartment>> GetChildren(int ParentId)
        {
            return Task.Run(() =>
            {
                return _testContext.Departments.Where(x => x.ParentId == ParentId).AsEnumerable().Select(x => Dto(x));
            });
        }

        private vDepartment Dto(Department dept) {
            return new vDepartment()
            {
                Id = dept.Id,
                Name = dept.Name,
                Scope = dept.Scope,
                ParentId = dept.ParentId,
                Level=dept.Level
            };
        }
    }
}
