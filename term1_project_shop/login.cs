using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bussiness_entity;
using bussiness_logic;

namespace term1_project_shop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        #region change font / enter / esc

        /*public void setfont()
        {
            PrivateFontCollection pfcoll = new PrivateFontCollection();
            //pfcoll.AddFontFile(@"E:\summer_tose e gar\تكميلي\Installations\Installations\Fonts\Fonts\IRANSansWeb Light\IRANSansWeb Light.ttf");
            FontFamily ff = pfcoll.Families[0];
            Font ft = new Font(ff, 12);
            foreach (Control item in this.Controls)
            {
                item.Font = ft;
            }
        }*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void login_Load_1(object sender, EventArgs e)
        {
            //setfont();
        }

        #endregion


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register f2 = new register();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری را وارد کنید");
                textBoxX1.Focus();
            }
            else if(textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("رمز را وارد کنید");
                textBoxX2.Focus();
            }
            else
            {
                customer c = new customer();
                c.username = textBoxX1.Text;
                c.password = textBoxX2.Text;

                bl_customer blcus = new bl_customer();

                if (blcus.search(c))
                {
                    customer_page frm = new customer_page();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("کسی با این مشخصات وجود ندارد"+"\n"+"اگر حسابی نداریداز قسمت ثبت نام اقدام کنید");
                    linkLabel1.Focus();
                    textBoxX1.Clear();
                    textBoxX2.Clear();
                }
            }
        }

        
    }
}
