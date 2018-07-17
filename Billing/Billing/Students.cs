using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Students
    {


        public Students(string studentsId, string studentName, string classId, string className, string accommodationFlg)
        {
            this.studentsId = studentsId;
            this.studentName = studentName;
            this.classId = classId;
            this.className = className;
            this.accommodationFlg = accommodationFlg;
        }

        public string studentsId { set; get; }
        public string studentName { set; get; }
        public string classId { set; get; }
        public string className { set; get; }
        public string accommodationFlg { set; get; }
    }
}
