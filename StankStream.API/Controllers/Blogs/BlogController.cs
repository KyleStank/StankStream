using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using StankStream.Domain.Services.Blogs;
using StankStream.Models.Blog;

namespace StankStream.API.Controllers.Blogs
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(
            ILogger<BlogController> logger,
            IBlogService blogService
        ) {
            _logger = logger;
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _blogService.GetBlog(id);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(await _blogService.GetBlog(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var model = new Blog();
            model.Url = "https://localhost:5001/test";

            var result = await _blogService.AddBlog(model);

            if (result == null)
            {
                return BadRequest();
            }
            
            return Ok(result);
        }
    }
}
