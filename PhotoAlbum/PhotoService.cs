using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhotoAlbum
{
    public class PhotoService
    {
        private readonly HttpClient HttpClient = new HttpClient();
        private readonly string AlbumId;
        private List<Photo> Photos = new List<Photo>();

        public PhotoService(string albumId)
        {
            AlbumId = albumId;
        }

        public async Task RetrievePhotos()
        {
            string response = await HttpClient.GetStringAsync($"https://jsonplaceholder.typicode.com/photos?albumId={AlbumId}");
            CreatePhotos(response);
        }

        public void WritePhotosToConsole()
        {
            if (Photos.Count == 0)
            {
                Console.WriteLine("No photos found for album id {0}.", AlbumId);
                return;
            }

            foreach (Photo photo in Photos)
            {
                Console.WriteLine("[{0}] {1}", photo.Id, photo.Title);
            }
        }

        private void CreatePhotos(string photoResponse)
        {
            Photos = JsonConvert.DeserializeObject<List<Photo>>(photoResponse);
        }
    }
}
