using System.Collections.ObjectModel;
using EstateZoningApp.Core.Models.Abstracts;

namespace EstateZoningApp.Core.Models;
public class SimpleShape : BaseModel
{
    public SimpleShape()
    {
        Points = new();
    }

    public int Id
    {
        get; set;
    }

    string _Name;
    public string Name
    {
        get => _Name;
        set
        {
            if (_Name != value)
            {
                OnPropertyChanging(nameof(Name));
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    double _Scale;
    public double Scale
    {
        get => _Scale;
        set
        {
            if (_Scale != value)
            {
                _Scale = value;
                OnPropertyChanged(nameof(Scale));
                OnPropertyChanged(nameof(Points));
            }
        }
    }

    public virtual Project Project
    {
        get;
        set;
    }

    public ObservableCollection<SimplePoint> Points
    {
        get; set;
    }
}
