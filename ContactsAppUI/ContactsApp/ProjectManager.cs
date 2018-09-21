using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp
{
    public class ProjectManager
    {
        private static ProjectManager _project;

        public Project Project { get; set; } = new Project();

        public static ProjectManager GetInstance()
        {
            if(_project == null)
            {
                _project = new ProjectManager();
            }
            return _project;
        }

        public void SaveFile()
        {
            // создаем экземляр сериализатора
            //JsonSerializer serializer = new JsonSerializer();

            //{
            //    // открываем поток для записи в файл с указанием пути
            //    using (StreamWriter sw = new StreamWriter(filePath))
            //    using (JsonWriter writer = new JsonTextWriter(sw))
            //    {
            //        //вызываем сериализацию и передаем объект, который хотим сериализовать
            //        serializer.Serialize(writer, _project);
            //    }

            //}
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "project.json", Newtonsoft.Json.JsonConvert.SerializeObject(_project));
        }

        public void LoadFile()
        {
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "project.json"))
            {
                _project = JsonConvert.DeserializeObject<ProjectManager>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "project.json"));
            }
        //JsonSerializer serializer = new JsonSerializer();
        //using (StreamReader sr = new StreamReader(filePath))
        //using (JsonReader reader = new JsonTextReader(sr))
        //    { 
        //    project = (serializer.Deserialize<Project>(reader));
        //    return project;
        //    }
        }
    } 
}
