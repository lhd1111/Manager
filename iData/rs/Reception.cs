using iData.Marketing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Reception))]
    public class Reception:Base
    {
        public string deptName { get; set; }
        public string personNameB { get; set;}
        public string personMobileB { get; set;}
        public string deptNameD { get; set; }
        public string personName { get; set;}
        public string personMobile { get; set;}
        public string personNumer { get; set;}
        public DateTime startTime { get; set;}
            
        public string personReason { get; set;}
        public string carNo { get; set;}
        //发出的card数
        public string cardf { get; set; }
        //收到的card数
        public string cards { get; set; }
        public char IsAngree { get; set; } = '0';
    }
}
