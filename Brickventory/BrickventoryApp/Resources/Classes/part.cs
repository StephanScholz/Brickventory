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
    /// Das Legoteil / der Legobaustein
    /// </summary>
    class part
    {
        private string part_num;
        private string name;
        private string part_cad_id;
        private string part_url;
        private string part_img_url;

        public string Part_num
        {
            get
            {
                return part_num;
            }

            set
            {
                part_num = value;
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

        public string Part_cad_id
        {
            get
            {
                return part_cad_id;
            }

            set
            {
                part_cad_id = value;
            }
        }

        public string Part_url
        {
            get
            {
                return part_url;
            }

            set
            {
                part_url = value;
            }
        }

        public string Part_img_url
        {
            get
            {
                return part_img_url;
            }

            set
            {
                part_img_url = value;
            }
        }
    }
}