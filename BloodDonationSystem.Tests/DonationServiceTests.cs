using Microsoft.VisualStudio.TestTools.UnitTesting;
using BloodDonationSystem;

namespace BloodDonationSystem.Tests
{
    [TestClass]
    public class DonationServiceTests
    {
        [TestMethod]
        public void RegisterDonor_ShouldAddDonor_IfEligible()
        {
            var service = new DonationService();
            var donor = new Donor { Name = "Alice", Age = 25, WeightKg = 55, BloodGroup = "A+" };

            bool result = service.RegisterDonor(donor);

            Assert.IsTrue(result);
            Assert.AreEqual(1, service.GetEligibleDonors().Count);
        }

        [TestMethod]
        public void RegisterDonor_ShouldNotAddDonor_IfNotEligible()
        {
            var service = new DonationService();
            var donor = new Donor { Name = "Tom", Age = 17, WeightKg = 48, BloodGroup = "B-" };

            bool result = service.RegisterDonor(donor);

            Assert.IsFalse(result);
            Assert.AreEqual(0, service.GetEligibleDonors().Count);
        }
    }
}
