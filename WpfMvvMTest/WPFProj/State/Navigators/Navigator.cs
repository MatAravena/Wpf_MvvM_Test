using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFProj.ViewModel;
using WPFProj.Command;
using System.ComponentModel;
using WPFProj.Models;

namespace WPFProj.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase currentViewModel {

            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                onPropertyChanged(nameof(currentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}