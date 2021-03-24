using NUnit.Framework;
using Task4;
using static Task4.Access;

namespace Task4.Tests
{
    public class AccessTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAccesDenied()
        {
            var accessRights = AccessRights.AccessDenied | AccessRights.Add;
            var result= accessRights.HasFlag(AccessRights.AccessDenied)
                ? AccessRights.AccessDenied : accessRights;
            Assert.AreEqual(AccessRights.AccessDenied, result);
        }
    }
}