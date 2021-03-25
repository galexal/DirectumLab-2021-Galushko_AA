using NUnit.Framework;
using static Task4.Access;

namespace Task4.Tests
{
    public class AccessTests
    {
        [TestCase("Add, Edit", AccessRights.Edit | AccessRights.Add)]
        [TestCase("AccessDenied", AccessRights.AccessDenied | AccessRights.Add)]
        public void GetAcces(string expected, AccessRights rights)
        {
            var actual = GetAccessRights(rights);
            Assert.AreEqual(expected, actual);
        }
    }
}