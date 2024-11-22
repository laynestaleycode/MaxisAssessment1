using MaxisAssessment1.Data;
using MaxisAssessment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaxisAssessment1.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public  ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submissions(string searchQuery)
        {
            var submissions = string.IsNullOrEmpty(searchQuery)
                ? _context.ContactSubmissions.ToList()
                : _context.ContactSubmissions
                          .Where(s => s.Name.Contains(searchQuery))
                          .ToList();

            ViewData["SearchQuery"] = searchQuery;
            return View(submissions);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(ContactSubmission submission)
        {
            if (ModelState.IsValid)
            {
                _context.ContactSubmissions.Add(submission);
                _context.SaveChanges();
                return RedirectToAction("Submissions");
            }

            return View("Index", submission);
        }


    }
}
