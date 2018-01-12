using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using LostAndFound.Data.Models;
using LostAndFound.Framework.Enums;

namespace LostAndFound.ViewModels
{
    public class LostReportViewModel
    {
     
        [Display(Name = "Date last seen")]
        public DateTime DateLost { get; set; }
        [Display(Name = "Time last seen")]
        public DateTime TimeLost { get; set; }
        [Display(Name="Additional information")]
        public string AdditionalInformation { get; set; }

        //Pet :Animal
        [Display(Name = "Name")]
        public string PetName { get; set; }
        [Display(Name = "Nicknames")]
        public List<string> PetNicknames { get; set; }

        [Display(Name = "Species")]
        public AnimalSpecies Species { get; set; }
        [Display(Name = "Pet description")]
        public string Description { get; set; }
        [Display(Name = "Primary colour")]
        public AnimalColor PrimaryColor { get; set; }
        [Display(Name = "Other colours")]
        public List<AnimalColor> OtherColors { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Coat yype")]
        public CoatType CoatType { get; set; }
        [Display(Name = "Coat length")]
        public CoatLength CoatLength { get; set; }
        [Display(Name = "Colour pattern")]
        public Colorpattern Colorpattern { get; set; }
        [Display(Name = "Eye type")]
        public EyeType EyeType { get; set; }
        [Display(Name = "Ear type")]
        public EarType EarType { get; set; }
        [Display(Name = "Tail type")]
        public TailType TailType { get; set; }
        [Display(Name = "Size")]
        public SizeClassification SizeClassification { get; set; }
        [Display(Name = "Weight")]
        public BodyMassClassification BodyMassClassification { get; set; }

        //Contact
        [Display(Name = "Mobile number")]
        public string MobileNumber { get; set; }
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Additional contact numbers")]
        public List<string> AdditionalContactNumbers { get; set; }
        [Display(Name = "Additional email addresses")]
        public List<string> AdditionalEmailAddresses { get; set; }

        //Location
        public string Location { get; set; }






    }
}