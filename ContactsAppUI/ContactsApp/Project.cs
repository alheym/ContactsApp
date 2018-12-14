﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс списка контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Задается список контактов
        /// </summary>
        public List<Contact> Contact = new List<Contact>();

        /// <summary>
        /// Метод сортировки списка контактов в алфавитном порядке
        /// </summary>
        /// <param name="contactsList">Список контактов</param>
        /// <returns>Отсортированный список контактов</returns>
        public List<Contact> SortContact(List<Contact> contactsList)
        {
            //Сортировка списка контактов
            contactsList.Sort(delegate (Contact x, Contact y)
            {
                if (x.Surname == null && y.Surname == null) return 0;
                else if (x.Surname == null) return -1;
                else if (y.Surname == null) return 1;
                else return x.Surname.CompareTo(y.Surname);
            });

            return contactsList;
        }

        /// <summary>
        /// Метод поиска списка контактов по фамилии, имени и номеру телефона
        /// </summary>
        /// <param name="contactsList">Список контактов</param>
        /// <param name="substring">Подсрока по которой осуществляется поиск</param>
        /// <returns>Найденный список контактов</returns>
        public List<Contact> SortContact(List<Contact> contactsList, string substring)
        {
            List<Contact> findedContacts = new List<Contact>();
            foreach (var contact in contactsList)
            {
                if (contact.Surname.StartsWith(substring) ||
                    contact.Name.StartsWith(substring) ||
                    contact.Number.Number.ToString().StartsWith(substring))
                {
                    findedContacts.Add(contact);
                }
            }
            return findedContacts;
        }
    }
}
