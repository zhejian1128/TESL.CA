using System;
using System.Web.UI.WebControls;
using OneContact.BusinessLogic;
using Umbraco.Web.UI.Controls;

namespace OneContact.usercontrols
{
public partial class ContactUs : UmbracoUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ContactType.Items.Add(new ListItem("Contact", "contact"));
        ContactType.Items.Add(new ListItem("Request for quote", "quote"));
        ContactType.Items.Add(new ListItem("Testimonial", "testimonial"));
    }

    protected void SendMail(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            var mail = new Mail.MailVariables
                        {
                            From = Email.Text,
                            FromName = Name.Text,
                            Content = string.Format("Contact type: {0}<br /><br />{1}", ContactType.Text, Message.Text),
                            Subject = "Contact mail from site",
                            To = "contact@example.com",
                            ToName = "Site Owner Name"
                        };

            if (Mail.SendMail(mail))
            {
                if (ContactType.SelectedValue == "testimonial")
                    CreateTestimonial(Name.Text, Message.Text);

                Form.Visible = false;
                Thanks.Visible = true;
            }
        }
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