using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaToDo{
    public class Todo
    {
        public Guid Guid { get; set; }
        public int Id {get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public Todo()
        {
           Guid = Guid.NewGuid();
        }
    }
}
