﻿using System.Collections.Generic;

namespace JsonPatchSample.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public virtual List<Post> Posts { get; }
    }
}
