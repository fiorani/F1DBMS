using System;
using System.Windows.Forms;

namespace F1DBMS
{
    public static class Utilities
    {
        public static String assignValue(TextBox textBox)
        {
            return String.IsNullOrEmpty(textBox.Text) ? throw new Exception() : textBox.Text;
        }
    }
}
