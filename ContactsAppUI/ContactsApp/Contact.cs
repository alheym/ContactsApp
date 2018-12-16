using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта, хранящий информацию о номере телефона, имени, фамилии,
    /// email и id vk пользователя.
    /// </summary>
    public class Contact : ICloneable

    {
        public PhoneNumber Number { get; set; } = new PhoneNumber();

        /// <summary>
        /// Объект свойств фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Объект свойств имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Объект свойств даты рождения
        /// </summary>
        private DateTime _birhday;


        /// <summary>
        /// Объект свойств почтовый ящик
        /// </summary>
        private string _email;

        /// <summary>
        /// Объект свойств id вконтакте
        /// </summary>
        private string _vk;

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле 'Surname' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина фамилии должна быть менее 50, а была " + value.Length);
                }
                else
                    //_surname = value;
                _surname = Char.ToUpper(value[0]) + value.Substring(1);
            }

        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле 'Name' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина имени должна быть менее 50, а была " + value.Length);
                }
                else
                    //_name = value;
                    _name = Char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime Birhday
        {
            get => _birhday;
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Today.ToShortDateString() + 
                                                    ", а была " + value.Date.ToShortDateString());
                }
                else
                    _birhday = value;
            }   
        }

        /// <summary>
        /// Возвращает и задает email контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле 'Email' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина Email должна быть менее 50, а была " + value.Length);
                }
                else
                    _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает id вконтакте.
        /// </summary>
        public string VK
        {
            get => _vk;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле 'VK' не может быть пустым");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id vk должна быть менее 15, а была " + value.Length);
                }
                else
                    _vk = value;
            }
        }

        /// <summary>
        /// Метод клонирования контакта
        /// </summary>
        /// <returns>Склонированный контакт</returns>
        public object Clone()
        {
            Contact newContact = new Contact();
            newContact.Name = Name;
            newContact.Surname = Surname;
            newContact.Number.Number = Number.Number;
            newContact.Birhday = Birhday;
            newContact.Email = Email;
            newContact.VK = VK;
            return newContact;
        }
    }
}
