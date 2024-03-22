using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Scan_Product_TTTQ
{
    public partial class Cart : Form
    {
        private readonly HttpClient httpClient;

        public Cart()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }
        Scan_Product_TTTQ.Cart.ProductDTO productDTO = new Scan_Product_TTTQ.Cart.ProductDTO();
        FilterInfoCollection filterInfoCollection;

        VideoCaptureDevice videoCaptureDevice;

        private void lb_title_Click(object sender, EventArgs e)
        {

        }

      


        private void btn_openCam_Click(object sender, EventArgs e)
        {
            if (cb_camera.SelectedIndex >= 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("Please select a camera.");
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                Invoke(new MethodInvoker(async () =>
                {
                    tb_result.Text = result.Text;
                  // await GetProductByBarcode(result.Text);
                }));
            }
            pb_camera.Image = bitmap;
        }



        /*private async Task GetProductByBarcode(string barcode)
        {
            try
            {
                var response = await httpClient.GetAsync($"http://localhost:6868/api/Product/GetProductByBarcode?Barcode={barcode}");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                // Chuyển đổi JSON thành đối tượng sản phẩm
                var product = JsonConvert.DeserializeObject<ProductDTO>(responseBody);

                // Thêm sản phẩm vào danh sách sản phẩm
                productList.Add(product);

                // Hiển thị sản phẩm trong ListView
                DisplayProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DisplayProducts()
        {
            // Xóa tất cả các mục trong ListView
            lv_product.Items.Clear();

            // Duyệt qua danh sách sản phẩm và thêm vào ListView
            foreach (var product in productList)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
            product.Name,
            product.Description,
            product.Price.ToString(),
            product.Quantity.ToString(),
            product.Barcode,
            product.Image,
            product.Id
                });

                // Thêm item vào ListView
                lv_product.Items.Add(item);
            }
        }*/


        private void Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
                pb_camera.Image = null;
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cb_camera.Items.Add(filterInfo.Name);
            }
        }

        private class ProductDTO
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal? Price { get; set; }
            public int? Quantity { get; set; }
            public Guid CategoryId { get; set; }
            public string Barcode { get; set; }
            public string Image { get; set; }
        }
    }
}
