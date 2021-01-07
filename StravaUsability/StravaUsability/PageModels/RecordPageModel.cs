using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StravaUsability.PageModels
{
    public class RecordPageModel : FreshBasePageModel
    {
        public Command StartCommand { get; set; }


        public RecordPageModel()
        {
            StartCommand = new Command(Start);
        }

        public void Start()
        {
            CoreMethods.PushPageModel<RunningPageModel>();
        }
    }
}
