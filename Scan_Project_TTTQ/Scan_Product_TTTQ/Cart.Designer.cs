namespace Scan_Product_TTTQ
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.lv_product = new System.Windows.Forms.ListView();
            this.lv_bill = new System.Windows.Forms.ListView();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_selectCam = new System.Windows.Forms.Label();
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.btn_openCam = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_title.Location = new System.Drawing.Point(463, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(349, 31);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Thanh toán cho khách hàng";
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // lv_product
            // 
            this.lv_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_product.HideSelection = false;
            this.lv_product.Location = new System.Drawing.Point(12, 109);
            this.lv_product.Name = "lv_product";
            this.lv_product.Size = new System.Drawing.Size(769, 587);
            this.lv_product.TabIndex = 1;
            this.lv_product.UseCompatibleStateImageBehavior = false;
            // 
            // lv_bill
            // 
            this.lv_bill.HideSelection = false;
            this.lv_bill.Location = new System.Drawing.Point(787, 392);
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(393, 304);
            this.lv_bill.TabIndex = 2;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(1105, 702);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 33);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(73, 83);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(231, 20);
            this.tb_search.TabIndex = 4;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(12, 86);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(55, 13);
            this.lb_search.TabIndex = 5;
            this.lb_search.Text = "Tìm kiếm :";
            // 
            // lb_selectCam
            // 
            this.lb_selectCam.AutoSize = true;
            this.lb_selectCam.Location = new System.Drawing.Point(784, 90);
            this.lb_selectCam.Name = "lb_selectCam";
            this.lb_selectCam.Size = new System.Drawing.Size(70, 13);
            this.lb_selectCam.TabIndex = 6;
            this.lb_selectCam.Text = "Chọn camera";
            // 
            // cb_camera
            // 
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(860, 83);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(320, 21);
            this.cb_camera.TabIndex = 7;
            // 
            // pb_camera
            // 
            this.pb_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_camera.Location = new System.Drawing.Point(787, 110);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(393, 224);
            this.pb_camera.TabIndex = 8;
            this.pb_camera.TabStop = false;
            // 
            // btn_openCam
            // 
            this.btn_openCam.Location = new System.Drawing.Point(1105, 340);
            this.btn_openCam.Name = "btn_openCam";
            this.btn_openCam.Size = new System.Drawing.Size(75, 23);
            this.btn_openCam.TabIndex = 9;
            this.btn_openCam.Text = "Bật Camera";
            this.btn_openCam.UseVisualStyleBackColor = true;
            this.btn_openCam.Click += new System.EventHandler(this.btn_openCam_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(787, 340);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(213, 20);
            this.tb_result.TabIndex = 10;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 771);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_openCam);
            this.Controls.Add(this.pb_camera);
            this.Controls.Add(this.cb_camera);
            this.Controls.Add(this.lb_selectCam);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lv_bill);
            this.Controls.Add(this.lv_product);
            this.Controls.Add(this.lb_title);
            this.Name = "Cart";
            this.Text = "Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cart_FormClosing);
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ListView lv_product;
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_selectCam;
        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.PictureBox pb_camera;
        private System.Windows.Forms.Button btn_openCam;
        private System.Windows.Forms.TextBox tb_result;
    }
}