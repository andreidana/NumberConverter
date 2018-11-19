using ConverterLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NumberConverter
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NumericConverter converter = new NumericConverter(Convert.ToInt32(DesiredBase.Text));
            ConvertedValue.Text = converter.Convert(Convert.ToInt32(NumberToConvert.Text));
        }
    }
}
