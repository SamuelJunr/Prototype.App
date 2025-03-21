using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace TesteApp.Core
{
    internal class ObservableObject : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;

        protected void NotifyPropertyChanging([CallerMemberName] string? Name = null)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(Name));
        }
    }


}
