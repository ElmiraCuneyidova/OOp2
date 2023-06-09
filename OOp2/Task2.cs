using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    interface IPlayable
    {
        void Play();
    }
    class MP3 : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("MP3");
        }
    }
    class WAV : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("WAV");
        }
    }
    class OGG : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("OGG");
        }
    }
}