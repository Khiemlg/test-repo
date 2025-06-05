// BloodDonationSystem/Donor.cs
namespace BloodDonationSystem
{
    public class Donor
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double WeightKg { get; set; }
        public string? BloodGroup { get; set; }

        public bool IsEligible()
        {
            return Age >= 18 && Age <= 60 && WeightKg >= 50;
        }
    }
}
