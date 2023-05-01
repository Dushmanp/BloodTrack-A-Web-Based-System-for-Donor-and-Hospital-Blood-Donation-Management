using Account.Data;
using Account.Models;
using BloodBank.Models;
using Donor.Data;
using Donor.Models;
using BloodBankL.Data;
using BloodBankl.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodBank.Controllers
{

    public class AccountController : Controller
    {
        #region Construction

        private readonly IDonorInfoData rep;
        private readonly IEmailSender email;
        private readonly ITokenData repToken;
        private readonly IOutHospitalData outHospital;
        private readonly IDoctorData doctorData ;
        private readonly IUserData bbUser;
        public AccountController(IDonorInfoData rep, IEmailSender email, ITokenData repToken,IOutHospitalData outHospital, IDoctorData doctorData, IUserData bbUser)  
        {
            this.rep = rep;
            this.email = email;
            this.repToken = repToken;
            this.outHospital = outHospital;
            this.doctorData = doctorData;
            this.bbUser = bbUser;
        }

        #endregion

        # region Donor
        public IActionResult Register()
        {
            var obj = new DonorInfo();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Register(DonorInfo obj)
        {
            try
            {
                 
                obj.Password = Crypto.Encrypt(obj.Password);
                obj.DonorID = await rep.AddEdit
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                HttpContext.Session.SetObject("Donor", obj);
                await SaveCookie(obj.DonorID);
                return RedirectToAction("Index","Home");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to register. " + ex.Message;
            }

            return View(obj);
        }


        public async Task<IActionResult> Login(string ReturnURL)
        {
            if(Request.Cookies["OutHospitalRem"] != null)
            {
                return RedirectToAction("LoginOH", "Account");
            }
            if (Request.Cookies["BBRem"] != null)
            {
                return RedirectToAction("LoginBB", "Account");
            }
            if (Request.Cookies["DoctorRem"] != null)
            {
                return RedirectToAction("LoginDoc", "Account");
            }
            // Check for Cookie
            if (Request.Cookies["ARem"] != null)
            {
                var TokenID = Request.Cookies["ARem"];
                var tk = await repToken.Get(AppData.GetAPIKey(), TokenID);
                if (tk == null) goto SkipToLogin;
                if (tk.IsValid == false) goto SkipToLogin;

                var usr = await rep.Get(AppData.GetAPIKey(), tk.RefID);


                HttpContext.Session.SetObject("Donor", usr);

                if (ReturnURL != null && ReturnURL != "")
                {
                    return Redirect(ReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            SkipToLogin:
            var obj = new LoginView();
            if (ReturnURL != null)
            {
                obj.ReturnURL = ReturnURL.Replace("(and)", "&");
                ViewData["ErrorMessage"] = "Please login to continue";
            }

            return View(obj);
        
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginView obj)
        {
            try
            {
                var usr = await rep.GetByEmail(AppData.GetAPIKey(), obj.EmailAddress);
                if (usr != null)
                {
                    if (Crypto.Encrypt(obj.Password) != usr.Password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                    }

                    else
                    {
                        HttpContext.Session.SetObject("Donor", usr);

                        if (obj.RememberMe)
                        {

                            await SaveCookie(usr.DonorID);
                        }

                        if (obj.ReturnURL != null && obj.ReturnURL != "")
                        {
                            return Redirect(obj.ReturnURL);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid Email Address. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult ForgotPassword()
        {
            var obj = new LoginView();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(LoginView obj)
        {
            try
            {
                var usr = await rep.GetByEmail(AppData.GetAPIKey(), obj.EmailAddress);
                if (usr != null)
                {
                    var tk = new Token();
                    tk.TokenID = "";
                    tk.TokenType = "APwReset";
                    tk.RefID = usr.DonorID;
                    tk.TokenData = "";
                    tk.CreatedDate = DateTime.Now;
                    tk.ExpiryDate = DateTime.Now.AddDays(2);
                    tk.TokenStatus = "A";

                    tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

                    email.Subject = "Blood Bank Donor Account Recovery";
                    email.ToName = usr.Name;
                    email.Description += "Please click on below link/button to reset your password This link will expire after 48 hours";

                    email.ActionName = "Reset Password";
                    email.URL = $"{AppData.GetWebURL()}/Account/ResetPassword/{tk.TokenID}";

                    email.Sendto = new List<string>(new[] { usr.Email });
                    await email.SendEmail(SendAndWait: true);

                    ViewBag.MsgTitle = "";
                    ViewBag.MsgBody = "Password Reset link sent to your email address. Please use the link to reset your password.";
                    ViewBag.MsgBodySpam = "(Please check your spam/junk folder if the email is not in your inbox).";
                    ViewBag.MsgLink = "/Account/Login";
                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    ViewBag.ErrorMessage = "This email address is not regsitered.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public async Task<IActionResult> ResetPassword(string id)
        {
            var obj = new LoginView();

            try
            {
                var token = await repToken.Get(AppData.GetAPIKey(), id);
                if (token == null)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";
                    ViewBag.MsgLink = "/Account/Login";
                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.IsValid == false)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.TokenType != "APwReset")
                {
                    ViewBag.MsgTitle = "Invalid toke type";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    var usr = await rep.Get(AppData.GetAPIKey(), token.RefID);
                    obj.DonorID = usr.DonorID;
                    obj.TokenID = token.TokenID;
                }
            }
            catch (Exception ex)
            {
                ViewBag.MsgTitle = "Error in token";
                ViewBag.MsgBody = ex.Message;

                return View("~/Views/Shared/Message.cshtml");
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(LoginView obj)
        {
            try
            {
                var usr = await rep.Get(AppData.GetAPIKey(), obj.DonorID);
                usr.Password = Crypto.Encrypt(obj.Password);
                usr.DonorID = await rep.AddEdit(AppData.GetAPIKey(), usr, "");

                var token = await repToken.Get(AppData.GetAPIKey(), obj.TokenID);
                token.TokenStatus = "CM";
                token.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), token);

                ViewBag.MsgTitle = "Password Reset Success!";
                ViewBag.MsgBody = "Your account is now having the new password.";
                ViewBag.MsgLink = "/Account/Login";
                return View("~/Views/Shared/Message.cshtml");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult _Timeout(string ReturnURL)
        {

            ViewData["ReturnURL"] = ReturnURL;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Append("ARem", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });

            return RedirectToAction("Login", "Account");
        }
        // Supporting
        public async Task SaveCookie(string DonorID)
        {
            var OldVal = HttpContext.Request.Cookies["ARem"];
            var TokenValue = "";
            if (OldVal != null)
            {
                var oldToken = await repToken.Get(AppData.GetAPIKey(), OldVal);
                if (oldToken != null)
                {
                    TokenValue = oldToken.TokenID;
                    goto SaveToken;
                }
                else
                {
                    TokenValue = "";
                    goto SaveToken;
                }
            }
            else
            {
                goto SaveToken;
            }


            SaveToken:
            var tk = new Token();
            tk.TokenID = TokenValue;
            tk.TokenType = "ARem";
            tk.RefID = DonorID;
            tk.TokenData = "";
            tk.CreatedDate = DateTime.Now;
            tk.ExpiryDate = DateTime.Now.AddMonths(3);
            tk.TokenStatus = "A";

            tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

            CookieOptions option = new CookieOptions();
            option.Expires = tk.ExpiryDate;
            Response.Cookies.Append("ARem", tk.TokenID, option);
        }
        #endregion


        #region Hospital
        public async Task<IActionResult> LoginOH(string ReturnURL)
        {
            if (Request.Cookies["ARem"] != null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Request.Cookies["BBRem"] != null)
            {
                return RedirectToAction("LoginBB", "Account");
            }
            if (Request.Cookies["DoctorRem"] != null)
            {
                return RedirectToAction("LoginDoc", "Account");
            }
            // Check for Cookie
            if (Request.Cookies["OutHospitalRem"] != null)
            {
                var TokenID = Request.Cookies["OutHospitalRem"];
                var tk = await repToken.Get(AppData.GetAPIKey(), TokenID);
                if (tk == null) goto SkipToLogin;
                if (tk.IsValid == false) goto SkipToLogin;

                var Ohsp = await outHospital.Get(AppData.GetAPIKey(), tk.RefID);


                HttpContext.Session.SetObject("OutHospital", Ohsp);

                if (ReturnURL != null && ReturnURL != "")
                {
                    return Redirect(ReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Area = "OHospital" });
                }
            }

            SkipToLogin:
            var obj = new LoginView();
            if (ReturnURL != null)
            {
                obj.ReturnURL = ReturnURL.Replace("(and)", "&");
                ViewData["ErrorMessage"] = "Please login to continue";
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> LoginOH(LoginView obj)
        {
            try
            {
                var Ohsp = await outHospital.GetByUsername(AppData.GetAPIKey(), obj.Username);
                if (Ohsp != null)
                {
                    if (Crypto.Encrypt(obj.Password) != Ohsp.Password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                    }

                    else
                    {
                        HttpContext.Session.SetObject("OutHospital", Ohsp);

                        if (obj.RememberMe)
                        {

                            await SaveOutHospitalCookie(Ohsp.HospitalID);
                        }

                        if (obj.ReturnURL != null && obj.ReturnURL != "")
                        {
                            return Redirect(obj.ReturnURL);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { Area = "OHospital" });
                        }
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid Username. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }


        public IActionResult ForgotOHPassword()
        {
            var obj = new LoginView();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ForgotOHPassword(LoginView obj)
        {
            try
            {
                var usr = await outHospital.GetByEmail(AppData.GetAPIKey(), obj.EmailAddress);
                if (usr != null)
                {
                    var tk = new Token();
                    tk.TokenID = "";
                    tk.TokenType = "APwReset";
                    tk.RefID = usr.HospitalID;
                    tk.TokenData = "";
                    tk.CreatedDate = DateTime.Now;
                    tk.ExpiryDate = DateTime.Now.AddDays(2);
                    tk.TokenStatus = "A";

                    tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

                    email.Subject = "Hospital Account Recovery";
                    email.ToName = usr.HospitalName;
                    email.Description += "We received a request to reset your Hospital Account password. Please use the link or button below to reset your password. This link will expire after 48 hours. If you did not request a password reset, please ignore this email";

                    email.ActionName = "Reset Password";
                    email.URL = $"{AppData.GetWebURL()}/Account/ResetOHPassword/{tk.TokenID}";

                    email.Sendto = new List<string>(new[] { usr.Email });
                    await email.SendEmail(SendAndWait: true);

                    ViewBag.MsgTitle = "";
                    ViewBag.MsgBody = "Password Reset link sent to your email address. Please use the link to reset your password.";
                    ViewBag.MsgBodySpam = "(Please check your spam/junk folder if the email is not in your inbox).";
                    ViewBag.MsgLink = "/Account/LoginOH";
                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    ViewBag.ErrorMessage = "This email address is not regsitered.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }
        public IActionResult LogoutOH()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Append("OutHospitalRem", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            return RedirectToAction("LoginOH", "Account");


        }

        public async Task<IActionResult> ResetOHPassword(string id)
        {
            var obj = new LoginView();

            try
            {
                var token = await repToken.Get(AppData.GetAPIKey(), id);
                if (token == null)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.IsValid == false)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.TokenType != "APwReset")
                {
                    ViewBag.MsgTitle = "Invalid toke type";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    var OH = await outHospital.Get(AppData.GetAPIKey(), token.RefID);
                    obj.HospitalID = OH.HospitalID;
                    obj.TokenID = token.TokenID;
                }
            }
            catch (Exception ex)
            {
                ViewBag.MsgTitle = "Error in token";
                ViewBag.MsgBody = ex.Message;

                return View("~/Views/Shared/Message.cshtml");
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ResetOHPassword(LoginView obj)
        {
            try
            {
                var OH = await outHospital.Get(AppData.GetAPIKey(), obj.HospitalID);
                OH.Password = Crypto.Encrypt(obj.Password);
                OH.HospitalID = await outHospital.AddEdit(AppData.GetAPIKey(), OH, "");

                var token = await repToken.Get(AppData.GetAPIKey(), obj.TokenID);
                token.TokenStatus = "CM";
                token.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), token);

                ViewBag.MsgTitle = "Password Reset Success!";
                ViewBag.MsgBody = "Your account is now having the new password.";
                ViewBag.MsgLink = "/Account/LoginOH";
                return View("~/Views/Shared/Message.cshtml");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public async Task SaveOutHospitalCookie(string HospitalID)
        {
            var OldVal = HttpContext.Request.Cookies["OutHospitalRem"];
            var TokenValue = "";
            if (OldVal != null)
            {
                var oldToken = await repToken.Get(AppData.GetAPIKey(), OldVal);
                if (oldToken != null)
                {
                    TokenValue = oldToken.TokenID;
                    goto SaveToken;
                }
                else
                {
                    TokenValue = "";
                    goto SaveToken;
                }
            }
            else
            {
                goto SaveToken;
            }


            SaveToken:
            var tk = new Token();
            tk.TokenID = TokenValue;
            tk.TokenType = "OutHospitalRem";
            tk.RefID = HospitalID;
            tk.TokenData = "";
            tk.CreatedDate = DateTime.Now;
            tk.ExpiryDate = DateTime.Now.AddMonths(3);
            tk.TokenStatus = "A";

            tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

            CookieOptions option = new CookieOptions();
            option.Expires = tk.ExpiryDate;
            Response.Cookies.Append("OutHospitalRem", tk.TokenID, option);
        }

        #endregion


        #region Doctor
        public async Task<IActionResult> LoginDoc(string ReturnURL)
        {
            if (Request.Cookies["OutHospitalRem"] != null)
            {
                return RedirectToAction("LoginOH", "Account");
            }

            if (Request.Cookies["ARem"] != null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (Request.Cookies["BBRem"] != null)
            {
                return RedirectToAction("LoginBB", "Account");
            }
            // Check for Cookie
            if (Request.Cookies["DoctorRem"] != null)
            {
                var TokenID = Request.Cookies["DoctorRem"];
                var tk = await repToken.Get(AppData.GetAPIKey(), TokenID);
                if (tk == null) goto SkipToLogin;
                if (tk.IsValid == false) goto SkipToLogin;

                var doc = await doctorData.Get(AppData.GetAPIKey(), tk.RefID);


                HttpContext.Session.SetObject("Doctor", doc);

                if (ReturnURL != null && ReturnURL != "")
                {
                    return Redirect(ReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Area = "Doctor" });
                }
            }

            SkipToLogin:
            var obj = new LoginView();
            if (ReturnURL != null)
            {
                obj.ReturnURL = ReturnURL.Replace("(and)", "&");
                ViewData["ErrorMessage"] = "Please login to continue";
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> LoginDoc(LoginView obj)
        {
            try
            {
                var doc = await doctorData.GetByUsername(AppData.GetAPIKey(), obj.Username);
                if (doc != null)
                {
                    if (Crypto.Encrypt(obj.Password) != doc.Password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                    }

                    else
                    {
                        HttpContext.Session.SetObject("Doctor", doc);

                        if (obj.RememberMe)
                        {

                            await SaveDoctorCookie(doc.DoctorID);
                        }

                        if (obj.ReturnURL != null && obj.ReturnURL != "")
                        {
                            return Redirect(obj.ReturnURL);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { Area = "Doctor" });
                        }
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid Username. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult ForgotDocPassword()
        {
            var obj = new LoginView();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ForgotDocPassword(LoginView obj)
        {
            try
            {
                var usr = await doctorData.GetByEmail(AppData.GetAPIKey(), obj.EmailAddress);
                if (usr != null)
                {
                    var tk = new Token();
                    tk.TokenID = "";
                    tk.TokenType = "APwReset";
                    tk.RefID = usr.DoctorID;
                    tk.TokenData = "";
                    tk.CreatedDate = DateTime.Now;
                    tk.ExpiryDate = DateTime.Now.AddDays(2);
                    tk.TokenStatus = "A";

                    tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

                    email.Subject = "Doctor Account Recovery";
                    email.ToName = usr.FullName;
                    email.Description += "We received a request to reset your Doctor Account password. Please use the link or button below to reset your password. This link will expire after 48 hours. If you did not request a password reset, please ignore this email";

                    email.ActionName = "Reset Password";
                    email.URL = $"{AppData.GetWebURL()}/Account/ResetDocPassword/{tk.TokenID}";

                    email.Sendto = new List<string>(new[] { usr.Email });
                    await email.SendEmail(SendAndWait: true);

                    ViewBag.MsgTitle = "";
                    ViewBag.MsgBody = "Password Reset link sent to your email address. Please use the link to reset your password.";
                    ViewBag.MsgBodySpam = "(Please check your spam/junk folder if the email is not in your inbox).";
                    ViewBag.MsgLink = "/Account/LoginDoc";
                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    ViewBag.ErrorMessage = "This email address is not regsitered.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult LogoutDoc()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Append("DoctorRem", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            return RedirectToAction("LoginDoc", "Account");


        }
        public async Task<IActionResult> ResetDocPassword(string id)
        {
            var obj = new LoginView();

            try
            {
                var token = await repToken.Get(AppData.GetAPIKey(), id);
                if (token == null)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.IsValid == false)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.TokenType != "APwReset")
                {
                    ViewBag.MsgTitle = "Invalid toke type";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    var DOC = await doctorData.Get(AppData.GetAPIKey(), token.RefID);
                    obj.DoctorID = DOC.DoctorID;
                    obj.TokenID = token.TokenID;
                }
            }
            catch (Exception ex)
            {
                ViewBag.MsgTitle = "Error in token";
                ViewBag.MsgBody = ex.Message;

                return View("~/Views/Shared/Message.cshtml");
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ResetDocPassword(LoginView obj)
        {
            try
            {
                var doc = await doctorData.Get(AppData.GetAPIKey(), obj.DoctorID);
                doc.Password = Crypto.Encrypt(obj.Password);
                doc.DoctorID = await doctorData.AddEdit(AppData.GetAPIKey(), doc, "");

                var token = await repToken.Get(AppData.GetAPIKey(), obj.TokenID);
                token.TokenStatus = "CM";
                token.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), token);

                ViewBag.MsgTitle = "Password Reset Success!";
                ViewBag.MsgBody = "Your account is now having the new password.";
                ViewBag.MsgLink = "/Account/LoginDoc";
                return View("~/Views/Shared/Message.cshtml");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public async Task SaveDoctorCookie(string DoctorID)
        {
            var OldVal = HttpContext.Request.Cookies["DoctorRem"];
            var TokenValue = "";
            if (OldVal != null)
            {
                var oldToken = await repToken.Get(AppData.GetAPIKey(), OldVal);
                if (oldToken != null)
                {
                    TokenValue = oldToken.TokenID;
                    goto SaveToken;
                }
                else
                {
                    TokenValue = "";
                    goto SaveToken;
                }
            }
            else
            {
                goto SaveToken;
            }


            SaveToken:
            var tk = new Token();
            tk.TokenID = TokenValue;
            tk.TokenType = "DoctorRem";
            tk.RefID = DoctorID;
            tk.TokenData = "";
            tk.CreatedDate = DateTime.Now;
            tk.ExpiryDate = DateTime.Now.AddMonths(3);
            tk.TokenStatus = "A";

            tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

            CookieOptions option = new CookieOptions();
            option.Expires = tk.ExpiryDate;
            Response.Cookies.Append("DoctorRem", tk.TokenID, option);
        }
        #endregion

        #region BloodBank
        public async Task<IActionResult> LoginBB(string ReturnURL)
        {
            if (Request.Cookies["OutHospitalRem"] != null)
            {
                return RedirectToAction("LoginOH", "Account");
            }
            if (Request.Cookies["DoctorRem"] != null)
            {
                return RedirectToAction("LoginDoc", "Account");
            }
            if (Request.Cookies["ARem"] != null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Check for Cookie
            if (Request.Cookies["BBRem"] != null)
            {
                var TokenID = Request.Cookies["BBRem"];
                var tk = await repToken.Get(AppData.GetAPIKey(), TokenID);
                if (tk == null) goto SkipToLogin;
                if (tk.IsValid == false) goto SkipToLogin;

                var doc = await bbUser.Get(AppData.GetAPIKey(), tk.RefID);


                HttpContext.Session.SetObject("BB", doc);

                if (ReturnURL != null && ReturnURL != "")
                {
                    return Redirect(ReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Area = "BloodBankSystem" });
                }
            }

            SkipToLogin:
            var obj = new LoginView();
            if (ReturnURL != null)
            {
                obj.ReturnURL = ReturnURL.Replace("(and)", "&");
                ViewData["ErrorMessage"] = "Please login to continue";
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> LoginBB(LoginView obj)
        {
            try
            {
                var bb = await bbUser.GetByUsername(AppData.GetAPIKey(), obj.Username);
                if (bb != null)
                {
                    if (Crypto.Encrypt(obj.Password) != bb.Password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                    }

                    else
                    {
                        HttpContext.Session.SetObject("BB", bb);

                        if (obj.RememberMe)
                        {

                            await SaveBBCookie(bb.UserID);
                        }

                        if (obj.ReturnURL != null && obj.ReturnURL != "")
                        {
                            return Redirect(obj.ReturnURL);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { Area = "BloodBankSystem" });
                        }
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid Username. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult ForgotBBPassword()
        {
            var obj = new LoginView();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ForgotBBPassword(LoginView obj)
        {
            try
            {
                var usr = await bbUser.GetByEmail(AppData.GetAPIKey(), obj.EmailAddress);
                if (usr != null)
                {
                    var tk = new Token();
                    tk.TokenID = "";
                    tk.TokenType = "APwReset";
                    tk.RefID = usr.UserID;
                    tk.TokenData = "";
                    tk.CreatedDate = DateTime.Now;
                    tk.ExpiryDate = DateTime.Now.AddDays(2);
                    tk.TokenStatus = "A";

                    tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

                    email.Subject = "Blood Bank Account Recovery";
                    email.ToName = usr.DisplayName;
                    email.Description += "We received a request to reset your Blood Bank Account password. Please use the link or button below to reset your password. This link will expire after 48 hours. If you did not request a password reset, please ignore this email";

                    email.ActionName = "Reset Password";
                    email.URL = $"{AppData.GetWebURL()}/Account/ResetBBPassword/{tk.TokenID}";

                    email.Sendto = new List<string>(new[] { usr.EmailAddress });
                    await email.SendEmail(SendAndWait: true);

                    ViewBag.MsgTitle = "";
                    ViewBag.MsgBody = "Password Reset link sent to your email address. Please use the link to reset your password.";
                    ViewBag.MsgBodySpam = "(Please check your spam/junk folder if the email is not in your inbox).";
                    ViewBag.MsgLink = "/Account/LoginBB";
                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    ViewBag.ErrorMessage = "This email address is not regsitered.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult LogoutBB()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Append("BBRem", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            return RedirectToAction("LoginBB", "Account");


        }
        public async Task<IActionResult> ResetBBPassword(string id)
        {
            var obj = new LoginView();

            try
            {
                var token = await repToken.Get(AppData.GetAPIKey(), id);
                if (token == null)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.IsValid == false)
                {
                    ViewBag.MsgTitle = "Invalid Token or broken link";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else if (token.TokenType != "APwReset")
                {
                    ViewBag.MsgTitle = "Invalid toke type";
                    ViewBag.MsgBody = "Please try again to send a new password reset link.";

                    return View("~/Views/Shared/Message.cshtml");
                }
                else
                {
                    var user = await bbUser.Get(AppData.GetAPIKey(), token.RefID);
                    obj.UserID = user.UserID;
                    obj.TokenID = token.TokenID;
                }
            }
            catch (Exception ex)
            {
                ViewBag.MsgTitle = "Error in token";
                ViewBag.MsgBody = ex.Message;

                return View("~/Views/Shared/Message.cshtml");
            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> ResetBBPassword(LoginView obj)
        {
            try
            {
                var user = await bbUser.Get(AppData.GetAPIKey(), obj.UserID);
                user.Password = Crypto.Encrypt(obj.Password);
                user.UserID = await bbUser.AddEdit(AppData.GetAPIKey(), user, "");

                var token = await repToken.Get(AppData.GetAPIKey(), obj.TokenID);
                token.TokenStatus = "CM";
                token.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), token);

                ViewBag.MsgTitle = "Password Reset Success!";
                ViewBag.MsgBody = "Your account is now having the new password.";
                ViewBag.MsgLink = "/Account/LoginBB";
                return View("~/Views/Shared/Message.cshtml");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public async Task SaveBBCookie(string UserID)
        {
            var OldVal = HttpContext.Request.Cookies["BBRem"];
            var TokenValue = "";
            if (OldVal != null)
            {
                var oldToken = await repToken.Get(AppData.GetAPIKey(), OldVal);
                if (oldToken != null)
                {
                    TokenValue = oldToken.TokenID;
                    goto SaveToken;
                }
                else
                {
                    TokenValue = "";
                    goto SaveToken;
                }
            }
            else
            {
                goto SaveToken;
            }


            SaveToken:
            var tk = new Token();
            tk.TokenID = TokenValue;
            tk.TokenType = "BBRem";
            tk.RefID = UserID;
            tk.TokenData = "";
            tk.CreatedDate = DateTime.Now;
            tk.ExpiryDate = DateTime.Now.AddMonths(3);
            tk.TokenStatus = "A";

            tk.TokenID = await repToken.AddEdit(AppData.GetAPIKey(), tk);

            CookieOptions option = new CookieOptions();
            option.Expires = tk.ExpiryDate;
            Response.Cookies.Append("BBRem", tk.TokenID, option);
        }

        #endregion
    }
}
