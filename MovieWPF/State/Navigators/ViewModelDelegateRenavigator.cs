﻿using MovieWPF.ViewModels;
using MovieWPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWPF.State.Navigators
{
    public class ViewModelDelegateRenavigator<TViewModel> : IRenavigator where TViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly CreateViewModel<TViewModel> _createViewModel;



        public ViewModelDelegateRenavigator(INavigator navigator, CreateViewModel<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _createViewModel();
        }

    }

}
