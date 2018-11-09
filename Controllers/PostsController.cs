using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newProject.Data;
using newProject.Models;

namespace newProject.Controllers
{
    public class PostsController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _db;

        public PostsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db) 
        {
                this._userManager = userManager;
                this._db = db;
        }
        public IActionResult Create() => View();

        public async Task<IActionResult> Create(CreatePostsViewModel model)
        {
            var newPost = new Post {Title = model.Title, Content = model.Content, ID = Guid.NewGuid().ToString()};
            var user = await _userManager.GetUserAsync(HttpContext.User);
            newPost.CreatedBy = user;
            _db.Posts.Add(newPost);
            _db.SaveChanges();
            return View();
        }
    }
}