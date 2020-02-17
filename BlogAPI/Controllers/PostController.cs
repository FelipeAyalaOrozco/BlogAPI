using BlogAPI.Models;
using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PostController :ControllerBase
    {
        private PostService _postService;
        private readonly ILogger<PostController> _logger;
        public PostController(ILogger<PostController> logger,  PostService postService)
        {
            _postService = postService;
            _logger = logger;
        }


        [HttpGet]
        public List<PostModel> GetPosts()
        {
            return _postService.GetPosts();
        }

        [HttpGet("{id}", Name = "GetPost")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: /Post
        [HttpPost]
        public string Post([FromBody] PostModel post)
        {
            return _postService.AddPosts(post);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] PostModel post)
        {
            return _postService.EditPosts(id, post);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _postService.DeletePosts(id);
        }


    }
}
