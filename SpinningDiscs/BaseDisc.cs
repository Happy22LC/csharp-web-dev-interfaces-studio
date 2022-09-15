using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    abstract public class BaseDisc
    {
        public string Name { get; }
        public double StorageCapacity { get; }
        public bool Audio { get; }
        public bool Video { get; }

        public BaseDisc(string name, double storageCapacity, bool audio, bool video)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Audio = audio;
            Video = video;
        }
    }
}
