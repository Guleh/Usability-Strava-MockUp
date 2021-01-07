using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StravaUsability.PageModels
{
    public class StopPageModel : FreshBasePageModel
    {
        public Command SaveCommand { get; set; }


        public StopPageModel()
        {
            SaveCommand = new Command(Save);
        }


        public void Save()
        {
            CoreMethods.PushPageModel<FeedPageModel>();
        }
    }
}
