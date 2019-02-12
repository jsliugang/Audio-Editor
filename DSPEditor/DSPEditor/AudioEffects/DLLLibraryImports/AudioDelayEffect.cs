﻿using DSPEditor.AudioEffects.CppLibraryImports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSPEditor.AudioEffects
{
    class AudioDelayEffect : AudioImportEffect
    {
        [DllImport("DSPAudioEffectsCpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DelayInit(double _feedbackLevel, double _delayLevel);

        [DllImport("DSPAudioEffectsCpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float DelayProcess(float in_sample, ref int time_elapsed);
    }
}
