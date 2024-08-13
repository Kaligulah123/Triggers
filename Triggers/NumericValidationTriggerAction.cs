using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triggers
{
    public class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        public int MinValue { get; set; }
        protected override void Invoke(Entry sender)
        {           
            if (sender.Text == "valid")
            {
                sender.BackgroundColor = Colors.Green;
            }
            else
            {
                sender.BackgroundColor = Colors.White;
            }

        }
    }
}
