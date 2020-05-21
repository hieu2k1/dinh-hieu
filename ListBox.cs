using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03
{
    class ListBox : Window
    {
        public ListBox(int top, int left, string contents): base(top, left)
        {
            ListBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow(); 
            Console.WriteLine("Writing string to the listbox:{0}",
            ListBoxContents);
        }
        private string ListBoxContents;
    }
}
