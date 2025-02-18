﻿namespace LearningSystem.Web.Areas.Admin.Controllers
{
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Models.Courses;
    using Services;

    using static Common.WebConstants.Roles;

    [Area("Admin")]
    [Authorize(Roles = Administrator)]
    public class CourseController : Controller
    {
        private readonly ICourseService courses;
        private readonly UserManager<User> userManager;

        public CourseController(ICourseService courses, UserManager<User> userManager)
        {
            this.courses = courses;
            this.userManager = userManager;
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateCourseFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            this.courses.Create(
                formModel.Name,
                formModel.Description,
                this.userManager.GetUserId(User),
                formModel.StartDate,
                formModel.EndDate);

            return RedirectToAction("Index", "Home");
        }
    }
}
