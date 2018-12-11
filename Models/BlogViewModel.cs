using System;
using System.Collections.Generic;

namespace emphasys.Models {
    public class BlogViewModel {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime LastBuildDate { get; set; }

        public List<BlogItemViewModel> BlogItens { get; set; }

        public List<BlogBestWordViewModel> BestWords { get; set; }
    }
}