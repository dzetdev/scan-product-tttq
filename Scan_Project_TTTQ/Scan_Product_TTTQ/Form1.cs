using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Scan_Product_TTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;

        VideoCaptureDevice videoCaptureDevice;

        private void btn_start_Click(object sender, EventArgs e)
        {

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cb_list_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                tb_result.Invoke(new MethodInvoker(delegate ()
                {
                    tb_result.Text = result.ToString();
                }));
            }
            pb_camera.Image = bitmap;
            


        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
                pb_camera.Image = null;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
                pb_camera.Image = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cb_list_camera.Items.Add(filterInfo.Name);
            }

        }
    }
}
