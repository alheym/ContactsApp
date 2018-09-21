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
    public class Contacts
    {
        private long _phoneNumber;
        public long PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new ArgumentNullException("Field 'PhoneNumber' can't be empty");
                }
                else if (value.ToString().Length > 11)
                {
                    throw new ArgumentException("Длина номера телефона должна быть меньше 11, а была " + value.ToString().Length);
                }
                else if (value.ToString()[0] != '7')
                {
                    throw new FormatException("Номер телефона должен начинаться с 7, а начинаетсся с " + value.ToString()[0]);
                }
                else
                    _phoneNumber = value;
            }
            
        }

        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Filed 'Surname' can't be empty");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина фамилии должна быть менее 50, а была " + value.Length);
                }
                else
                    _surname = value;
            }

        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Field 'Name' can't be empty");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина имени должна быть менее 50, а была " + value.Length);
                }
                else
                    _name = value;
            }
        }

        private DateTime _date;
        public DateTime DateofBirhday
        {
            get => _date;
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Today.ToShortDateString() + ", а была " + value.Date.ToShortDateString());
                }
                else
                    _date = value;
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Filed 'Email' can't be empty");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина Email должна быть менее 50, а была " + value.Length);
                }
                else
                    _email = value;
            }
        }

        private string _vk;
        public string VK
        {
            get => _vk;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Filed 'VK' cant't be empty");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id vk должна быть менее 15, а была " + value.Length);
                }
                else
                    _vk = value;
            }
        }
    }
}
