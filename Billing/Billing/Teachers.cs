using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Teachers
    {

        public Teachers(string teacherId, string teacherName, string password)
        {
            this.teacherId = teacherId;
            this.teacherName = teacherName;
            this.password = password;
        }

        public string teacherId { set; get; }
        public string teacherName { set; get; }
        public string password { set; get; }
    }
}
