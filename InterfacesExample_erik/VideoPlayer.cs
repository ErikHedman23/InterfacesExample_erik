using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample_erik
{
    public class VideoPlayer : IMediaPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Video is paused");
        }

        public void Play()
        {
            Console.WriteLine("Video is paused");
        }

        public void Stop()
        {
            Console.WriteLine("Video is stopped");
        }
    }
}
