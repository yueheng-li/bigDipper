using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Classes
    {

        public Classes(string classId, string className)
        {
            this.classId = classId;
            this.className = className;
        }
        
        public string classId { set; get; }
        public string className { set; get; }
    }
}
