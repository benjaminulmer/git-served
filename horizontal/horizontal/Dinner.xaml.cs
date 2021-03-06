﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace horizontal
{
    /// <summary>
    /// Interaction logic for Dinner.xaml
    /// </summary>
    public partial class Dinner : UserControl
    {
        InfoSirloin sirloin;
        InfoCaesarSalad salad;
        InfoSalmon salmon;

        public Dinner()
        {
            InitializeComponent();
            sirloin = new InfoSirloin(this);
            salad = new InfoCaesarSalad(this);
            salmon = new InfoSalmon(this);
        }

        private void ButtonTopSirloin_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Add(sirloin);
            (this.Parent as Panel).Children.Remove(this);
        }

        private void ButtonSalad_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Add(salad);
            (this.Parent as Panel).Children.Remove(this);
        }

        private void ButtonSalmon_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Add(salmon);
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
