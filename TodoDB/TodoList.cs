using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TodoDB
{
    public class TodoList
    {
        public List<Todo> Items { get; set; }

        public TodoList()
        {
            this.Items = new List<Todo>();
        }

        public void add(Todo todo)
        {
            this.Items.Add(todo);
        }

        public void remove(Todo todo)
        {
            int index = this.Items.FindIndex((item) => item.Id == todo.Id);
            if (index > -1)
            {
                this.Items.RemoveAt(index);
            }
        }

        public void removeAll()
        {
            this.Items.Clear();
        }

    }
}
