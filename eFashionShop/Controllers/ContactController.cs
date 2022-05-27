using eFashionShop.Application.Contacts;
using eFashionShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eFashionShop.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public async Task<IActionResult> Index()
        {
            var data = _contactService.Default();
            var res = data.Result;
            if(res == null)
            {
                res = new Contact()
                {
                    Id = -1,
                    Name = "Null",
                    Email = "Null",
                    PhoneNumber = "Null",
                    Address = "Null",
                    Hotline = "Null",
                    Website = "Null",
                    Message = "Null",
                    Default = false,
                    Status = Data.Enums.Status.Active
                };
            }
            return View(res);
        }
    }
}
