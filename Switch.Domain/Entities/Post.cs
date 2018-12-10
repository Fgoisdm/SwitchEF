using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Post
    {

        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public string Text { get; set; }

    }
}
