using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_app
{
    public class Card
    {
        public string Header { get; set; }
        public string Desc { get; set; }
        public Member AppointedTo { get; set; }
        public int Size { get; set; }
        public string Line { get; set; }
    }
}
