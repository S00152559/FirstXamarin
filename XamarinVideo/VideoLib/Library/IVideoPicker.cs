﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLib.Library
{
    public interface IVideoPicker
    {
        Task<string> GetVideoFileAsync();
    }
}
