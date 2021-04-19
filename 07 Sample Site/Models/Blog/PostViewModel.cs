using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models.Blog
{
    public class PostViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public string Photo { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int CategoryId { get; set; }

        public string CategoryTitle { get; set; }

        public string CategorySlug
        {
            get
            {
                return $"_{CategoryId}";
            }
        }
    }
}