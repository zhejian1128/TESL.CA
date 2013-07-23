using System.Web.Mvc;
using OneContact.BusinessLogic;
using OneContact.Models;
using Umbraco.Web.Mvc;

namespace OneContact.Controllers
{
    public class ContactUsController : SurfaceController
    {
        [HttpPost]
        public ActionResult HandleContactSubmit(ContactModel model)
        {
            //model not valid, do not save, but return current umbraco page
            if (ModelState.IsValid == false)
            {
                //Perhaps you might want to add a custom message to the TempData or ViewBag
                //which will be available on the View when it renders (since we're not 
                //redirecting)          
                return CurrentUmbracoPage();
            }

            var mail = new Mail.MailVariables
            {
                From = model.Email,
                FromName = model.Name,
                Content = string.Format("Contact type: {0}<br /><br />{1}", model.ContactType, model.Message),
                Subject = "Contact mail from site",
                To = "contact@example.com",
                ToName = "Site Owner Name"
            };

            if (Mail.SendMail(mail))
            {
                if (model.ContactType == "testimonial")
                    CreateTestimonial(model.Name, model.Message);

                TempData.Add("Success", true);
            }
            
            //if validation passes perform whatever logic
            //In this sample we keep it empty, but try setting a breakpoint to see what is posted here

            //Perhaps you might want to store some data in TempData which will be available 
            //in the View after the redirect below. An example might be to show a custom 'submit
            //successful' message on the View, for example:
            //TempData.Add("CustomMessage", "Your form was successfully submitted at " + DateTime.Now)

            //redirect to current page to clear the form
            return RedirectToCurrentUmbracoPage();

            //Or redirect to specific page
            //return RedirectToUmbracoPage(12345)
        }
        private void CreateTestimonial(string name, string body)
        {
            var contentService = Services.ContentService;

            // This should be a macro parameter of course :-)
            const int testimonialPageId = 1068;
            var content = contentService.CreateContent(name, testimonialPageId, "umbTextPage");

            content.SetValue("bodyText", body);

            contentService.SaveAndPublish(content);
        }
    }
}
