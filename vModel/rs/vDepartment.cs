using System;
using System.Collections.Generic;
using System.Text;

namespace vModel.rs
{
    public class vDepartment
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public vDepartment Parent { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public int Level { get; set; }
        public int iOrder { get; set; }
        public int IsLeaf { get; set; }

        public ICollection<vDepartment> Children { get; set; }
    }
}
