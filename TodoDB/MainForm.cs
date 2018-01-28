using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoDB
{
    public partial class MainForm : Form
    {
        // List<Todo> list = new List<Todo>();
        BindingList<Todo> list = new BindingList<Todo>();
        private Serializer serializer;
        private TodoList todoList;
        private string filepath = "todoList.xml";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTask();
        }
        //button dodaj
        private void AddTask()
        {
            string text = textBox1.Text.ToString();
            textBox1.Text = "";
            if (!string.IsNullOrEmpty(text))
            {
                Todo todo = new Todo();
                todo.Name = text;
                todo.Done = false;
                this.todoList.add(todo);
                this.list.Add(todo);
                this.saveList();                
                listBox1.DataSource = list;
                listBox1.DisplayMember = "Name";
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.serializer = new Serializer();
            this.todoList = (TodoList)serializer.Deserialize(this.filepath);
            todoList.Items.ForEach(item => list.Add(item));

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[0].HeaderText = "Nazwa";
            dataGridView1.Columns[0].DataPropertyName = "Name";
            dataGridView1.Columns[0].Width = 450;

            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.Name = "Done";
            c.HeaderText = "Ukończone";
            c.DataPropertyName = "Done";
            dataGridView1.Columns.Add(c);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = list;

            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selected = (Todo) listBox1.SelectedItem;
            var index = this.todoList.Items.FindIndex(item => item.Id == selected.Id);
            this.todoList.Items.RemoveAt(index);
            this.saveList();
            list.Remove(selected);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddTask();
            }
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1.CurrentRow;
            var todo = this.todoList.Items[selected.Index];
            var b = selected.Cells["Done"].OwningColumn.DataPropertyName;
            var c = dataGridView1.CurrentCell.OwningColumn.DataPropertyName;
            todo.Done = c == "Done";
            this.saveList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.todoList.Items.RemoveAll(item => item.Done);
            list.Clear();
            foreach(Todo item in this.todoList.Items)
            {
                list.Add(item);
            }
            this.saveList();
        }

        private void saveList()
        {
            this.serializer.Serialize(this.todoList, this.filepath);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
