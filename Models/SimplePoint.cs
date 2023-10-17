using System.ComponentModel.DataAnnotations.Schema;
using EstateZoningApp.Core.Models.Abstracts;

namespace EstateZoningApp.Core.Models;
public class SimplePoint : BaseModel
{
    public SimplePoint()
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
                _Y = value;
                OnPropertyChanged(nameof(Y));
            }
        }
    }

    double _Width;
    public double Width
    {
        get => _Width;
        set
        {
            if (_Width != value)
            {
                _Width = value;
                OnPropertyChanged(nameof(Width));
            }
        }
    }

    double _Height;
    public double Height
    {
        get => _Height;
        set
        {
            if (_Height != value)
            {
                _Height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
    }

    //nonpersistent
    double _Scale;
    [NotMapped]
    public double Scale
    {
        get => _Scale;
        set
        {
            if (_Scale != value)
            {
                _Scale = value;
                OnPropertyChanged(nameof(Scale));
                OnPropertyChanged(nameof(X));
                OnPropertyChanged(nameof(Y));
                OnPropertyChanged(nameof(Height));
                OnPropertyChanged(nameof(Width));
            }
        }
    }

    //SimplePoint _NextPoint;
    //[NotMapped]
    //public SimplePoint NextPoint
    //{
    //    get => _NextPoint;
    //    set
    //    {
    //        if (_NextPoint != value)
    //        {
    //            _NextPoint = value;
    //            OnPropertyChanged(nameof(NextPoint));
    //        }
    //    }
    //}

    ////association to icon model
    //int _IconId;
    //[NotMapped]
    //public int IconId
    //{
    //    get => _IconId;
    //    set
    //    {
    //        if (_IconId != value)
    //        {
    //            _IconId = value;
    //            OnPropertyChanged(nameof(IconId));
    //        }
    //    }
    //}

    string _ImagePath;
    public string ImagePath
    {
        get => _ImagePath;
        set
        {
            if (_ImagePath != value)
            {
                _ImagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }
    }

    //nonpersistent
    bool _IsSelected;
    [NotMapped]
    public bool IsSelected
    {
        get => _IsSelected;
        set
        {
            if (_IsSelected != value)
            {
                _IsSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }

    public virtual SimpleShape SimpleShape
    {
        get;
        set;
    }

    public virtual Project Project
    {
        get;
        set;
    }
}
