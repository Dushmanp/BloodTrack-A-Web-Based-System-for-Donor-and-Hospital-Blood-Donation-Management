using BloodBankL.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BloodBankSystem.Models
{
    public class CampaignEditView
    {
        public BloodDonationCampaign Data { get; set; }

        [Display(Name = "Image")]
        public IFormFile FileUpload { get; set; }
    }
}
