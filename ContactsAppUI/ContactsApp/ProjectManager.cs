using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class ProjectManager
    {
        public static void SaveFile(Project _project, string filePath)
        {
            // создаем экземляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            {
                // открываем поток для записи в файл с указанием пути
                using (StreamWriter sw = new StreamWriter(filePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //вызываем сериализацию и передаем объект, который хотим сериализовать
                    serializer.Serialize(writer, _project);
                }

            }
            
        }

        public static Project LoadFile(Project project, string filePath)
        {
        JsonSerializer serializer = new JsonSerializer();
        using (StreamReader sr = new StreamReader(filePath))
        using (JsonReader reader = new JsonTextReader(sr))
            { 
            project = (serializer.Deserialize<Project>(reader));
            return project;
            }
        }
    } 
}
