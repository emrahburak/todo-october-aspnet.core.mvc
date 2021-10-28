using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_october_aspnet.core.mvc.Models;
using todo_october_aspnet.core.mvc.Repository;

namespace todo_october_aspnet.core.mvc.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var todos = await _repository.GetAllAsync();

            return View(todos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection form)
        {

            string title = form["title"].ToString();
            var model = new Todo { Title = title };
            await _repository.AddAsync(model);

            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("index");
        }
    }
}
