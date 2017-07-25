﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if WPF
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
#else
using Noesis;
using NoesisSample;
#endif

namespace NoesisWPF
{
    /// <summary>
    /// Interaction logic for MainHUD.xaml
    /// </summary>
    public partial class PlanetHUD : UserControl
    {
        public PlanetHUD()
        {
#if WPF
            InitializeComponent();
#else
            Noesis.GUI.LoadComponent(this, WaveContent.Assets.Xaml.PlanetHUD_xaml);
#endif
        }
    }
}
