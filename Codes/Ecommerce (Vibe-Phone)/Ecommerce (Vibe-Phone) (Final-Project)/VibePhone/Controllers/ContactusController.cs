using Microsoft.AspNetCore.Mvc;
using VibePhone.Models;
using VibePhone.Repository.Contact;

namespace VibePhone.Controllers
{
    public class ContactusController : Controller
    {
        private readonly IContactusRepo _IContactusRepo;

        public ContactusController(IContactusRepo contactusRepo)
        {
            _IContactusRepo = contactusRepo;
        }

        // ====================================================================
        //                               Add Contact
        // ====================================================================
        
        [HttpGet("AddContact")]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost("AddContact")]
        public IActionResult AddContact(Contactus model)
        {
            if (ModelState.IsValid)
            {
                _IContactusRepo.AddContact(model);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Contactus");
            }
            return View(model);
        }

        // ====================================================================
        //                               Delete Contact
        // ====================================================================
        [HttpGet("DeleteContact/{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contact = _IContactusRepo.GetContactById(id);
            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost]
        public IActionResult DeleteContactConfirmed(int id)
        {
            _IContactusRepo.DeleteContact(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Contactus");
        }


    }
}
