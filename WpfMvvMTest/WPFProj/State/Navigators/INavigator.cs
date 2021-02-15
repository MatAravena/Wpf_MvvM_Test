using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFProj.ViewModel;

namespace WPFProj.State.Navigators
{
    public enum ViewType
    {
        Home,
        Portfolio,
        Buy,
        Sell
    }

    public interface INavigator
    {

        ViewModelBase currentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
