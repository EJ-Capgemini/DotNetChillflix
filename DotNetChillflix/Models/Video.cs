﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetChillflix.Models {
    public class Video {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
    }
}