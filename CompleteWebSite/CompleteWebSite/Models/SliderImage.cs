using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompleteWebSite.Models
{
    public class SliderImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public string UploadedBy { get; set; }

    }
}