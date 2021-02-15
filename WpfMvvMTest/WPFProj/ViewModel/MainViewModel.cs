using System;
using System.Collections.Generic;
using System.Text;
using WPFProj.State.Navigators;

namespace WPFProj.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator navigator { get; set; } = new Navigator();
    }
}
