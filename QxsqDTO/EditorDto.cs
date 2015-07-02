using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QxsqDTO
{
    public class EditorDto
    {
        public int EditorId {get;set;}
        public string EditorUserName {get;set;}
        public string EditorPassword {get;set;}
        public DateTime EditorRegTime {get;set;}
        public DateTime EditorLoginTime { get; set; }

    }
}
