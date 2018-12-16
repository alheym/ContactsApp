using ContactsApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private bool _isProjectChanged = false;

        /// <summary>
        /// Объявление нового экземпляра списка контактов
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Экземпляр списка контактов после поиска
        /// </summary>
        private readonly Project _projectForFind = new Project();

        /// <summary>
        /// Загрузка данных при запуске программы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            ProjectManager.GetInstance().LoadFile();
            FillListView(ProjectManager.GetInstance().Project.Contacts);
            CheckTodayBirthday();
        }

        /// <summary>
        /// Заполнить список контактов. Если в списке уже есть данные (список ранее был заполнен),
        /// то список будет очищен и снова заполнен.
        /// </summary>
        /// <param name="contact">Список контактов</param>
        public void FillListView(List<Contact> contacts)
        {
            if (ContactsList.Items.Count > 0) ContactsList.Items.Clear();
            contacts = _project.SortContact(contacts);
            foreach (Contact contact in contacts)
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
            string contactSurnameAndName = contact.Surname + " " + contact.Name;
            int index = ContactsList.Items.Add(contactSurnameAndName).Index;
            ContactsList.Items[index].Tag = contact; 
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
            var project = (FindTextBox.Text == string.Empty) ? _project : _projectForFind;

            if (ContactsList.SelectedIndices.Count != 0)
            {
                SurnameTextBox.Text = ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].Surname;
                NameTextBox.Text = ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].Name;
                BirthdayDayTool.Value = ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].Birhday;
                PhoneTextBox.Text = Convert.ToString(ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].Number.Number);
                EmailTextBox.Text = ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].Email;
                VKTextBox.Text = ProjectManager.GetInstance().Project.Contacts[ContactsList.SelectedIndices[0]].VK;
                EditContactButton.Enabled = true;
                RemoveContactButton.Enabled = true;
            }
            else
            {
                SurnameTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                BirthdayDayTool.Value = new DateTime(2000, 01, 01);
                PhoneTextBox.Text = string.Empty;
                EmailTextBox.Text = string.Empty;
                VKTextBox.Text = string.Empty;
                EditContactButton.Enabled = false;
                RemoveContactButton.Enabled = false;
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
                ProjectManager.GetInstance().Project.Contacts.Add(addContact.ContactData);
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
            editContact.ContactView(ProjectManager.GetInstance().Project.Contacts[index]);
            if (editContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contacts.RemoveAt(index);
                ContactsList.Items[index].Remove();
                ProjectManager.GetInstance().Project.Contacts.Insert(index, editContact.ContactData);
                _isProjectChanged = true;
            }

        }

        /// <summary>
        /// Метод удаления выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContact_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult = MessageBox.Show("Вы действительно хотите удалить контакт?", "Remove Contact",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dialogResult == DialogResult.Yes)
            {
                int index = ContactsList.SelectedIndices[0];
                ProjectManager.GetInstance().Project.Contacts.RemoveAt(index);
                ProjectManager.GetInstance().SaveFile();
                ContactsList.Items[index].Remove();
                _isProjectChanged = true;
            }
            CheckTodayBirthday();
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
                ProjectManager.GetInstance().Project.Contacts.Add(addContact.ContactData);
                ProjectManager.GetInstance().SaveFile();
                _isProjectChanged = true;
            }
            FillListView(ProjectManager.GetInstance().Project.Contacts);
            CheckTodayBirthday();
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
            editContact.ContactView(ProjectManager.GetInstance().Project.Contacts[index]);
            if (editContact.ShowDialog() == DialogResult.OK)
            {
                ProjectManager.GetInstance().Project.Contacts.RemoveAt(index);
                ContactsList.Items[index].Remove();
                ProjectManager.GetInstance().Project.Contacts.Insert(index, editContact.ContactData);
                _isProjectChanged = true;
                ProjectManager.GetInstance().SaveFile();
            }
            FillListView(ProjectManager.GetInstance().Project.Contacts);
            CheckTodayBirthday();
        }

        /// <summary>
        /// Свойство текстового поля поиска на изменние текста в нем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();

            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);

           _projectForFind.Contacts = _projectForFind.SortContact(ProjectManager.GetInstance().Project.Contacts, FindTextBox.Text);

            FillListView(_projectForFind.Contacts);
        }
        /// <summary>
        /// Метод поиска индекса контакта в соответствии с контактом из поиска
        /// </summary>
        /// <param name="contacts">Список контактов</param>
        /// <param name="findedContacts">Список контактов после поиска</param>
        /// <returns>Индекс контакта в списке</returns>
        private int GetContactIndex(List<Contact> contacts, List<Contact> findedContacts)
        {
            int index = 0;

            foreach (var contact in contacts)
            {
                if (contact == findedContacts[ContactsList.SelectedIndices[0]])
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        ///// <summary>
        ///// Метод вывода контаков, у которых сегодня день рожденья
        ///// </summary>
        private void CheckTodayBirthday()
        {
            BirthdayPanel.Visible = false;
            BirthdayText.Visible = false;
            BirthdayShowLabel.Text = String.Empty;
            List<Contact> birthdayList = ProjectManager.GetInstance().Project.ShowBirthdayList(DateTime.Today);
            if (birthdayList.Count != 0)
            {
                BirthdayPanel.Visible = true;
                BirthdayText.Visible = true;
                foreach (var contact in birthdayList)
                {
                    BirthdayShowLabel.Text += contact.Surname + " " + contact.Name + "; ";
                }
            }
        }

     
    }
}


