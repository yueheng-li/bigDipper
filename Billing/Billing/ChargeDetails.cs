using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class ChargeDetails
    {

        public ChargeDetails()
        {
        }

        // seq
        public int seqence { set; get; }
        // 身份证号码
        public string studentIdCard { set; get; }
        // 姓名
        public string studentName { set; get; }
        // 班级
        public string className { set; get; }
        // 是否住宿
        public string accommodationFlg { set; get; }
        // 校服费
        public double schooldressFee { set; get; }
        // 备品费
        public double sparesFee { set; get; }
        // 住宿费
        public double accommodationFee { set; get; }
        // 教材费
        public double teachingMaterialFee { set; get; }
        // 0：缴费完成，1：退费
        public string chargeStatus { set; get; }
        // 操作者
        public string operatorUser { set; get; }
        public string createUser { set; get; }
        public string createDt { set; get; }

    }

}
