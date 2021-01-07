using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StravaUsability.PageModels
{
    class RunningPageModel : FreshBasePageModel
    {
        public Command PauseCommand { get; set; }


        public RunningPageModel()
        {
            PauseCommand = new Command(Pause);
        }

        public void Pause()
        {
            CoreMethods.PushPageModel<PausePageModel>();
        }
    }
}
