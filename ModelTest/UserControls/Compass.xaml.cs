using System;
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

namespace ModelTest.UserControls
{
    /// <summary>
    /// Compass.xaml の相互作用ロジック
    /// </summary>
    public partial class Compass : UserControl
    {
        public static readonly DependencyProperty ScaleProperty = DependencyProperty.Register(
            "Scale", typeof(double), typeof(Compass), new PropertyMetadata(1.0));
        public static readonly DependencyProperty AngleProperty = DependencyProperty.Register(
            "Angle", typeof(double), typeof(Compass), new PropertyMetadata(90.0));

        public double Scale
        {
            get => (double)GetValue(ScaleProperty);
            set => SetValue(ScaleProperty, value);
        }

        public double Angle
        {
            get => (double)GetValue(AngleProperty);
            set => SetValue(AngleProperty, value);
        }

        public Compass()
        {
            InitializeComponent();
        }
    }
}
