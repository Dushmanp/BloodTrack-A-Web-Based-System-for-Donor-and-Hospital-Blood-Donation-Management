using Account.Models;
using BloodBankL.Models;
using Donor.Models;

public interface ISessionData
{
    DonorInfo GetUser();
    OutHospital GetOHospital();
    DoctorInfo GetDoctor();
    User GetBB();
}