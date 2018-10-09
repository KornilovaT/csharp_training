using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            OpenMainPage();
            LoginToTheAccount(new AccountData("admin","secret"));
            GoToGroupsPage();
            NewGroupCreation();
            GroupData group = new GroupData("Group name");
            group.Header = "Group header";
            group.Footer = "Group footer";
            FillInGroupForm(group);
            SubmitGroupCreation();
            ReturnToHomepage();
        }
    }
}
