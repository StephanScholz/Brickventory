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
    class allParts
    {
        private List<part> parts;
        private List<partColor> partColors;

        internal List<part> Parts
        {
            get
            {
                return parts;
            }

            set
            {
                parts = value;
            }
        }

        internal List<partColor> PartColors
        {
            get
            {
                return partColors;
            }

            set
            {
                partColors = value;
            }
        }
    }
}