using Microsoft.VisualStudio.TestTools.UnitTesting;
using BloodDonationSystem;

namespace BloodDonationSystem.Tests
{
    [TestClass]
    public class DonorTests
    {
        [TestMethod]
        public void IsEligible_ShouldReturnTrue_ForValidDonor()
        {
            var donor = new Donor { Name = "Alice", Age = 25, WeightKg = 55, BloodGroup = "O+" };
            Assert.IsTrue(donor.IsEligible());
        }

        [TestMethod]
        public void IsEligible_ShouldReturnFalse_ForUnderweight()
        {
            var donor = new Donor { Name = "Bob", Age = 30, WeightKg = 45, BloodGroup = "A+" };
            Assert.IsFalse(donor.IsEligible());
        }

        [TestMethod]
        public void IsEligible_ShouldReturnFalse_ForTooYoung()
        {
            var donor = new Donor { Name = "Charlie", Age = 16, WeightKg = 60, BloodGroup = "B+" };
            Assert.IsFalse(donor.IsEligible());
        }
    }
}
