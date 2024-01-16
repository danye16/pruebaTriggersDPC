using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace pruebaTriggers
{
    public class ChangeColor : TriggerAction<Button>
    {
        protected override void Invoke(Button btn)
        {
            btn.BackgroundColor = Color.DarkOrange;
            btn.Text = "Holis";
        }
    }
}
