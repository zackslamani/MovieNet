using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieWPF.State.Navigators;

namespace MovieWPF.ViewModels.Factories
{
    public interface IMovieNetViewModelFactory

    {

        ViewModelBase CreateViewModel(ViewType viewType);

    }

}