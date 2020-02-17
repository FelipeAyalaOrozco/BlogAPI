using BlogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Repositories
{
    public class PostRepository
    {
        private List<PostModel> Posts = new List<PostModel>()
        {
            new PostModel {id= 1, title = "Hello", date = "04/20/2020", userId= 1},
            new PostModel {id= 2, title = "Good morning", date = "04/19/2019", userId= 2},
            new PostModel {id= 12, title = "Hi", date = "04/20/2016", userId= 1},
            new PostModel {id= 24, title = "Good night", date = "04/21/2019", userId= 3}
        };




        public List<PostModel> GetPosts()
        {
            return Posts;
        }

        public String AddPosts(PostModel postmodel)
        {
            Posts.Add(postmodel);
            return "Post added successfully";
        }
        public String EditPosts(int id, PostModel postmodel)
        {
            int i = 0, d = 0;
            foreach (PostModel s in Posts)
            {
                if (s.id == id)
                {
                    d = i;
                }
                i++;
            }
            Posts[d] = postmodel;
            return "post edited successfully";
        }
        public String DeletePosts(int id)
        {
            int i = 0, d = 0;
            foreach (PostModel s in Posts)
            {
                if (s.id == id)
                {
                    d = i;
                }
                i++;
            }
            Posts.RemoveAt(d);
            return "Post removed successfully";
        }
    }
}
