using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinesauceBands.Models;

namespace VinesauceBands.Controllers
{
    public class VineBandController : Controller
    {
        private readonly VineBandFactory _context;
        public VineBandController(VineBandFactory context)
        {
            _context = context;
        }

        // VineBand/Vinny
        public ActionResult Redvox()
        {
            var band = _context.Bands.Find(1);

            var albums = _context.Albums.Where(x => x.BandID == band.BandID)
                .Include(i => i.Songs)
                .OrderBy(i => i.Year);


            return View(albums);
        }


        public ActionResult Vargskelethor()
        {
            var band = _context.Bands.Find(2);

            var albums = _context.Albums.Where(x => x.BandID == band.BandID)
                .Include(i => i.Songs)
                .OrderBy(i => i.Year);


            return View(albums);
        }

        public ActionResult Scythelord()
        {
            var band = _context.Bands.Find(3);

            var albums = _context.Albums.Where(x => x.BandID == band.BandID)
                .Include(i => i.Songs)
                .OrderBy(i => i.Year);


            return View(albums);
        }

        [HttpGet("Comments/{id}")]
        public ActionResult Comments(int id)
        {
            // Get Model
            var songComments = _context.Songs.Where(x => x.SongID == id)
                .Include(i => i.Comments).Single();

            // Average Rating
            if (songComments.Comments.Any())
            {
                ViewBag.avgRating = songComments.Comments.Select(x => x.rating).Average();
            }
            else
            {
                ViewBag.avgRating = "No Ratings submitted.";
            }
            


            return View(songComments);
        }

        [HttpPost("Comments/makeComment")]
        public RedirectResult makeComment([FromForm] IFormCollection commentForm)
        {
            int id = Int32.Parse(commentForm["song"]);
            string uname = commentForm["username"];
            int rate = Int32.Parse(commentForm["rating"]);
            string msg = commentForm["message"];
            
            var newComment = new Comment
            {
                Username = uname,
                rating = rate,
                Message = msg,
            };

            //_context.Comments.Add(newComment);


            var song = _context.Songs.Where(x => x.SongID == id).Single();

            if (song.Comments == null)
            {
                song.Comments = new List<Comment>();
            }

            song.Comments.Add(newComment);

            _context.SaveChanges();

            return new RedirectResult(url: "/Comments/" + commentForm["song"]);
        }
    }
}
