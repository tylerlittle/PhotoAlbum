using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhotoAlbum
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            if (ArgumentChecker.HasInvalidArgs(args)) return;
            var albumId = args[0];
            var photos = await RetrievePhotos(albumId);
            WritePhotosToConsole(photos, albumId);
        }

        private static async Task<List<Photo>> RetrievePhotos(string albumId)
        {
            string response = await httpClient.GetStringAsync($"https://jsonplaceholder.typicode.com/photos?albumId={albumId}");
            return CreatePhotos(response);
        }

        private static List<Photo> CreatePhotos(string photoResponse)
        {
            return JsonConvert.DeserializeObject<List<Photo>>(photoResponse);
        }

        private static void WritePhotosToConsole(List<Photo> photos, string albumId)
        {
            if (photos.Count == 0)
            {
                Console.WriteLine("No photos found for album id {0}.", albumId);
                return;
            }

            foreach (Photo photo in photos)
            {
                Console.WriteLine("[{0}] {1}", photo.Id, photo.Title);
            }
        }
    }
}