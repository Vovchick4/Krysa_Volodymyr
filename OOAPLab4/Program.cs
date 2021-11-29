using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAPLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            adapter.MakeCall();
            Console.Read();
        }
        interface Phone
        {
            void MakeCall();
        }
	//Add comment
        class VideoCamera
        {
            public void UseVideo()
            {
                Console.WriteLine("Камера використовується при виклику");
            }
        }
        class Adapter : Phone
        {

            VideoCamera videoclass = new VideoCamera();
            public void MakeCall()
            {
                videoclass.UseVideo();
            }
        }
    }
}
