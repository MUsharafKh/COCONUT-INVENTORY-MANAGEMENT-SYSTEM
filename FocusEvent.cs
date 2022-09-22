using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Coco_Master
{
    public class FocusEvent
    {
        public string hint = "*";

        public void gotFocus(TextBox txt)
        {
            if (txt.Text == "*")
            {
                txt.HorizontalContentAlignment = HorizontalAlignment.Left;
                txt.Foreground = Brushes.Black;
                txt.BorderBrush = Brushes.Purple;
                txt.Text = "";
            }
        }

        public void lostFocus(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.HorizontalContentAlignment = HorizontalAlignment.Right;
                txt.Foreground = Brushes.Red;
                txt.BorderBrush = Brushes.Red;
                txt.Text = hint;
            }
        }

        public void clearText(TextBox txt)
        {
            txt.HorizontalContentAlignment = HorizontalAlignment.Right;
            txt.Foreground = Brushes.Red;
            txt.BorderBrush = Brushes.Purple;
            txt.Text = "*";
        }
    }
}
