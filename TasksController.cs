using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaskManager.Web.Models;

namespace TaskManager.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(taskItem);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(taskItem);
        }
    }
}
