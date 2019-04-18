using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesPost.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Content { get; set; }
    }
}
