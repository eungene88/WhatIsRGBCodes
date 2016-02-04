using System;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;



namespace WhatIsRGBCodes
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private int x, y;
        public MainWindow()
        {
            InitializeComponent();
            txtPointX.Text = "1";
            txtPointY.Text = "1";
        }

        private System.Drawing.Color ScreenColor(int x, int y)
        { // 스크린 Color값을 가져온다.
            System.Drawing.Size sz = new System.Drawing.Size(1, 1);
            Bitmap bmp = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(x, y, 0, 0, sz);

            return bmp.GetPixel(0, 0);
        }

        private void txtPointY_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            System.Drawing.Color RGBCodes;



            x = Convert.ToInt32(txtPointX.Text);
            y = Convert.ToInt32(txtPointY.Text);

            RGBCodes = ScreenColor(x, y);

            txtResult.Text = "Red   : " + RGBCodes.R.ToString() + Environment.NewLine;
            txtResult.Text += "Green : " + RGBCodes.G.ToString() + Environment.NewLine;
            txtResult.Text += "Blue  : " + RGBCodes.B.ToString() + Environment.NewLine;
        }

        private void txtPointX_TextChanged(object sender, TextChangedEventArgs e)
        {
        }


    }
}
