using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OneContact.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }
        
        [Required]
        public string Message { get; set; }

        public List<SelectListItem> ContactTypes { get; set; }
        
        public string ContactType { get; set; }
    }
}