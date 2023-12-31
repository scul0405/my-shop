﻿using GUI.Views;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using ThreeLayerContract;

namespace GUI
{
    public class DefaultGUI : IGUI
    {
        public override string GetVersion() => "Default";

        public DefaultGUI() { }

        public DefaultGUI(Dictionary<string, IBus> buses)
        {
            this._buses = buses;
        }

        public override IGUI CreateNew(Dictionary<string, IBus> buses)
        {
            return new DefaultGUI(buses);
        }

        public override UserControl GetMainWindow()
        {
            //throw new NotImplementedException();
            return new LoginPage(_buses);
            //TODO: LoginForm -> usercontrol
        }

        public override string ToString() => "DefaultGUI";
        
    }
}
