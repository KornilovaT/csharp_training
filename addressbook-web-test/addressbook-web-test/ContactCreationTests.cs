using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        
        [Test]
        public void ContactCreationTest()
        {
            OpenMainPage();
            LoginToTheAccount(new AccountData("admin", "secret"));
            AddNewContact();
            ContactForm contact = new ContactForm("Tatiana");
            contact.Midname = "Aleksandrovna";
            contact.Lname = "Kornilova";
            contact.Photo = "D:\\xampp\\htdocs\\addressbook\\201809291637213031.jpg";
            contact.Bday = "29";
            contact.Bmonth = "March";
            contact.Byear = "1983";
            contact.Groupname = "Group name";            
            FillInContactForm(contact);
            SubmitContactCreation();
            ReturnToHomepage();
        }

    }
}
