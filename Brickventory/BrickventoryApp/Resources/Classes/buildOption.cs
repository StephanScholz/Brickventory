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
    /// <summary>
    /// Wird als Eigenschaft für eine Abfrage bzgl der vorhandenen / noch benötigten Teile für ein bestimmtes Set in der Klasse "necessaryParts" benutzt.
    /// </summary>
    class buildOption
    {
        private string theme;
        private bool inc_accessory;
        private bool ignore_minifigs;
        private bool inc_owned;
        private bool inc_premium;
        private int max_parts;
        // ???
        private int color;
        private int max_year;
        private bool inc_custom;
        private bool ignore_altp;
        private bool ignore_mold;
        // ??? 
        private int sorty_by;
        private bool ignore_print;
        private bool ignore_non_lego;
        private bool inc_official;
        private bool inc_models;

        public string Theme
        {
            get
            {
                return theme;
            }

            set
            {
                theme = value;
            }
        }

        public bool Inc_accessory
        {
            get
            {
                return inc_accessory;
            }

            set
            {
                inc_accessory = value;
            }
        }

        public bool Ignore_minifigs
        {
            get
            {
                return ignore_minifigs;
            }

            set
            {
                ignore_minifigs = value;
            }
        }

        public bool Inc_owned
        {
            get
            {
                return inc_owned;
            }

            set
            {
                inc_owned = value;
            }
        }

        public bool Inc_premium
        {
            get
            {
                return inc_premium;
            }

            set
            {
                inc_premium = value;
            }
        }

        public int Max_parts
        {
            get
            {
                return max_parts;
            }

            set
            {
                max_parts = value;
            }
        }

        public int Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Max_year
        {
            get
            {
                return max_year;
            }

            set
            {
                max_year = value;
            }
        }

        public bool Inc_custom
        {
            get
            {
                return inc_custom;
            }

            set
            {
                inc_custom = value;
            }
        }

        public bool Ignore_altp
        {
            get
            {
                return ignore_altp;
            }

            set
            {
                ignore_altp = value;
            }
        }

        public bool Ignore_mold
        {
            get
            {
                return ignore_mold;
            }

            set
            {
                ignore_mold = value;
            }
        }

        public int Sorty_by
        {
            get
            {
                return sorty_by;
            }

            set
            {
                sorty_by = value;
            }
        }

        public bool Ignore_print
        {
            get
            {
                return ignore_print;
            }

            set
            {
                ignore_print = value;
            }
        }

        public bool Ignore_non_lego
        {
            get
            {
                return ignore_non_lego;
            }

            set
            {
                ignore_non_lego = value;
            }
        }

        public bool Inc_official
        {
            get
            {
                return inc_official;
            }

            set
            {
                inc_official = value;
            }
        }

        public bool Inc_models
        {
            get
            {
                return inc_models;
            }

            set
            {
                inc_models = value;
            }
        }
    }
}