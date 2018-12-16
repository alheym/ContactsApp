using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class addEditContactsForm : Form
    {
        public addEditContactsForm()
        {
            InitializeComponent();
           
        }

        private Contact _contact = new Contact();
        public Contact ContactData => _contact;

        #region Флаги правильности ввода параметров
        /// <summary>
        /// Флаг верности ввода Даты
        /// </summary>
        private bool _checkDataResult;

        #endregion


        /// <summary>
        /// Метод проверки правильности вводимых полей контакта
        /// </summary>
        /// <returns>true, если все поля введены правильно</returns>
        public bool CheckCorrectInput()
        {



            //TryCatch Surname
            try
            {
                _contact.Surname = SurnameTextBox.Text;

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SurnameTextBox.Focus();
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SurnameTextBox.Focus();
                return false;
            }

            //TryCatch Name
            try
            {
                _contact.Name = NameTextBox.Text;

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTextBox.Focus();
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTextBox.Focus();
                return false;
            }


            //TryCatch Birhday
            try
            {
                _contact.Birhday = BirthdayDayTool.Value;

            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                BirthdayDayTool.Focus();
                return false;
            }

            //TryCatch PhoneNumber
            try
            {

            _contact.Number.Number = Convert.ToInt64(PhoneTextBox.Text);

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneTextBox.Focus();
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneTextBox.Focus();
                return false;
            }


            //TryCatch Email
            try
            {
                _contact.Email = EmailTextBox.Text;

            }

            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Focus();
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Focus();
                return false;
            }

            //TryCatch Vk
            try
            {
                _contact.VK = VKTextBox.Text;

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                VKTextBox.Focus();
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Add Contact Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                VKTextBox.Focus();
                return false;
            }


            return true;
        }


        public void ContactView(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            BirthdayDayTool.Value = contact.Birhday;
            PhoneTextBox.Text = Convert.ToString(contact.Number.Number);
            EmailTextBox.Text = contact.Email;
            VKTextBox.Text = contact.VK;
        }
                
        /// <summary>
        /// Кнопка ОК. Выполняется проверка на не пустые поля 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectInput())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = SurnameTextBox.Text;
            if (text.Length <= 50 && text.Length != 0)
            {
                SurnameTextBox.BackColor = Color.White;
            }
            else
            {
                SurnameTextBox.BackColor = Color.LightSalmon;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = NameTextBox.Text;
            if (text.Length <= 50 && text.Length != 0)
            {
                NameTextBox.BackColor = Color.White;
            }
            else
            {
                NameTextBox.BackColor = Color.LightSalmon;
            }
        }

        /// <summary>
        /// Проверка ввода только цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод проверки ввода номера телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void PhoneTextBox_TextChanged(object sender, EventArgs ex)
        {
            string text = PhoneTextBox.Text;
            if (long.TryParse(text, out long number))
            {
                if (number >= 70000000000 && number <= 79999999999 && text.Length != 0)
                {
                    PhoneTextBox.BackColor = Color.White;
                }
                else
                {
                    PhoneTextBox.BackColor = Color.LightSalmon;
                }

            }
            

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = EmailTextBox.Text;
            if (text.Length <= 50 && text.Length != 0)
            {
                EmailTextBox.BackColor = Color.White;
            }
            else
            {
                EmailTextBox.BackColor = Color.LightSalmon;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = VKTextBox.Text;
            if (text.Length <= 15 && text.Length != 0)
            {
                VKTextBox.BackColor = Color.White;
            }
            else
            {
                VKTextBox.BackColor = Color.LightSalmon;
            }
        }

        private void BirthdayDayTool_ValueChanged(object sender, EventArgs ex)
        {
            try
            {
                _contact.Birhday = BirthdayDayTool.Value;
                BirthdayDayTool.BackColor = Color.White;
                _checkDataResult = true;
            }
            catch (ArgumentException)
            {
                
                BirthdayDayTool.BackColor = Color.LightSalmon;
                BirthdayDayTool.Focus();
                _checkDataResult = false;
            }
        }
    }
}
