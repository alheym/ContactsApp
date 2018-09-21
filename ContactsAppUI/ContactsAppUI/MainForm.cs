using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(400, 250);
            ProjectManager.GetInstance().LoadFile(); // Вызов метода
            ProjectManager.GetInstance().Project.Contacts.Add(
                new Contacts()  // Создание экземпляра класса из модели
            {
                Email = "test@test.ru",
                VK = "vk.com",
                Name = "test",
                PhoneNumber = 79610963321,
                Surname = "Test"
            });
            ViewContacts(ProjectManager.GetInstance().Project.Contacts);
            ProjectManager.GetInstance().SaveFile();
        }

        private void ViewContacts(List<Contacts> list)
        {
            int i = 1;
            foreach(var contact in list)
            {
                contactsLabel.Text += string.Format("{0})\t{1} {2}\t{3}\t{4}\t{5}",
                    i, contact.Name, contact.Surname, contact.Email, contact.PhoneNumber.ToString("0 000 000 0000"), contact.VK);
                contactsLabel.Text += Environment.NewLine;
            }
        }
    }
    
}   

