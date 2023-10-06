using System.Collections.ObjectModel;

namespace EstateZoningApp.Core.Models.Abstracts;
public class SimpleShape: BaseModel
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

    public ObservableCollection<SimplePoint> Points
    {
        get; set;
    }
}
