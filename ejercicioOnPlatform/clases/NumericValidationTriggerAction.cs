using System;
using Xamarin.Forms;

namespace ejercicioOnPlatform.clases
{
    public class NumericValidationTriggerAction : TriggerAction<Entry>

    {
 
        protected override void Invoke(Entry entry)
        {
            double result;
            bool isValid = Double.TryParse(entry.Text, out result);
            entry.TextColor = isValid ? Color.Default : Color.Red;
            entry.BackgroundColor = isValid ? Color.Default : Color.White;
        }
    }
}
