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
    /// Ermöglicht das Speichern von Legosteinfarbinformationen von externen Seiten wie zum Beispiel
    /// Bricklink, Brickowl und weiteren Seiten.
    /// Wird in der Klasse "partColor als Listen-Eigenschaft verwendet.
    /// </summary>
    class externalID
    {
        private string name;
        private string description;
        private string external_id;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string External_id
        {
            get
            {
                return external_id;
            }

            set
            {
                external_id = value;
            }
        }
    }
}