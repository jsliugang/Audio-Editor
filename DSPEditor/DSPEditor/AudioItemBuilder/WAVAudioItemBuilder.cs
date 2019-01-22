﻿using DSPEditor.Audio;
using NAudio.Wave;
using System.Diagnostics;

namespace DSPEditor.AudioItemBuilder
{
    public class WAVAudioItemBuilder : AudioBuilder, IAudioItemBuilder
    {

        public WAVAudioItemBuilder()
        {
            audioItem = new AudioItem();
        }

        public void SetFullPath(string filePath)
        {
            OpenAudioFile(filePath);
        }

        public void OpenAudioFile(string filePath)
        {
            using (AudioFileReader reader = new AudioFileReader(filePath))
            {
                Debug.Assert(reader.WaveFormat.BitsPerSample != 16, "Only works with 16 bit audio");
                var samples = new float[reader.Length / 2];
                reader.Read(samples, 0, samples.Length / 2);

                audioItem.AudioBuffer = samples;
                audioItem.FilePath = filePath;
            }
        }

    }
}
