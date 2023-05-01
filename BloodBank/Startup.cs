using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30); });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<DropDown.ICommonDDL, DropDown.CommonDDL>();
            services.AddTransient<IEmailSender, EmailSender>();
          
            services.AddTransient<ISessionData, SessionData>();

            //Database 
            services.AddSingleton<DBAccess.IDBAccess>(new DBAccess.MSSQLDataAccess(AppData.GetMSSQLDBCon()));

            //Account
            services.AddTransient<Account.Data.ISystemData, Account.Data.SystemData>();
            services.AddTransient<Account.Data.IUserData, Account.Data.UserData>();
            services.AddTransient<Account.Data.ITokenData, Account.Data.TokenData>();
            services.AddTransient<Account.Data.IEmailSettingData, Account.Data.EmailSettingData>();
            services.AddTransient<Account.Data.IAPIKeyData, Account.Data.APIKeyData>();

            //Blood Bank
            services.AddTransient<DropDown.IBloodBankDDL, DropDown.BloodBankDDL>();
            services.AddTransient<BloodBankL.Data.IBloodBankCentreData, BloodBankL.Data.BloodBankCentreData>();
            services.AddTransient<BloodBankL.Data.ILocationData, BloodBankL.Data.LocationData>();
            services.AddTransient<BloodBankL.Data.IBloodDonationCampaignData, BloodBankL.Data.BloodDonationCampaignData>();
            services.AddTransient<BloodBankL.Data.IOutHospitalData, BloodBankL.Data.OutHospitalData>();
            services.AddTransient<BloodBankL.Data.IBloodRequestData, BloodBankL.Data.BloodRequestData>();
            services.AddTransient<BloodBankL.Data.IBloodRequestDetailsData, BloodBankL.Data.BloodRequestDetailsData>();
            services.AddTransient<BloodBankL.Data.IDoctorData, BloodBankL.Data.DoctorData>();
            services.AddTransient<BloodBankL.Data.IDonationProgressionData, BloodBankL.Data.DonationProgressionData>();

            //Donor
            services.AddTransient<DropDown.IDonorDDL, DropDown.DonorDDL>();
            services.AddTransient<Donor.Data.IDonorInfoData, Donor.Data.DonorInfoData>();
            services.AddTransient<Donor.Data.IDonarDonationData, Donor.Data.DonarDonationData>();
            services.AddTransient<Donor.Data.IDonorQuestionnaireData, Donor.Data.DonorQuestionnaireData>();
            services.AddTransient<Donor.Data.IBloodTestResultData, Donor.Data.BloodTestResultData>();
            services.AddTransient<Donor.Data.IBloodRecordData, Donor.Data.BloodRecordData>();

        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
