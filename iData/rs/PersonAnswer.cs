using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(PersonAnswer))]

    public class PersonAnswer:Base
    {
        [Display(Name ="人员考试id")]
        public int PersonTestId { get; set; }
        //[Display(Name = "试卷id")]
        //public int PaperId { get; set; }
        [Display(Name ="题目的id")]
        //考虑到题目的可还原性，漏做等情况，因此保留原题数据
        public int QuestionId { get; set; }
        [Display(Name = "答案")]
        //考虑到简答题的情况，此处为字符串
        //考虑到多选，此处一对多
        public string AnswerId { get; set; }
        [Display(Name = "单题得分")]
        public int Socre { get; set; }
    }
}
