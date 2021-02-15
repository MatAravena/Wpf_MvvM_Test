using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFProj.State.Navigators;
using WPFProj.ViewModel;
using static WPFProj.State.Navigators.INavigator;

namespace WPFProj.Command
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.currentViewModel = new HomeVM();
                        break;
                    case ViewType.Portfolio:
                        _navigator.currentViewModel = new PortfolioVM();
                        break;
                    case ViewType.Buy:
                        break;
                    case ViewType.Sell:
                        break;
                }
            }
        }
    }
}