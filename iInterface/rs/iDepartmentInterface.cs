using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vModel;
using vModel.rs;

namespace iInterface.rs
{
    public interface iDepartmentInterface
    {
        Task<IEnumerable<vDepartment>> GetAll();
        Task<vDepartment> GetById(int Id);

        Task<IEnumerable<vDepartment>> GetChildren(int ParentId);
        Task<vDepartment> AddorEdit(vDepartment vDepartment);

        vResult DelById(int Id);
        
    }
}
