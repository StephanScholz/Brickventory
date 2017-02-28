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

namespace BrickInventory.Classes
{
    class necessaryParts
    {
        private buildOption bOption;
        private int totalParts;
        private int num_ignored;
        private int num_owned_less_ignored;
        private int total_parts_less_ignored;
        private float pct_owned;
        private int num_missing;

        internal buildOption BOption
        {
            get
            {
                return bOption;
            }

            set
            {
                bOption = value;
            }
        }

        public int TotalParts
        {
            get
            {
                return totalParts;
            }

            set
            {
                totalParts = value;
            }
        }

        public int Num_ignored
        {
            get
            {
                return num_ignored;
            }

            set
            {
                num_ignored = value;
            }
        }

        public int Num_owned_less_ignored
        {
            get
            {
                return num_owned_less_ignored;
            }

            set
            {
                num_owned_less_ignored = value;
            }
        }

        public int Total_parts_less_ignored
        {
            get
            {
                return total_parts_less_ignored;
            }

            set
            {
                total_parts_less_ignored = value;
            }
        }

        public float Pct_owned
        {
            get
            {
                return pct_owned;
            }

            set
            {
                pct_owned = value;
            }
        }

        public int Num_missing
        {
            get
            {
                return num_missing;
            }

            set
            {
                num_missing = value;
            }
        }
    }
}