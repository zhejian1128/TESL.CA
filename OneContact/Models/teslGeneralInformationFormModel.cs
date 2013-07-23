using OneContact.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneContact.Models
{
    public class teslGeneralInformationFormModel
    {
        public int id { get; set; }

        [Required(ErrorMessage= "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage= "FirstName is required")]
        public string FirstName { get; set; }

        public string Initial { get; set; }
        public string NameOnCertificate { get; set; }
        public Nullable<int> CivicNumber { get; set; }
        public string Street { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string City { get; set; }
        public Nullable<int> Province { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }

        [Email(ErrorMessage = "Not a vaild Email")]
        public string Email { get; set; }
        public string Fax { get; set; }
        public Nullable<int> LanguageProficiencyRequired { get; set; }
        public Nullable<byte> Upgrading { get; set; }
        public Nullable<int> StandardAppliedFor { get; set; }
        public Nullable<int> ProvincialMembership { get; set; }
        public Nullable<int> MembershipSumitMethod { get; set; }

        public List<SelectListItem> ProvinceList { get; set; }
        public Dictionary<int, string> ProvincialMembershipList { get; set; }
        public Dictionary<int, string> StandardList { get; set; }
        public Dictionary<int, string> MembershipSubmitMethodList { get; set; }

        public string HomePhone_First { get; set; }
        public string HomePhone_Second { get; set; }
        public string HomePhone_Third { get; set; }

        public string WorkPhone_First { get; set; }
        public string WorkPhone_Second { get; set; }
        public string WorkPhone_Third { get; set; }
        public string WorkPhone_Ext { get; set; }

        public string MobilePhone_First { get; set; }
        public string MobilePhone_Second { get; set; }
        public string MobilePhone_Third { get; set; }

        public string Fax_First { get; set; }
        public string Fax_Second { get; set; }
        public string Fax_Third { get; set; }


        public teslGeneralInformationForm getModel()
        {
            teslGeneralInformationForm model = new teslGeneralInformationForm();

            model.LastName = this.LastName;
            model.FirstName = this.FirstName;
            model.Initial = this.Initial;
            model.NameOnCertificate = this.NameOnCertificate;
            model.CivicNumber = this.CivicNumber;
            model.Street = this.Street;
            model.PostalCode = this.PostalCode;
            model.Province = this.Province;
            
            model.HomePhone = this.HomePhone_First + "-" + this.HomePhone_Second + "-" + this.HomePhone_Third;
            model.WorkPhone = this.WorkPhone_First + "-" + this.WorkPhone_Second + "-" + this.WorkPhone_Third;
            model.MobilePhone = this.MobilePhone_First + "-" + this.MobilePhone_Second + "-" + this.WorkPhone_Third;

            model.Email = this.Email;
            model.Fax = this.Fax_First + "-" + this.Fax_Second + "-" + this.Fax_Third;

            model.LanguageProficiencyRequired = this.LanguageProficiencyRequired;
            model.Upgrading = this.Upgrading;
            model.StandardAppliedFor = this.StandardAppliedFor;
            model.ProvincialMembership = this.ProvincialMembership;
            model.MembershipSumitMethod = this.MembershipSumitMethod;

            return model;
        }
    }
}
