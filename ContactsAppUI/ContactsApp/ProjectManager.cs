using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp
{
    public class ProjectManager
    {
        /// <summary>
        /// https://metanit.com/sharp/patterns/2.3.php
        /// </summary>
        private static ProjectManager _project;

        public Project Project { get; set; } = new Project();

        public static ProjectManager GetInstance()
        {
            if (_project == null)
            {
                _project = new ProjectManager();
            }
            return _project;
        }

        public void SaveFile()
        {

            File.WriteAllText(
                AppDomain.CurrentDomain.BaseDirectory + "\\project.json",
                Newtonsoft.Json.JsonConvert.SerializeObject(Project));
        }



        public void LoadFile()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\project.json"))
            {
                Project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "project.json"));
            }

        }


    }
}
