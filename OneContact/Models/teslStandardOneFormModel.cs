using OneContact.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneContact.Models
{
    public class teslStandardOneFormModel
    {
        public int id { get; set; }
        public Nullable<int> DegreeCompleted { get; set; }
        public Nullable<int> YearCompleted { get; set; }
        public string University { get; set; }
        public Nullable<int> TrainingInstitution { get; set; }
        public string ContactPerson { get; set; }
        public string ProgramName { get; set; }
        public string DateCompleted { get; set; }
        public string InstitutionName { get; set; }
        public Nullable<int> CivicNumber { get; set; }
        public string Street { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string City { get; set; }
        public Nullable<int> Province { get; set; }
        public string SponsorTeacherName { get; set; }
        public string ContactInformation { get; set; }
        public string PracticumSupervisor { get; set; }
        public Nullable<int> HoursObserving { get; set; }
        public Nullable<int> HoursPractice { get; set; }

        public List<SelectListItem> ProvinceList { get; set; }
        public List<SelectListItem> YearList { get; set; }
        public List<SelectListItem> DegreeList { get; set; }
        public List<SelectListItem> TrainingInstitutionList { get; set; }

        public string DateCompleted_First { get; set; }
        public string DateCompleted_Second { get; set; }
        public string DateCompleted_Third { get; set; }

        public teslStandardOneForm getModel()
        {
            teslStandardOneForm model = new teslStandardOneForm();
            model.id = this.id;
            model.DegreeCompleted = this.DegreeCompleted;
            model.YearCompleted = this.YearCompleted;
            model.University = this.University;
            model.TrainingInstitution = this.TrainingInstitution;
            model.ContactPerson = this.ContactPerson;
            model.ProgramName = this.ProgramName;
            model.DateCompleted = this.DateCompleted_First + "-" + this.DateCompleted_Second + "-" + this.DateCompleted_Third;
            model.InstitutionName = this.InstitutionName;
            model.CivicNumber = this.CivicNumber;
            model.Street = this.Street;
            model.PostalCode = this.PostalCode;
            model.City = this.City;
            model.Province = this.Province;
            model.SponsorTeacherName = this.SponsorTeacherName;
            model.ContactInformation = this.ContactInformation;
            model.PracticumSupervisor = this.PracticumSupervisor;
            model.HoursObserving = this.HoursObserving;
            model.HoursPractice = this.HoursPractice;

            return model;
        }
    }
}
