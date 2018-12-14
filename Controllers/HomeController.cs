using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using emphasys.Models;
using Microsoft.AspNetCore.Mvc;

namespace emphasys.Controllers {

    public class HomeController : Controller {
        private readonly List<string> _wordsExceptions;

        public HomeController () {
            _wordsExceptions = new List<string> ();
            _wordsExceptions.Add ("a");
            _wordsExceptions.Add ("e");
            _wordsExceptions.Add ("i");
            _wordsExceptions.Add ("o");
            _wordsExceptions.Add ("u");
            _wordsExceptions.Add ("ao");
            _wordsExceptions.Add ("mais");
            _wordsExceptions.Add ("que");
            _wordsExceptions.Add ("para");
            _wordsExceptions.Add ("com");
            _wordsExceptions.Add ("estão");
            _wordsExceptions.Add ("como");
            _wordsExceptions.Add ("fim");
            _wordsExceptions.Add ("dos");
            _wordsExceptions.Add ("do");
            _wordsExceptions.Add ("em");
            _wordsExceptions.Add ("as");
            _wordsExceptions.Add ("na");
            _wordsExceptions.Add ("de");
            _wordsExceptions.Add ("os");
            _wordsExceptions.Add ("já");
            _wordsExceptions.Add ("um");
            _wordsExceptions.Add ("da");
            _wordsExceptions.Add ("no");
        }

        private List<BlogBestWordViewModel> ListBestWords (List<BlogBestWordViewModel> bestWords, string wordRequest) {
            var words = wordRequest.Split (' ');

            foreach (var word in words) {
                if (string.IsNullOrEmpty (word.Trim()) || _wordsExceptions.Any (x => x == word.ToLower()))
                    continue;

                var wordInBestWords = bestWords.FirstOrDefault (x => x.Word == word.ToLower());
                if (wordInBestWords == null) {
                    bestWords.Add (new BlogBestWordViewModel { Word = word.ToLower(), Quantity = 1 });
                } else {
                    wordInBestWords.Quantity += 1;
                }
            }

            return bestWords;
        }

        public IActionResult Index () {
            XElement xml = XElement.Load ("https://www.minutoseguros.com.br/blog/feed/");
            var channel = xml.Element ("channel");

            BlogViewModel blog = new BlogViewModel ();
            blog.Title = channel.Element ("title").Value;
            blog.Description = channel.Element ("description").Value;
            blog.BlogItens = new List<BlogItemViewModel> ();
            blog.LastBuildDate = Convert.ToDateTime (channel.Element ("lastBuildDate").Value);
            blog.BestWords = new List<BlogBestWordViewModel> ();

            foreach (var item in channel.Elements ("item").OrderByDescending (x => Convert.ToDateTime (x.Element ("pubDate").Value)).Take (10)) {
                BlogItemViewModel blogItem = new BlogItemViewModel ();
                blogItem.BestWords = new List<BlogBestWordViewModel> ();
                blogItem.Title = item.Element ("title").Value;
                blogItem.Link = item.Element ("link").Value;
                blogItem.PubDate = Convert.ToDateTime (item.Element ("pubDate").Value);
                blogItem.Description = item.Element ("description").Value;
                // blogItem.Image = item.Value.Split (new string[] { "img" }, StringSplitOptions.None) [1].Split (new string[] { "src=\"" }, StringSplitOptions.None) [1].Split (new string[] { "\"" }, StringSplitOptions.None) [0];
                blogItem.Categories = new List<string> ();
                foreach (var category in item.Elements ("category")) {
                    blogItem.Categories.Add (category.Value);
                    blogItem.BestWords = ListBestWords (blogItem.BestWords, category.Value);
                    blog.BestWords = ListBestWords (blog.BestWords, category.Value);
                }

                // adiciona as melhores palavras para o item e para o total
                blogItem.BestWords = ListBestWords (blogItem.BestWords, blogItem.Title);
                blogItem.BestWords = ListBestWords (blogItem.BestWords, blogItem.Title);
                blog.BestWords = ListBestWords (blog.BestWords, blogItem.Title);
                blog.BestWords = ListBestWords (blog.BestWords, blogItem.Title);

                blog.BlogItens.Add (blogItem);
            }

            return View (blog);
        }
    }
}