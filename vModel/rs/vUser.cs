using System;
using System.Collections.Generic;
using System.Text;

namespace vModel.rs
{
    public class vUser
    {
        public string Id { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? DepartmentId { get; set; }
        public vDepartment vDepartment { get; set; }
    }
}
