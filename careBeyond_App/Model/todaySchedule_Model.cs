using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace careBeyond_App.Model
{
    class todaySchedule_Model
    {
        public string Client_Id { get; set; }
        public string ImageWebPath { get; set; }
        public string Client_name { get; set; }
        public string Service_date { get; set; }
        public string Service_time_start { get; set; }
        public string Service_time_end { get; set; }
        public string Service_status { get; set; }
    }
}