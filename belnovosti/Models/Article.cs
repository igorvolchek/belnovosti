using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace belnovosti.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Paragraph { get; set; }
        public string Category { get; set; }
    }
}