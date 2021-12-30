using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoalbums
{
    class AlbumTest
    {
        static void Main()
        {
            bool debug = false;

            
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

         
            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());

            if (debug)
                Console.ReadLine();
        }
    }
}
