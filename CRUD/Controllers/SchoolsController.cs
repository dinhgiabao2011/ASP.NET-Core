using CRUD.Context;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
	public class SchoolsController : Controller
	{
    private SchoolContext _db;

    public SchoolsController(SchoolContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      var course = _db.Courses.ToList();
      return View(course);
    }
    [HttpGet]
    public IActionResult Create()
    {
      Course course = new Course();
      return View(course);
    }
    [HttpPost]
    public IActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Detail(int id)
		{
      Course course = _db.Courses.Find(id);
      return View(course);
		}
    [HttpPost]
    public IActionResult Update(Course course)
		{
      var courseinDb = _db.Courses.SingleOrDefault(c => c.Id == course.Id);
			if (courseinDb == null)
			{
        return NotFound();
			}
      courseinDb.Name = course.Name;
      _db.Courses.Update(courseinDb);
      _db.SaveChanges();
      return RedirectToAction("Detail", new { id = courseinDb.Id});
    }
    [HttpGet]
    public IActionResult Delete(int id)
		{
      var courseDb = _db.Courses.Find(id);
      _db.Courses.Remove(courseDb);
      _db.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
  }
}
