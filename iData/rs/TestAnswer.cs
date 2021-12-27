﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(TestAnswer))]
    public class TestAnswer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTrue { get; set; }
        public int TestModelId { get; set; }
    }
}
