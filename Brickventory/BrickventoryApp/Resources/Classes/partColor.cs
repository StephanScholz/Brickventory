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

namespace BrickInventory
{
    /// <summary>
    /// Farbe des Legosteines
    /// </summary>
    class partColor
    {
        private string id;
        private string name;
        private string rgb;
        private bool is_trans;
        //optional:
        private externalID[] external_ids;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Rgb
        {
            get
            {
                return rgb;
            }

            set
            {
                rgb = value;
            }
        }

        public bool Is_trans
        {
            get
            {
                return is_trans;
            }

            set
            {
                is_trans = value;
            }
        }

        internal externalID[] External_ids
        {
            get
            {
                return external_ids;
            }

            set
            {
                external_ids = value;
            }
        }
    }
}