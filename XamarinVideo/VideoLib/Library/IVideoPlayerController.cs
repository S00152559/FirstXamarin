using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLib.Library
{
    public interface IVideoPlayerController
    {
        VideoStatus Status { get; set; }

        TimeSpan Duration { get; set; }
    }
}
