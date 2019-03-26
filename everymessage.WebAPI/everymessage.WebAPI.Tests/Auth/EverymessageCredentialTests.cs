using everymessage.WebAPI.Auth;
using NUnit.Framework;

namespace everymessage.WebAPI.Core.Tests.Auth
{
    [TestFixture]
    public class EverymessageCredentialTests
    {
        [Test]
        public void Create_EverymessageCredential_Instance_Should_Never_Bee_Null()
        {
            everymessageCredential credential = everymessageCredential.Create("test", "test");
            Assert.That(credential, Is.Not.Null);
        }
    }
}
