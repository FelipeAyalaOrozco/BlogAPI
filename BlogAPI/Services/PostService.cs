using BlogAPI.Models;
using BlogAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class PostService
    {
        private PostRepository _postRepository;

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public List<PostModel> GetPosts()
        {
            return _postRepository.GetPosts();
        }

        public string AddPosts(PostModel postModel)
        {

            return _postRepository.AddPosts(postModel);
        }

        public string EditPosts(int id, PostModel postModel)
        {

            return _postRepository.EditPosts(id, postModel);
        }
        public string DeletePosts(int id)
        {

            return _postRepository.DeletePosts(id);
        }
    }
}
