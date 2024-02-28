using iData.System;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Person))]
    public class Person:Base
    {
        [Display(Name ="姓名"), MaxLength(20)]
        public string Name { get; set; }
        [Display(Name = "英文名"), MaxLength(20)]
        public string EName { get; set; }
        [Display(Name = "企业内部邮箱"), MaxLength(50)]
        public string CEmail { get; set; }
        [Display(Name ="所在地")]
        public Department Location { get; set; }
        [Display(Name = "所在地"),MaxLength(50)]
        public string LocationStr { get; set; }
        public Department Department { get; set; }
        public string DepartmentStr { get; set; }
        public Post Post { get; set; }
        [Display(Name ="工作岗位"), MaxLength(20)]
        public string PostStr { get; set; }
        [Display(Name = "身份证号")]
        public string CardNumber { get; set; }
        [Display(Name = "身份证正面坐标")]
        public string CardNumberXY { get; set; }
        [Display(Name = "身份证背面坐标")]
        public string CardNumberBackXY { get; set; }
        [Display(Name = "身份证有效期开始")]
        public DateTime? CardNumberValidfDate { get; set; }
        [Display(Name = "身份证有效期结束")]
        public DateTime? CardNumberValidlDate { get; set; }
        [Display(Name="出生日期")]
        public DateTime Birthday { get; set; }
        [Display(Name ="性别"),MaxLength(1)]
        public string Sex { get; set; }
        [Display(Name ="婚姻状况"),MaxLength(2)]
        public string MaritalState { get; set; }
        [Display(Name ="民族")]
        public string Nationality { get; set; }
        [Display(Name ="户口所在地"), MaxLength(50)]
        public string RegisterLocation { get; set; }
        [Display(Name ="现居住地"), MaxLength(50)]
        public string LiveLocation { get; set; }
        [Display(Name ="邮箱"), MaxLength(50)]
        public string Email { get; set; }
        [Display(Name = "电子账号"), MaxLength(50)]
        public string WeChatQQ { get; set; }
        [Display(Name = "通勤方式"), MaxLength(50)]
        public string CommutingMethod { get; set; }
        [Display(Name = "通勤时间"), MaxLength(50)]
        public string CommutingDuration { get; set; }
        [Display(Name ="联系电话"), MaxLength(20)]
        public string Tel { get; set; }
        [Display(Name ="紧急联系人"),MaxLength(20)]
        public string Contact { get; set; }
        [Display(Name ="与本人关系"), MaxLength(20)]
        public string Relation { get; set; }
        [Display(Name = "是否有亲属"), MaxLength(20)]
        public bool isQs { get; set; }
        [Display(Name = "公司亲属"), MaxLength(20)]
        public string Relatives { get; set; }
        [Display(Name = "亲属与本人关系"), MaxLength(20)]
        public string cRelation { get; set; }
        [Display(Name = "是否返岗"), MaxLength(20)]
        public bool isFg { get; set; }

        [Display(Name = "返岗原因"), MaxLength(20)]
        public string sReturn { get; set; }

        [Display(Name ="紧急联系人电话"), MaxLength(20)]
        public string ContactTel { get; set; }
        [Display(Name ="学历")]
        public string Education { get; set; }
        [Display(Name ="专业"), MaxLength(20)]
        public string Profession { get; set; }
        [Display(Name ="毕业院校"), MaxLength(50)]
        public string School { get; set; }
        [Display(Name ="外语"), MaxLength(20)]
        public string Language { get; set; }
        [Display(Name ="熟练程度")]
        public string Proficiency { get; set; }
        [Display(Name ="特长"), MaxLength(50)]
        public string Speciality { get; set; }
        [Display(Name = "职称/职业资格"), MaxLength(50)]
        public string JobTitle { get; set; }
        [Display(Name ="健康状况"),MaxLength(5)]
        public string HealthState { get; set; }
        [Display(Name = "以往病史")]
        public string MedicalHistory { get; set; }
        //[Display(Name ="上岗时间")]//由入职日期代替
        //public DateTime? PostDate { get; set; }
        [Display(Name ="试用期限")]
        public int TestMonth { get; set; }
        [Display(Name = "试用期薪资"),MaxLength(10)]
        public string TestSalary { get; set; }
        //[Display(Name = "转正薪资")]
        //public int Salary { get; set; }
        [Display(Name="入职日期")]
        public DateTime rzrq { get; set; }
        [Display(Name ="备注")]
        public string Note { get; set; }
        [Display(Name = "考勤person_no")]
        public int KqId { get; set; }
        [Display(Name = "OA入职id")]
        public int OaRzId { get; set; }
        [Display(Name = "U8编号"),MaxLength(20)]
        public string U8Id { get; set; }
        [Display(Name = "期望薪资")]
        public string HopeSalary { get; set; }
        [Display(Name = "工号"),MaxLength(10)]
        public string gh { get; set; }
        [Display(Name = "招聘渠道"),MaxLength(50)]
        public string zpqd { get; set; }
        [Display(Name = "人员类型"),MaxLength(10)]
        //(正式工、合同工、实习生）
        public string lb { get; set; }
        [Display(Name = "岗位星级"), MaxLength(10)]
        //(F岗、E岗、D岗、C岗、B岗、五星、四星、三星、二星、一星)
        //根据职位等级推算
        public string gwxj { get; set; }
        [Display(Name = "职位等级"), MaxLength(10)]
        //(技术P2、技术P3、技术P4、技术P5、KP6、P7、P8、P9、DP6、M3、M4、M5、M6、M7、M8、M9、一星、二星、三星、四星、五星、劳务工、行政P2、行政P3、行政P4、行政P5)
        public string zwdj { get; set; }
         [Display(Name = "用工形式"), MaxLength(10)]
        //（全日制、劳务派遣、非全日制、实习)
        //由用工形式推算人员类别
        public string ygxs { get; set; }
       [Display(Name = "人员类别"), MaxLength(10)]
        //（正式工、试用工、实习生、劳务工)
        public string rylb { get; set; }
        [Display(Name = "薪资等级"), MaxLength(10)]
        //(1、2、3、4、5、6、7、8、9、无)
        public string xzdj { get; set; }
        [Display(Name = "级别"), MaxLength(10)]
        //(初级、中级、高级)
        public string jb { get; set; }
        [Display(Name = "薪资类别"), MaxLength(20)]
        //(初级、中级、高级)
        public string xzlb { get; set; }
        [Display(Name = "工作地点")]
        public string gzdd { get; set; }
        [Display(Name="大类工资汇总")]
        public string dlgzhz { get; set; }
        [Display(Name = "转正日期")]
        public DateTime? zzrq { get; set; }
        [Display(Name = "转正薪资"),MaxLength(10)]
        public string zzhxzn { get; set; }
        [Display(Name = "当前薪资"),MaxLength(10)]
        public string CurMoney { get; set; }
        [Display(Name = "合同开始")]
        public DateTime htqs { get; set; }
        [Display(Name = "合同结束")]
        public DateTime htjs { get; set; }
        [Display(Name ="面试通过"), MaxLength(3)]
        public string RsPass { get; set; }//0：未处理；1：通过；2：未通过
        [MaxLength(3)]
        public string JlPass { get; set; }//0：未处理；1：通过；2：未通过
        [Display(Name ="是否暂存")]//已弃用
        public bool IsTemp { get; set; } = false;
        [Display(Name = "是否试用")]
        public bool IsTest { get; set; } = true;
        [Display(Name = "离职日期")]
        public DateTime? dLeaveDate { get; set; } 
        [Display(Name ="离职原因"),MaxLength(10)]
        public string cLeaveReson { get; set; }
        [Display(Name = "车牌号码"), MaxLength(10)]
        public string CarNumber { get; set; }
        [Display(Name = "挪车电话"), MaxLength(11)]
        public string MoveCarTel { get; set; }

        [Display(Name = "银行名称"), MaxLength(10)]
        public string BankName { get; set; }
        [Display(Name = "银行卡号"), MaxLength(19)]
        public string BankCardNumber { get; set; }
        [Display(Name = "头像")]
        public string Photo { get; set; }
        [Display(Name = "卡正面")]
        public string CardFront { get; set; }
        [Display(Name = "卡背面")]
        public string CardBack { get; set; }
        public virtual ICollection<EducationExp> EducationExps { get; set; } = new List<EducationExp>();
        public virtual ICollection<FamilyExp> FamilyExps { get; set; } = new List<FamilyExp>();
        public virtual ICollection<TrainExp> TrainExps { get; set; } = new List<TrainExp>();
        public virtual ICollection<WorkExp> WorkExps { get; set; } = new List<WorkExp>();
        public virtual ICollection<SalaryExp> Salaries { get; set; } = new List<SalaryExp>();
    }
}
