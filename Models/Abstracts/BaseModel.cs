using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EstateZoningApp.Core.Models.Abstracts;
public abstract class BaseModel: INotifyPropertyChanged, INotifyPropertyChanging
{
    protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected void OnPropertyChanging([CallerMemberName] String propertyName = "")
    {
        PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
    }

    public event PropertyChangingEventHandler PropertyChanging;
    public event PropertyChangedEventHandler PropertyChanged;
}
