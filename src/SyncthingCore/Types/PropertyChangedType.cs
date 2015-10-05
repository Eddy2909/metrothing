using System.Collections.Generic;
using System.ComponentModel;

// Marc Gravell @ http://stackoverflow.com/questions/1315621/implementing-inotifypropertychanged-does-a-better-way-exist

namespace SyncthingCore.Types
{
    public class PropertyChangedType : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}