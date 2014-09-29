﻿using System.Windows.Forms;

namespace CASCExplorer
{
    class NoFlickerListView : ListView
    {
        public NoFlickerListView()
        {
            DoubleBuffered = true;
        }

        public bool HasSingleSelection
        {
            get { return SelectedIndices.Count == 1; }
        }

        public bool HasSelection
        {
            get { return SelectedIndices.Count >= 1; }
        }

        public int SelectedIndex
        {
            get { return HasSingleSelection ? SelectedIndices[0] : -1; }
            set { SelectedIndices.Clear(); SelectedIndices.Add(value); }
        }
    }
}
