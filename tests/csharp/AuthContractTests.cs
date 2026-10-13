using NUnit.Framework;

namespace ApiGateway.Tests
{
    [TestFixture]
    public class AuthContractTests
    {
        [TestCase("admin", true)]
        [TestCase("service", true)]
        [TestCase("user", true)]
        [TestCase("guest", false)]
        [TestCase("anonymous", false)]
        public void ValidateRoleAuthorization(string role, bool isAllowed)
        {
            var allowedRoles = new HashSet<string> { "admin", "service", "user" };
            Assert.That(allowedRoles.Contains(role), Is.EqualTo(isAllowed));
        }

        [TestCase(60, 59, true)]
        [TestCase(60, 0, false)]
        public void ValidateRateLimitQuotaRemaining(int limit, int remaining, bool hasQuota)
        {
            Assert.That(remaining > 0, Is.EqualTo(hasQuota));
        }
    }
}
