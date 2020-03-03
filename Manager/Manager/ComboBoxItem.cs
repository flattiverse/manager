using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ComboBoxItem
    {
        #region Properties
        public string Text { get; set; }
        public object Value { get; set; }
        #endregion

        #region Constructors
        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Text;
        }
        #endregion
    }
}
