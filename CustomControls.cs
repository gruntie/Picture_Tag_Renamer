using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanbooruNameTagger
{
    internal class CustomControls
    {
    }

    public class ListBoxEx : ListBox
    {
        public ListBoxEx() { }

        private const int LB_ADDSTRING = 0x180;
        private const int LB_INSERTSTRING = 0x181;
        private const int LB_DELETESTRING = 0x182;
        private const int LB_RESETCONTENT = 0x184;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == LB_ADDSTRING || m.Msg == LB_INSERTSTRING || m.Msg == LB_DELETESTRING || m.Msg == LB_RESETCONTENT)
            {
                ItemsChanged(this, EventArgs.Empty);
            }
            base.WndProc(ref m);
        }

        public event EventHandler ItemsChanged = delegate { };
    }

    /*public class AnotherListBox : ListBox
    {
        public AnotherListBox() { }

        private const int LB_ADDSTRING = 0x180;
        private const int LB_DELETESTRING = 0x182;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == LB_ADDSTRING)
            {
                ItemsAdded(this, EventArgs.Empty);
            }
            else if (m.Msg == LB_DELETESTRING)
            {
                ItemsRemoved(this, EventArgs.Empty);
            }
            base.WndProc(ref m);
        }

        public event EventHandler ItemsAdded = delegate { };
        public event EventHandler ItemsRemoved = delegate { };
    }*/
}
