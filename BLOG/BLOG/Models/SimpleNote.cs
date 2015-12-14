﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOG.Models
{
    public class SimpleNote
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NoteBody { get; set; }
        public bool? IsPublic { get; set; }
    }
}