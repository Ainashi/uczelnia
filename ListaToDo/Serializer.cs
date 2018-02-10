using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ListaToDo
{
    class Serializer
    {
        //metoda serializująca i zapisująca do pliku
        public void Serialize(Object data, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TodoList));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, data);
            }
        }
        //deserializacja i odczyt
        public Object Deserialize(string filename)
        {
            TodoList todoList = new TodoList();
            //jeśli plik nie istnieje to tworzy plik o danej ścieżce
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            FileStream fs = File.OpenRead(filename);
            try
            {
               
                XmlSerializer serializer = new XmlSerializer(typeof(TodoList));
                todoList = (TodoList) serializer.Deserialize(fs);
                fs.Close();
                return todoList;
            } catch (Exception e)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return todoList;
            }
            
        }
    }
}
