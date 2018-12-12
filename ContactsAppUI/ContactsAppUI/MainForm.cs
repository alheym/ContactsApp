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
    public partial class MainContacts : Form
    {
        private bool _isProjectChanged = false;


        public MainContacts()
        {
            InitializeComponent();
            
            ProjectManager.GetInstance().LoadFile();
            FillListView(ProjectManager.GetInstance().Project.Contact);         

           
        }


        /// <summary>
        /// Заполнить список контактов. Если в списке уже есть данные (список ранее был заполнен),
        /// то список будет очищен и снова заполнен.
        /// </summary>
        /// <param name="_contact">Список контактов</param>
        public void FillListView(List<Contact> _contact)
        {
            if (ContactsList.Items.Count > 0) ContactsList.Items.Clear();
            foreach (Contact contact in _contact)
            {
                AddNewClient(contact);
            }
        }



        /// <summary>
        /// Добавить нового контакта
        /// </summary>
        /// <param name="contact">Контакт</param>
        public void AddNewClient(Contact contact)
        {
            int index = ContactsList.Items.Add(contact.Surname).Index;
            ContactsList.Items[index].Tag = contact; //свойство Tag теперь ссылается на клиента, пригодится при удалении из списка и редактировании
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Вывод выбранного контакта для просмотра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndices.Count != 0)
            {
                SurnameTextBox.Text = ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].Surname;
                NameTextBox.Text = ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].Name;
                BirthdayDayTool.Value = ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].Birhday;
                PhoneTextBox.Text = Convert.ToString(ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].Number.Number);
                EmailTextBox.Text = ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].Email;
                VKTextBox.Text = ProjectManager.GetInstance().Project.Contact[ContactsList.SelectedIndices[0]].VK;
            }
            else
            {
                SurnameTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                BirthdayDayTool.Value = new DateTime(2000, 01, 01);
                PhoneTextBox.Text = string.Empty;
                EmailTextBox.Text = string.Empty;
                VKTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Метод создания нового контакта. Вводимые поля не должны быть пустыми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContact_Click(object sender, EventArgs e)
        {
            addEditContactsForm addContact = new addEditContactsForm();
            if (addContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contact.Add(addContact.ContactData);
                _isProjectChanged = true;
            }

        }

        /// <summary>
        /// Метод изменения контакта. Контакт должен изменяться поштучно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContact_Click(object sender, EventArgs e)
        {
            int index = ContactsList.SelectedIndices[0];
            addEditContactsForm editContact = new addEditContactsForm();
            editContact.ContactView(ProjectManager.GetInstance().Project.Contact[index]);
            if (editContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contact.RemoveAt(index);
                ContactsList.Items[index].Remove();
                ProjectManager.GetInstance().Project.Contact.Insert(index, editContact.ContactData);
                _isProjectChanged = true;
            }

        }

        /// <summary>
        /// Метод удаления выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {

        }

        
        private void RemoveContact_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult = MessageBox.Show("Вы действительно хотите удалить контакт?", "Remove Contact",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dialogResult == DialogResult.Yes)
            {
                int index = ContactsList.SelectedIndices[0];
                ProjectManager.GetInstance().Project.Contact.RemoveAt(index);
                ProjectManager.GetInstance().SaveFile();
                ContactsList.Items[index].Remove();
                _isProjectChanged = true;
            }
        }

       
        /// <summary>
        /// Открыть окно About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, EventArgs e)
        {
            Form About = new aboutForm();
            About.ShowDialog();
        }

        

        private void Exit_Click_1(object sender, EventArgs e)
        {
         
            if (_isProjectChanged != true | ContactsList.Items.Count == 0)
                this.Close();
        }

        /// <summary>
        /// Метод создания нового контакта. Вводимые поля не должны быть пустыми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContactButton_Click(object sender, EventArgs e)
        {
            addEditContactsForm addContact = new addEditContactsForm();
            if (addContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contact.Add(addContact.ContactData);
                ProjectManager.GetInstance().SaveFile();
                _isProjectChanged = true;
            }
            FillListView(ProjectManager.GetInstance().Project.Contact);
        }

        /// <summary>
        /// Метод изменения контакта. Контакт должен изменяться поштучно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            int index = ContactsList.SelectedIndices[0];
            addEditContactsForm editContact = new addEditContactsForm();
            editContact.ContactView(ProjectManager.GetInstance().Project.Contact[index]);
            if (editContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contact.RemoveAt(index);
                ContactsList.Items[index].Remove();
                ProjectManager.GetInstance().Project.Contact.Insert(index, editContact.ContactData);
                _isProjectChanged = true;
                ProjectManager.GetInstance().SaveFile();
            }
            FillListView(ProjectManager.GetInstance().Project.Contact);
        }
    }
    }


