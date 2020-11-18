using System;
using System.Collections.Generic;

namespace StankStream.Models.Blog
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
