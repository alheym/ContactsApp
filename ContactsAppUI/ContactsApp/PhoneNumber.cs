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
        public long Number
        {
            get => _number;
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new ArgumentNullException("Field 'Number' can't be empty");
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
                    _number = value;
            }
        }
    }
}
