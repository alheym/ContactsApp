using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона, содержащий информацию о том, с какой цифры начинается номер
    /// и какое количество символов содержит.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;
      
             /// <summary>
             /// Свойство номера телефона
             /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                var str = value.ToString();
                if (str[0] != '7')
                {
                    throw new FormatException("Номер телефона должен начинаться с 7, а начинается с " + str[0]);
                }
                else if (value < 70000000000 || value > 79999999999)
                {
                    throw new ArgumentException("Длина номера телефона должна быть ровно 11 символов, а был " + str.Length);
                }
                _number = value;
            }
        }
    }
}
