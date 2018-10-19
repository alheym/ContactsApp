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
        /// Возвращает и задает номер телефона.
        /// </summary>
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

                    _number = value;
            }
        }

        public override string ToString()
        {
            return "+" + _number.ToString("0 000 000 0000");
        }
    }
}
