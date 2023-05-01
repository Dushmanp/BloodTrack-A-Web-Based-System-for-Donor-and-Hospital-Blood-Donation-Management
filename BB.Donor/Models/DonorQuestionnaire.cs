using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donor.Models
{
    public class DonorQuestionnaire
    {
        #region Data

        [Key]
        [Required]
        [Display(Name = "Questionnaire ID")]
        public string QuestionnaireID { get; set; }


        [Display(Name = "Q1: Did you experience any problems during your previous blood donations?")]
        [Required(ErrorMessage = "Please select if you experienced any problems during your previous blood donations.")]
        public int? Q1Prob { get; set; }

        [Display(Name = "Q2: Have you ever been advised by a doctor not to donate blood?")]
        [Required(ErrorMessage = "Please select if you have ever been advised by a doctor not to donate blood.")]
        public int? Q1Doctor { get; set; }

        [Display(Name = "Q3: Are you currently in good health?")]
        [Required(ErrorMessage = "Please select if you are currently in good health.")]
        public int? Q1Health { get; set; }

        [Display(Name = "Q4: Have you suffered from or been treated for any of the following medical conditions?" +
            "Heart disease,Paralysis,Diabetes,Ellipsis (Fif%),Cancer,Asthma/ lung disease,Blood diseases,Kidney disease")]
        [Required(ErrorMessage = "Please select if you have suffered from or been treated for any medical conditions.")]
        public int? Q2medCond { get; set; }

        [Display(Name = "Q5: Are you currently taking any medication?")]
        [Required(ErrorMessage = "Please select if you are currently taking any medication.")]

        public int? Q3Medication { get; set; }

        [Display(Name = "Q6: Have you had any surgery in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you had any surgery in the past 6 months.")]
        public int? Q4Surgery { get; set; }

        [Display(Name = "Q7: Do you do heavy work or heavy exercise?")]
        [Required(ErrorMessage = "Please select if you do heavy work or heavy exercise.")]
        public int? Q5Heavywork { get; set; }

        [Display(Name = "Q8: Are you pregnant or have you given birth in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you are pregnant or have you given birth in the past 6 months.")]
        public int? Q6Pregnant { get; set; }

        [Display(Name = "Q9: Have you ever had Yellow Fever?")]
        [Required(ErrorMessage = "Please select if you ever had Yellow Fever.")]
        public int? Q7YellowFever { get; set; }

        [Display(Name = "Q10: Have you ever had TB or Typhoid fever?")]
        [Required(ErrorMessage = "Please select if you ever had TB or Typhoid fever.")]
        public int? Q7TbTyphoid { get; set; }

        [Display(Name = "Q11: Have you been treated for any disease in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you have been treated for any disease in the past 6 months.")]
        public int? Q7Treated { get; set; }

        [Display(Name = "Q12: Have you received any immunizations or vaccinations in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you received any immunizations or vaccinations in the past 6 months.")]

        public int? Q8Immunization { get; set; }

        [Display(Name = "Q13: Have you had any tattoos or acupuncture in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you had any tattoos or acupuncture in the past 6 months.")]
        public int? Q8TattooAcupuncture { get; set; }

        [Display(Name = "Q14: Have you traveled outside the country in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you had traveled outside the country in the past 6 months.")]
        public int? Q8Abroad { get; set; }

        [Display(Name = "Q15: Have you been in prison in the past 6 months?")]
        [Required(ErrorMessage = "Please select if you had been in prison in the past 6 months.")]
        public int? Q8Prison { get; set; }

        [Display(Name = "Q16: Have you donated blood in the past 3 months?")]
        [Required(ErrorMessage = "Please select if you had donated blood in the past 3 months.")]
        public int? Q8Blood { get; set; }

        [Display(Name = "Q17: Have you had malaria in the past 3 months?")]
        [Required(ErrorMessage = "Please select if you had malaria in the past 3 months.")]
        public int? Q8Malaria { get; set; }

        [Display(Name = "Q18: Have you had dengue fever in the past 3 months?")]
        [Required(ErrorMessage = "Please select if you had dengue fever in the past 3 months.")]
        public int? Q9Dengue { get; set; }

        [Display(Name = "Q19: Have you had any fever in the past 3 months?")]
        [Required(ErrorMessage = "Please select if you had any fever in the past 3 months.")]
        public int? Q9Fever { get; set; }

        [Display(Name = "Q20: Teeth removed or taken antibiotics/aspirin/other drugs in the last week?")]
        [Required(ErrorMessage = "Please select if you had any Teeth removed or taken antibiotics/aspirin/other drugs in the last week.")]
        public int? Q9Teeth { get; set; }

        [Display(Name = "Q21: Do you belong to any of the following categories? AIDS/HIV, Hepatitis B/C, multiple sexual partners, male homosexual relationship, injected drugs, prostitution, engaged in prostitution in last 12 months, or suspected of having AIDS/HIV/STI.")]
        [Required(ErrorMessage = "Please select if you belong to any of the following categories? AIDS/HIV, Hepatitis B/C, multiple sexual partners, male homosexual relationship, injected drugs, prostitution, engaged in prostitution in last 12 months, or suspected of having AIDS/HIV/STI.")]
        public int? Q10Categories { get; set; }

        [Display(Name = "Q22: Does your sexual partner belong to any of the categories listed in question 10?")]
        [Required(ErrorMessage = "Please select if your sexual partner belong to any of the categories listed in question 10.")]
        public int? Q11PartnerCategory { get; set; }

        [Display(Name = "Q23: Do you have weight loss, swollen glands, persistent fever, or diarrhea?")]
        [Required(ErrorMessage = "Please select if you had  weight loss, swollen glands, persistent fever, or diarrhea.")]
        public int? Q12Symptoms { get; set; }





        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "/Home/Index";

        #endregion


        #region Display

        [Display(Name = "Blood Bank Centre")]
        [Required(ErrorMessage = "Please select Blood Bank Centre.")]

        public string BloodBankCentreID { get; set; }
        #endregion

    }

    public class DonationAddEdit
    {
        public DonorQuestionnaire questionnaire { get; set; }
        public DonarDonation donarDonation { get; set; }

        public string ReturnURL { get; set; } = "/DonarDonation/Index";

        public int Property
        {
            get => default;
            set
            {
            }
        }
    }


}
