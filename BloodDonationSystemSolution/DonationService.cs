using System.Collections.Generic;

namespace BloodDonationSystem
{
    public class DonationService
    {
        private List<Donor> eligibleDonors = new List<Donor>();

        public bool RegisterDonor(Donor donor)
        {
            if (donor.IsEligible())
            {
                eligibleDonors.Add(donor);
                return true;
            }
            return false;
        }

        public List<Donor> GetEligibleDonors()
        {
            return eligibleDonors;
        }
    }
}
