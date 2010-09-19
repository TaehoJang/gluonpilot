﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Communication.Frames.Incoming;

namespace Configuration.NavigationCommands
{
    public partial class CircleAbs : UserControl, INavigationCommandViewer
    {
        private NavigationInstruction ni;

        public CircleAbs(NavigationInstruction ni)
        {
            InitializeComponent();

            this.ni = ni;
            _ce.SetCoordinateRad(ni.x, ni.y);
            _dtb_radius.DistanceM = ni.a;
            _dtb_height.DistanceM = ni.b;
        }

        #region INavigationCommandViewer Members

        public NavigationInstruction GetNavigationInstruction()
        {
            ni.x = _ce.GetLatitudeRad();
            ni.y = _ce.GetLongitudeRad();
            ni.a = (int)_dtb_radius.DistanceM;
            ni.b = (int)_dtb_height.DistanceM;
            return new NavigationInstruction(ni);
        }

        public void SetNavigationInstruction(NavigationInstruction ni)
        {
            this.ni = new NavigationInstruction(ni);
        }

        #endregion
    }
}
