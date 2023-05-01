using Microsoft.AspNetCore.Http;
using Account.Models;
using Donor.Models;
using BloodBankL.Models;
using System.Numerics;

public class Auth
{
    public static void CheckUser(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<DonorInfo>("Donor") == null)
        {
            var refUrl = string.Concat(
                        _context.HttpContext.Request.Scheme,
                        "://",
                        _context.HttpContext.Request.Host.ToUriComponent(),
                        _context.HttpContext.Request.PathBase.ToUriComponent(),
                        _context.HttpContext.Request.Path.ToUriComponent(),
                        _context.HttpContext.Request.QueryString.ToUriComponent());
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            if (ReturnURL != "")
            {
                ReturnURL = ReturnURL.Replace("&", "(and)");
                _context.HttpContext.Response.Redirect("/Account/Login?ReturnURL=" + ReturnURL);
            }
            else
            {
                _context.HttpContext.Response.Redirect("/Account/Login");
            }

        }
    }

    public static void CheckUserPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();

        if (_context.HttpContext.Request.Cookies["ARem"] != null)
        {
            return;
        }

        if (_context.HttpContext.Session.GetObject<DonorInfo>("Donor") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }

    public static DonorInfo GetUser()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<DonorInfo>("Donor");
    }

    public static string GetUserID()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        var usr = _context.HttpContext.Session.GetObject<DonorInfo>("Donor");
        if (usr != null)
        {
            return usr.DonorID;
        }
        else
        {
            return "";
        }

        
    }


    public static void CheckOH(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<OutHospital>("OutHospital") == null)
        {
            var refUrl = _context.HttpContext.Request.GetTypedHeaders().Referer;
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            if (ReturnURL != "")
            {
                ReturnURL = ReturnURL.Replace("&", "(and)");
                _context.HttpContext.Response.Redirect("/Account/LoginOH?ReturnURL=" + ReturnURL);
            }
            else
            {
                _context.HttpContext.Response.Redirect("/Account/LoginOH");
            }

        }
    }

    public static void CheckOHPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<OutHospital>("OutHospital") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }
    public static OutHospital GetOutHospital()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<OutHospital>("OutHospital");
    }

    public static string GetOutHospitalID()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        var usr = _context.HttpContext.Session.GetObject<OutHospital>("OutHospital");
        if (usr != null)
        {
            return usr.HospitalID;
        }
        else
        {
            return "";
        }


    }

    public static void CheckDoctor(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<DoctorInfo>("Doctor") == null)
        {
            var refUrl = _context.HttpContext.Request.GetTypedHeaders().Referer;
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            if (ReturnURL != "")
            {
                ReturnURL = ReturnURL.Replace("&", "(and)");
                _context.HttpContext.Response.Redirect("/Account/LoginDoc?ReturnURL=" + ReturnURL);
            }
            else
            {
                _context.HttpContext.Response.Redirect("/Account/LoginDoc");
            }

        }
    }

    public static void CheckDoctorPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<DoctorInfo>("Doctor") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }
    public static DoctorInfo GetDoctor()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<DoctorInfo>("Doctor");
    }

    public static string GetDoctorID()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        var usr = _context.HttpContext.Session.GetObject<DoctorInfo>("Doctor");
        if (usr != null)
        {
            return usr.DoctorID;
        }
        else
        {
            return "";
        }


    }

    public static void CheckBB(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<DoctorInfo>("BB") == null)
        {
            var refUrl = _context.HttpContext.Request.GetTypedHeaders().Referer;
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            if (ReturnURL != "")
            {
                ReturnURL = ReturnURL.Replace("&", "(and)");
                _context.HttpContext.Response.Redirect("/Account/LoginBB?ReturnURL=" + ReturnURL);
            }
            else
            {
                _context.HttpContext.Response.Redirect("/Account/LoginBB");
            }

        }
    }

    public static void CheckBBPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<User>("BB") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }
    public static User GetBB()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        return _context.HttpContext.Session.GetObject<User>("BB");
    }

    public static string GetBBUserID()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        var usr = _context.HttpContext.Session.GetObject<User>("BB");
        if (usr != null)
        {
            return usr.UserID;
        }
        else
        {
            return "";
        }


    }

    public static string GetBBUserType()
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        var usr = _context.HttpContext.Session.GetObject<User>("BB");
        if (usr != null)
        {
            return usr.UserType;
        }
        else
        {
            return "";
        }


    }


}
