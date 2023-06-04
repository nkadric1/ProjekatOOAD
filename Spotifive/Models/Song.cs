using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Google.Apis.YouTube.v3.Data;
using System.Linq;

namespace Spotifive.Models
{
    public class Song
    {
        [Key] public int ID { get; set; }
        public string SongName { get; set; }
        public DateTime? DateRelease { get; set; }
        public Genre Genre { get; set; }    
        public string CodeQR { get; set; }
        public string LinkYT { get; set; }
        public string DriveLink { get; set; }
        public string Image { get; set; }
        public Artist Artist { get; set; }
        public Song() { }

        public List<Review> Reviews { get; set; }

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
            // Example video URLs: https://www.youtube.com/watch?v=VIDEO_ID
            //                     https://youtu.be/VIDEO_ID
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
            commentThreadsRequest.MaxResults = 5;  //MaxResuls

            var commentThreadsResponse = commentThreadsRequest.Execute();

            List<YouTubeComment> comments = new List<YouTubeComment>();

            List<Review> reviews = new List<Review>();
            foreach (var item in commentThreadsResponse.Items)
            {
                string comment = item.Snippet.TopLevelComment.Snippet.TextDisplay;
                var review = new Review { Comment = comment };
                reviews.Add(review);

                //comments.Add(new YouTubeComment { Comment = comment });
            }

            return reviews;

            /* foreach (var comment in comments)
             {
                 var review = new Review { Comment = comment.Text };
                 Reviews.Add(review);
             }*/
        }
    }
}
