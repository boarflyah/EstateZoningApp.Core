
namespace EstateZoningApp.Core.Models.Abstracts;
public abstract class SimplePoint : BaseModel
{
    protected SimplePoint()
    {
    }

    public int Id
    {
        get;
        set;
    }

    double _X;
    public double X
    {
        get => _X;
        set
        {
            if (_X != value)
            {
                OnPropertyChanging(nameof(X));
                _X = value;
                OnPropertyChanged(nameof(X));
            }
        }
    }

    double _Y;
    public double Y
    {
        get => _Y;
        set
        {
            if (_Y != value)
            {
                OnPropertyChanging(nameof(Y));
                _Y = value;
                OnPropertyChanged(nameof(Y));
            }
        }
    }

    int _IconId;
    public int IconId
    {
        get => _IconId;
        set
        {
            if (_IconId != value)
            {
                OnPropertyChanging(nameof(IconId));
                _IconId = value;
                OnPropertyChanged(nameof(IconId));
            }
        }
    }
}
