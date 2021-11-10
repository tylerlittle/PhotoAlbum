using System.Threading.Tasks;

namespace PhotoAlbum
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (ArgumentChecker.HasInvalidArgs(args)) return;
            var photoService = new PhotoService(args[0]);
            await photoService.RetrievePhotos();
            photoService.WritePhotosToConsole();
        }
    }
}