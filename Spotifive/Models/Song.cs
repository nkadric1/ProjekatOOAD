using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using System.IO;
using YoutubeExplode.Videos.Streams;
using static System.Net.Mime.MediaTypeNames;
using YoutubeExtractor;
using System.Net;
using System.Net.Http;
using Spotifive.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string SongName { get; set; }
        public DateTime? DateRelease { get; set; }
		[EnumDataType(typeof(Genre))]
		public Genre Genre { get; set; }    
        public string CodeQR { get; set; }
        public string LinkYT { get; set; }
        public string DriveLink { get; set; }
        public string Image { get; set; }
	
		public Song() { }
		public List<Review> Reviews { get; set; }
		public Review Review;

		public Artist Artist;
		public void PopulateReviews(string apiKey)
		{
			// Call the GetComments method to retrieve the reviews
			List<Review> reviews = GetComments(apiKey);

			// Assign the reviews to the Reviews property
			Reviews = reviews;
		}

		//Object YouTubeComment
		public class YouTubeComment
		{
			public string Comment { get; set; }

		}
		//obtained api key
		string apiKey = "AIzaSyDGuW4OZgNlerudPj8I6uSCwyD2uUhY74I";

		//method for videoId extraction
		public string ExtractVideoIdFromUrl(string videoUrl)
		{
			// Extract the video ID from the YouTube video URL
			
			var uri = new Uri(videoUrl);
			var queryParams = System.Web.HttpUtility.ParseQueryString(uri.Query);
			var videoId = queryParams["v"] ?? uri.Segments[uri.Segments.Length - 1];

			return videoId;
		}


		//method for obtaining a list of yt comments using yt api 

		public List<Review> GetComments(string apiKey)
		{
			YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
			{
				ApiKey = apiKey,
			});

			string videoId = ExtractVideoIdFromUrl(LinkYT);  //url

			var commentThreadsRequest = youtubeService.CommentThreads.List("snippet");
			commentThreadsRequest.VideoId = videoId;
			commentThreadsRequest.MaxResults = 5;  //MaxResults

			var commentThreadsResponse = commentThreadsRequest.Execute();

			List<YouTubeComment> comments = new List<YouTubeComment>();

			List<Review> reviews = new List<Review>();
			foreach (var item in commentThreadsResponse.Items)
			{
				string comment = item.Snippet.TopLevelComment.Snippet.TextDisplay;
				var review = new Review { Comment = comment };
				reviews.Add(review);

			}

			return reviews;

		
		}

		public void SaveMP3()
			{
			string url = DriveLink; // Replace with the actual URL of the MP3 file


				using (WebClient client = new WebClient())
				{
					try
					{
					string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
					// Download the MP3 file and save it to a local path
					string endpath = SongName + ".mp3";
					string filePath = Path.Combine(downloadFolderPath, endpath);
					client.DownloadFile(url, filePath);
					Console.WriteLine("File downloaded successfully.");
				}
					catch (Exception ex)
					{
						Console.WriteLine("Error downloading file: " + ex.Message);
					}
				}
			}


		public string GetFormattedDateRelease()
		{
			if (DateRelease.HasValue)
			{
				return DateRelease.Value.ToShortDateString();
			}

			return string.Empty;
		}

		public List<Review> GetCriticReviews(ApplicationDbContext context)
		{
			return context.Review.Where(r => r.SongID == ID).ToList();
		}


		public Artist GetArtist(DbContext context)
		{
			var artistSong = context.Set<ArtistSongs>().FirstOrDefault(r => r.SongID == this.ID);
			if (artistSong != null)
			{
				var artist = context.Set<Artist>().FirstOrDefault(a => a.ID == artistSong.ArtistID);
				Artist = artist;
				return artist;
			}
			return null; // or handle the case when artist is not found
		}

	}

}

