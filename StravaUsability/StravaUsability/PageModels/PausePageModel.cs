using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StravaUsability.PageModels
{
    public class PausePageModel : FreshBasePageModel
    {
        public Command StopCommand { get; set; }
        public Command AlertCommand { get; set; }
        public Command ResumeCommand { get; set; }


        public PausePageModel()
        {
            ResumeCommand = new Command(Resume);
            StopCommand = new Command(Stop);
            AlertCommand = new Command(Alert);
        }
        public async void Alert()
        {
            if (await CoreMethods.DisplayAlert("Discard run?", "This run has not been saved, discard run?", "Yes, discard this run", "No, go back")) {
                await CoreMethods.PushPageModel<FeedPageModel>();
            };
        }

        public void Stop()
        {
            CoreMethods.PushPageModel<StopPageModel>();
        }

        public void Resume()
        {
            CoreMethods.PushPageModel<RunningPageModel>();
        }
    }
}
