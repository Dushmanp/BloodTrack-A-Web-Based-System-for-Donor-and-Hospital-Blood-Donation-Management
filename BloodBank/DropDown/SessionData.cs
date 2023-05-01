using Account.Models;
using BloodBankL.Models;
using Donor.Models;
using Microsoft.AspNetCore.Http;

public class SessionData : ISessionData
{
    public DonorInfo GetUser()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<DonorInfo>("Donor");
    }

    public OutHospital GetOHospital()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<OutHospital>("OutHospital");

    }

    public DoctorInfo GetDoctor()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<DoctorInfo>("Doctor");

    }

    public User GetBB()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<User>("BB");

    }
}
