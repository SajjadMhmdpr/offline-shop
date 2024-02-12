
namespace term1_project_shop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX1
            // 
            resources.ApplyResources(this.textBoxX1, "textBoxX1");
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("textBoxX1.ButtonCustom.DisplayPosition")));
            this.textBoxX1.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX1.ButtonCustom.Image")));
            this.textBoxX1.ButtonCustom.Text = resources.GetString("textBoxX1.ButtonCustom.Text");
            this.textBoxX1.ButtonCustom.Tooltip = resources.GetString("textBoxX1.ButtonCustom.Tooltip");
            this.textBoxX1.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("textBoxX1.ButtonCustom2.DisplayPosition")));
            this.textBoxX1.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX1.ButtonCustom2.Image")));
            this.textBoxX1.ButtonCustom2.Text = resources.GetString("textBoxX1.ButtonCustom2.Text");
            this.textBoxX1.ButtonCustom2.Tooltip = resources.GetString("textBoxX1.ButtonCustom2.Tooltip");
            this.textBoxX1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.UseWaitCursor = true;
            this.textBoxX1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.textBoxX1.WatermarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxX2
            // 
            resources.ApplyResources(this.textBoxX2, "textBoxX2");
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("textBoxX2.ButtonCustom.DisplayPosition")));
            this.textBoxX2.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX2.ButtonCustom.Image")));
            this.textBoxX2.ButtonCustom.Text = resources.GetString("textBoxX2.ButtonCustom.Text");
            this.textBoxX2.ButtonCustom.Tooltip = resources.GetString("textBoxX2.ButtonCustom.Tooltip");
            this.textBoxX2.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("textBoxX2.ButtonCustom2.DisplayPosition")));
            this.textBoxX2.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX2.ButtonCustom2.Image")));
            this.textBoxX2.ButtonCustom2.Text = resources.GetString("textBoxX2.ButtonCustom2.Text");
            this.textBoxX2.ButtonCustom2.Tooltip = resources.GetString("textBoxX2.ButtonCustom2.Tooltip");
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.WatermarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.WatermarkImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxX2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

