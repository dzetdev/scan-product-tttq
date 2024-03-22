namespace Scan_Product_TTTQ
{
    partial class Form1
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
            this.lb_select_camera = new System.Windows.Forms.Label();
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.cb_list_camera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(92, 37);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(625, 31);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Giao diện kiểm tra lấy mã BarCode và mã QR Code";
            // 
            // lb_select_camera
            // 
            this.lb_select_camera.AutoSize = true;
            this.lb_select_camera.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_select_camera.Location = new System.Drawing.Point(95, 102);
            this.lb_select_camera.Name = "lb_select_camera";
            this.lb_select_camera.Size = new System.Drawing.Size(165, 17);
            this.lb_select_camera.TabIndex = 1;
            this.lb_select_camera.Text = "Lựa chọn camera đầu vào";
            // 
            // pb_camera
            // 
            this.pb_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_camera.Location = new System.Drawing.Point(205, 151);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(416, 215);
            this.pb_camera.TabIndex = 3;
            this.pb_camera.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(98, 151);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(98, 191);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Dừng";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_result.Location = new System.Drawing.Point(95, 386);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(84, 17);
            this.lb_result.TabIndex = 6;
            this.lb_result.Text = "Mã đọc được";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(205, 386);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(416, 20);
            this.tb_result.TabIndex = 7;
            // 
            // cb_list_camera
            // 
            this.cb_list_camera.FormattingEnabled = true;
            this.cb_list_camera.Location = new System.Drawing.Point(267, 102);
            this.cb_list_camera.Name = "cb_list_camera";
            this.cb_list_camera.Size = new System.Drawing.Size(354, 21);
            this.cb_list_camera.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_list_camera);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pb_camera);
            this.Controls.Add(this.lb_select_camera);
            this.Controls.Add(this.lb_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_select_camera;
        private System.Windows.Forms.PictureBox pb_camera;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.ComboBox cb_list_camera;
    }
}

