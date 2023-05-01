using BloodBank.Classes;
using DBAccess;
using Donor.Data;
using Donor.Models;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Donor.Tests.Data
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CheckResults_WhenAllQuestionsAnsweredNo_ReturnsE()
        {
            // Arrange
            var obj = new DonorQuestionnaire
            {
                Q1Prob = 0,
                Q1Doctor = 0,
                Q1Health = 1,
                Q2medCond = 0,
                Q3Medication = 0,
                Q4Surgery = 0,
                Q5Heavywork = 0,
                Q6Pregnant = 0,
                Q7YellowFever = 0,
                Q7TbTyphoid = 0,
                Q7Treated = 0,
                Q8Immunization = 0,
                Q8TattooAcupuncture = 0,
                Q8Abroad = 0,
                Q8Prison = 0,
                Q8Blood = 0,
                Q8Malaria = 0,
                Q9Dengue = 0,
                Q9Fever = 0,
                Q9Teeth = 0,
                Q10Categories = 0,
                Q11PartnerCategory = 0,
                Q12Symptoms = 0
            };

            var checkDonationVerification = new CheckDonationVerification();

            // Act
            var result = checkDonationVerification.CheckResults(obj);

            // Assert
            Assert.AreEqual("E", result);
        }
        [Test]
        public void CheckResults_WhenAtLeastOneQuestionAnsweredYes_ReturnsNE()
        {
            // Arrange
            var obj = new DonorQuestionnaire
            {
                Q1Prob = 0,
                Q1Doctor = 0,
                Q1Health = 0, // answer is yes
                Q2medCond = 0,
                Q3Medication = 0,
                Q4Surgery = 0,
                Q5Heavywork = 0,
                Q6Pregnant = 0,
                Q7YellowFever = 0,
                Q7TbTyphoid = 0,
                Q7Treated = 0,
                Q8Immunization = 0,
                Q8TattooAcupuncture = 0,
                Q8Abroad = 0,
                Q8Prison = 0,
                Q8Blood = 0,
                Q8Malaria = 0,
                Q9Dengue = 0,
                Q9Fever = 0,
                Q9Teeth = 0,
                Q10Categories = 0,
                Q11PartnerCategory = 0,
                Q12Symptoms = 0
            };

            var checkDonationVerification = new CheckDonationVerification();

            // Act
            var result = checkDonationVerification.CheckResults(obj);

            // Assert
            Assert.AreEqual("NE", result);
        }
    }
}
