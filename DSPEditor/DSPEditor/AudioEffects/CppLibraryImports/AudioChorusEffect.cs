﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSPEditor.AudioEffects
{
    class AudioChorusEffect
    {
        [DllImport("DSPAudioEffects.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ChorusInit(double rate, double width);

        [DllImport("DSPAudioEffects.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ChorusProcess(float inval);
    }
}
