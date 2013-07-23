﻿using System.Web.Mvc;
using Umbraco.Web.Mvc;
using OneContact.Models;
using System.Data;

namespace OneContact.Controllers
{
    public class FormController : SurfaceController
    {
        [HttpPost]
        public ActionResult NextStep(teslGeneralInformationFormModel model)
        {
            TESLEntities entities = new TESLEntities();
            entities.Entry<teslGeneralInformationForm>(model.getModel()).State = model.id == 0 ? EntityState.Added : EntityState.Modified;
            entities.SaveChanges();
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                //Perhaps you might want to add a custom message to the ViewBag
                //which will be available on the View when it renders (since we're not 
                //redirecting)
                return CurrentUmbracoPage();
            }
            Session["ApplicationId"] = model.id;
            return RedirectToUmbracoPage(1243);
        }

        [HttpPost]
        public ActionResult Save(teslStandardOneFormModel model)
        {
            TESLEntities entities = new TESLEntities();
            entities.Entry<teslStandardOneForm>(model.getModel()).State = model.id == 0 ? EntityState.Added : EntityState.Modified;
            entities.SaveChanges();
            ModelState.Clear();
            return RedirectToUmbracoPage(1);
        }

    }
}
