using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaToDo
{
    public partial class MainForm : Form
    {
        // List<Todo> list = new List<Todo>();
        private SortableBindingList<Todo> list = new SortableBindingList<Todo>();
        private Serializer serializer;
        private TodoList todoList;
        private string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/todoList.xml";

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
                todo.Id = this.todoList.currentId + 1;
                todo.Name = text;
                todo.Done = false;
                this.todoList.add(todo);
                this.list.Add(todo);
                this.todoList.currentId++;
                this.saveList();                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[0].Width = 70;

            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Nazwa";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[1].Width = 380;
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.Name = "Done";
            c.HeaderText = "Ukończone";
            c.DataPropertyName = "Done";
            dataGridView1.Columns.Add(c);
            dataGridView1.RowHeadersVisible = false;

            this.serializer = new Serializer();
            this.todoList = (TodoList)serializer.Deserialize(this.filepath);
            this.todoList.Items.ForEach(item => list.Add(item));
            dataGridView1.DataSource = list;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            if (this.todoList.Items.Count == 0)
            {
                this.setClearButtonsEnabled(false);
            }
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
        }

        private void setClearButtonsEnabled(bool isEnabled)
        {
            ClearSelectedButton.Enabled = isEnabled;
            ClearListButton.Enabled = isEnabled;
            ClearFinishedButton.Enabled = isEnabled;
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                this.setClearButtonsEnabled(false);
            }
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.setClearButtonsEnabled(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            var selected = (Todo) this.todoList.Items[dataGridView1.SelectedCells[0].RowIndex];
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Pokaż dialog.
            if (result == DialogResult.OK) // Wynik testu.
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    this.todoList = (TodoList)serializer.Deserialize(filePath);
                    this.list.Clear();
                    this.todoList.Items.ForEach(item => list.Add(item));
                    this.filepath = filePath;

                }
                catch (IOException)
                {
                    MessageBox.Show("Błąd", "Wystąpił błąd przy importowaniu listy.", MessageBoxButtons.OK);
                }
            }
        }

        private void nowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki XML (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    this.serializer.Serialize(new TodoList(), filePath);
                    this.list.Clear();
                    this.todoList = new ListaToDo.TodoList();
                    this.filepath = filePath;
                }
                catch(IOException)
                {
                    MessageBox.Show("Błąd", "Wystąpił błąd przy tworzeniu nowej listy.", MessageBoxButtons.OK);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wyczyścić listę?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.todoList.Items.Clear();
                this.todoList.currentId = 1;
                this.saveList();
                this.list.Clear();
            }
        }
    }
}
