using System.Collections.ObjectModel;
using EstateZoningApp.Core.Models.Abstracts;

namespace EstateZoningApp.Core.Models;
public class Project: BaseModel
{
    public Project()
    {
    }

    public int Id
    {
        get;
        set;
    }

    string _Name;
    public string Name
    {
        get => _Name;
        set
        {
            if (_Name != value)
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    double _DimensionA;
    public double DimensionA
    {
        get => _DimensionA;
        set
        {
            if (_DimensionA != value)
            {
                _DimensionA = value;
                OnPropertyChanged(nameof(DimensionA));
            }
        }
    }

    double _DimensionB;
    public double DimensionB
    {
        get => _DimensionB;
        set
        {
            if (_DimensionB != value)
            {
                _DimensionB = value;
                OnPropertyChanged(nameof(DimensionB));
            }
        }
    }

    public ObservableCollection<SimplePoint> Elements
    {
        get;
        set;
    }

    public ObservableCollection<SimpleShape> Shapes
    {
        get;
        set;
    }
}
