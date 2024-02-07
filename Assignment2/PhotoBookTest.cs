using System.Text;

namespace Assignment2
{
    class PhotoBookTest
    {
        private static void Main(string[] args)
        {
            var photobook = new PhotoBook();
            Console.WriteLine("photobook has {0} pages", photobook.GetNumberPages());

            var photobook2 = new PhotoBook(24);
            Console.WriteLine("photobook2 has {0} pages", photobook2.GetNumberPages());

            var largePhotobook = new BigPhotoBook();
            Console.WriteLine("large photobook has {0} pages", largePhotobook.GetNumberPages());

            Console.ReadLine();
        }
    }
}
