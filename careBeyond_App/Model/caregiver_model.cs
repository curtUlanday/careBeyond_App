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
    class caregiver_model
    {
        public string caregiver_id { get; set; }
        public string caregiver_type { get; set; }
        public string caregiver_name { get; set; }
        public string caregiver_address { get; set; }
        public string caregiver_homePhone { get; set; }
        public string caregiver_mobilePhone { get; set; }
        public string caregiver_fax { get; set; }
        public string caregiver_category { get; set; }
    }
}