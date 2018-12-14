using System;
using System.IO;
using System.Reflection;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.Tests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private string _path;
        private Project _contact = new Project();
        private readonly Contact _firstContact = new Contact();
        private readonly Contact _secondContact = new Contact();

        [SetUp]
        public void InitContact()
        {

            _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Первый контакт на проверку
            _firstContact.Name = "Name";
            _firstContact.Surname = "Surname";
            _firstContact.Birhday = new DateTime(1997, 04, 11);
            _firstContact.Number.Number = 79562795674;
            _firstContact.Email = "Name@gmail.com";
            _firstContact.VK = "id@name";

            //Второй контакт на проверку
            _secondContact.Name = "Myau";
            _secondContact.Surname = "Meow";
            _secondContact.Birhday = new DateTime(1988, 03, 01);
            _secondContact.Number.Number = 79458367854;
            _secondContact.Email = "Myau@mail.ru";
            _secondContact.VK = "id@meow";

        }
           
        ///// <summary>
        ///// Позитивный тест десериализации
        ///// </summary>
        //[Test(Description = "Тест десериализации")]
        //public void TestDeserialization()
        //{
        //    ProjectManager.GetInstance().LoadFile();

        //    Assert.AreEqual(2, _contact.Contact.Count, "Кол-во контактов не совпадают");
        //    Assert.AreEqual(_contact.Contact[0].Name, _firstContact.Name, "Метод десеариализует не правильную информацию(имя первого контакта)");
        //    Assert.AreEqual(_contact.Contact[1].Surname, _secondContact.Surname, "Метод десериалузиет не правильную информацию(фамилия второго контакта)");
        //    Assert.AreEqual(_contact.Contact[0].Number.Number, _firstContact.Number.Number, "Метод десериалузиет не правильную информацию(номер телефона первого контакта)");
        //    Assert.AreEqual(_contact.Contact[1].Email, _secondContact.Email, "Метод десериалузиет не правильную информацию(почтовый ящик второго контакта)");
        //    Assert.AreEqual(_contact.Contact[1].Birhday, _secondContact.Birhday, "Date incorrect!");
        //}
   
        /// <summary>
        /// Позитивный тест сериализации
        /// </summary>
        [Test(Description = "Тест сериализации")]
        public void TestSerialization()
        {
            ProjectManager.GetInstance().SaveFile();
            var fileAsString = File.ReadAllText(_path + @"\TestProjectFiles\SaveContactsTest.txt");
            var expected = File.ReadAllText(_path + @"\TestProjectFiles\TestContacts.txt");
        }
        
    }
}
