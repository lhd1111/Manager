using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PersonTax))]
    public class PersonTax:Base
    {
        [Display(Name = "D(4)身份证"), MaxLength(18)]
        public string CardNumber { get; set; }
        [Display(Name = "H(8)本期收入"), Column(TypeName = "decimal(8, 2)")]
        public decimal Sr { get; set; }
        [Display(Name = "I(9)本期费用"), Column(TypeName = "decimal(8, 2)")]
        public decimal Fy { get; set; }
        [Display(Name = "J(10)本期免税收入"), Column(TypeName = "decimal(8, 2)")]
        public decimal Mrsr { get; set; }
        [Display(Name = "K(11)本期基本养老保险费"), Column(TypeName = "decimal(8, 2)")]
        public decimal YangLao { get; set; }
        [Display(Name = "L(12)本期基本医疗保险费"), Column(TypeName = "decimal(8, 2)")]
        public decimal YiLiao { get; set; }
        [Display(Name = "M(13)本期失业保险费"), Column(TypeName = "decimal(8, 2)")]
        public decimal ShiYe { get; set; }
        [Display(Name = "N(14)本期住房公积金"), Column(TypeName = "decimal(8, 2)")]
        public decimal ZhuFang { get; set; }
        [Display(Name = "O(15)本期企业(职业)年金"), Column(TypeName = "decimal(8, 2)")]
        public decimal NianJin { get; set; }
        [Display(Name = "P(16)本期商业健康保险费"), Column(TypeName = "decimal(8, 2)")]
        public decimal Shangye { get; set; }
        [Display(Name = "Q(17)本期税延养老保险费"), Column(TypeName = "decimal(8, 2)")]
        public decimal YangLaoYan { get; set; }
        [Display(Name = "R(18)本期其他扣除(其他)"), Column(TypeName = "decimal(8, 2)")]
        public decimal OtherKou { get; set; }
        [Display(Name = "S(19)累计收入额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sSr { get; set; }
        [Display(Name = "T(20)累计免税收入"), Column(TypeName = "decimal(8, 2)")]
        public decimal sMrsr { get; set; }
        [Display(Name = "U(21)累计减除费用"), Column(TypeName = "decimal(8, 2)")]
        public decimal sLjjc { get; set; }
        [Display(Name = "V(22)累计专项扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sZx { get; set; }
        [Display(Name = "W(23)累计子女教育支出扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sZv { get; set; }
        [Display(Name = "X(24)累计继续教育支出扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sJxjy { get; set; }
        [Display(Name = "Y(25)累计住房贷款利息支出扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sZfdk { get; set; }
        [Display(Name = "Z(26)累计住房租金支出扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sLfzj { get; set; }
        [Display(Name = "AA(27)累计赡养老人支出扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sSy { get; set; }
        [Display(Name = "AB(28)累计其他扣除"), Column(TypeName = "decimal(8, 2)")]
        public decimal sQt { get; set; }
        //20221226开始，新增AC累计个人养老金,29依次累加

        [Display(Name = "AC(29)累计准予扣除的捐赠"), Column(TypeName = "decimal(8, 2)")]
        public decimal sZykc { get; set; }
        [Display(Name = "AD(30)累计应纳税所得额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYnssd { get; set; }
        [Display(Name = "AE(31)税率"), Column(TypeName = "decimal(8, 2)")]
        public decimal ShuiLv { get; set; }
        [Display(Name = "AF(32)速算扣除数"), Column(TypeName = "decimal(8, 2)")]
        public decimal SuSuan { get; set; }
        [Display(Name = "AG(33)累计应纳税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYns { get; set; }
        [Display(Name = "AH(34)累计减免税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sJm { get; set; }
        [Display(Name = "AI(35)累计应扣缴税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYkjs { get; set; }
        [Display(Name = "AJ(36)累计已预缴税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYyjs { get; set; }
        [Display(Name = "AK(37)累计应补(退)税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYbts { get; set; }
        [Display(Name = "AL(38)备注")]
        public string Note { get; set; }
        [MaxLength(3)]
        public string DataBaseId { get; set; }
        public DateTime Period { get; set; }
    }
}
