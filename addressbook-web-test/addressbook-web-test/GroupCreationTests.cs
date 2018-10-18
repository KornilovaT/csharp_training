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
                        
            GroupData group = new GroupData("Group name");
            group.Header = "Group header";
            group.Footer = "Group footer";

            app.Navigator.GoToGroupsPage();
            app.Groups
                .NewGroupCreation()
                .FillInGroupForm(group)
                .SubmitGroupCreation();
            app.Navigator.ReturnToHomepage();
        }
        [Test]
        public void EmptyGroupCreationTest()
        {                       
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Navigator.GoToGroupsPage();
            app.Groups
                .NewGroupCreation()
                .FillInGroupForm(group)
                .SubmitGroupCreation();
            app.Navigator.ReturnToHomepage();
        }
    }
}
