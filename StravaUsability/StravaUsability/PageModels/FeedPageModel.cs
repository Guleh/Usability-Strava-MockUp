using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StravaUsability.PageModels
{
    public class FeedPageModel : FreshBasePageModel

    {
        public Command RecordCommand { get; set; }



        public FeedPageModel()
        {
            RecordCommand = new Command(Record);
        }

        public void Record()
        {
            CoreMethods.PushPageModel<RecordPageModel>();
        }
    }
}
