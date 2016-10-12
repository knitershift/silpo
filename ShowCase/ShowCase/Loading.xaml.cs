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
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Threading;

namespace ShowCase
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        BitmapSource _source;

        public Loading()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window_Loaded);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"/loading.gif", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            imBackGround.Source = bi;

            _source = GetSource();
            imBackGround.Source = _source;
            ImageAnimator.Animate(_bitmap, OnFrameChanged);
        }

        Bitmap _bitmap;

        private BitmapSource GetSource()
        {
            if (_bitmap == null)
            {
                _bitmap = new Bitmap("loadingloading.gif");
            }
            IntPtr handle = IntPtr.Zero;
            handle = _bitmap.GetHbitmap();
            return Imaging.CreateBitmapSourceFromHBitmap(
                    handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

        private void FrameUpdatedCallback()
        {
            ImageAnimator.UpdateFrames();
            if (_source != null)
                _source.Freeze();
            _source = GetSource();
            imBackGround.Source = _source;
            InvalidateVisual();
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                                    new Action(FrameUpdatedCallback));
        }

    }
}
