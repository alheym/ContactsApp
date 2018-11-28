using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ContactsApp;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestFixture]

    public class ContactTest
        {
            private Contact _contact;

            [SetUp]
            public void InitContact()
            {
                _contact = new Contact();
            }

            [TestCase("Смирнов", "Выполняется, если фамилия удачно присваевается",
                TestName = "Позитивный тест геттера Surname")]
            [Category("SurnameTests")]
            public void TestSurnameGet_CorrectValue(string expected, string message)
            {
                _contact.Surname = expected;
                var actual = _contact.Surname;

                Assert.AreEqual(expected, actual, "Геттер возвращает неправильную фамилию");
            }

            [TestCase("", "Исключение, если фамилия - пустая строка",
                TestName = "Присвоение пустой строки в качестве фамилии",
                Ignore = "Тест не актуален")]
            [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов",
                "Исключение, если фамилия длиннее 50 символов"
                , TestName = "Присвоение неправильной фамилии больше 50 символов")]
            public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
            {
                Assert.ThrowsException<ArgumentException>(
                    () => { _contact.Surname = wrongSurname; }, 
                    message);
            }


        }
    
}
