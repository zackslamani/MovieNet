using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieWPF.ViewModels;

namespace MovieWPF.State.Navigators
{

    public enum ViewType

    {
        Login,
        Home,
        Portfolio,
        Buy
    }



    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }

}
