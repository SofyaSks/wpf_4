using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_changed_
{
    class Options : INotifyPropertyChanged
    {
        private int musicVolume;
        public int MusicVolume
        {
            get { return musicVolume; }
            set
            {
                musicVolume = value;
                //if (PropertyChanged != null)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MusicVolume)));
            }
        }

        private int soundVolume;
        public int SoundVolume
        {
            get => soundVolume;
            set
            {
                soundVolume = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SoundVolume)));
            }
        }

        private int fullScreenValue;
        public int IsFullScreen {
            get => fullScreenValue;
            set
            {
                soundVolume = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(fullScreenValue)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
