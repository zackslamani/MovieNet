using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieWPF.State.Navigators;

namespace MovieWPF.ViewModels.Factories
{

      public class MovieNetViewModelFactory : IMovieNetViewModelFactory

    {

        private readonly CreateViewModel<HomeViewModel> _createHomeViewModel;

        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;



        public MovieNetViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel,
            CreateViewModel<LoginViewModel> createLoginViewModel)

        {
            _createHomeViewModel = createHomeViewModel;
            _createLoginViewModel = createLoginViewModel;
        }



        public ViewModelBase CreateViewModel(ViewType viewType)

        {

            switch (viewType)

            {

                case ViewType.Login:

                    return _createLoginViewModel();

                case ViewType.Home:

                    return _createHomeViewModel();

                case ViewType.Portfolio:

                    return _createPortfolioViewModel();

                case ViewType.Buy:

                    return _createBuyViewModel();

                default:

                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");

            }

        }

    }
}
