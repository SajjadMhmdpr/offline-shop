using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bussiness_entity;
using bussiness_logic;

namespace term1_project_shop
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (textBoxX1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام را وارد کنید");
                textBoxX1.Focus();
            }
            else if (textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام خانوادگی را وارد کنید");
                textBoxX2.Focus();
            }
            else if (textBoxX3.Text.Trim().Length == 0)
            {
                MessageBox.Show("شماره همراه را وارد کنید");
                textBoxX3.Focus();
            }
            else if (textBoxX5.Text.Trim().Length == 0)
            {
                MessageBox.Show("سن را وارد کنید");
                textBoxX5.Focus();
            }
            else if (textBoxX7.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری را وارد کنید");
                textBoxX7.Focus();
            }
            else if (textBoxX8.Text.Trim().Length == 0)
            {
                MessageBox.Show("رمز را وارد کنید");
                textBoxX8.Focus();
            }
            else if (textBoxX6.Text.Trim().Length == 0)
            {
                MessageBox.Show("رمز را مجدد وارد کنید");
                textBoxX6.Focus();
            }
            else if (textBoxX6.Text != textBoxX8.Text)
            {
                MessageBox.Show("تکرار رمز اشتباه است");
                textBoxX6.Focus();
            }
            else
            {
                customer c1 = new customer();
                c1.name = textBoxX1.Text;
                c1.family = textBoxX2.Text;
                c1.telephone = textBoxX3.Text;
                c1.address = textBoxX4.Text;
                c1.age = Convert.ToByte(textBoxX5.Text);
                c1.status = true;

                c1.username = textBoxX7.Text;
                c1.password = textBoxX8.Text;

                bl_customer blcus = new bl_customer();
                bool f = false;

                if ( !blcus.search(c1 , ref f) )
                {
                    blcus.create(c1);
                    MessageBox.Show("ثبت نام با موفقیت انجام شد");
                }
                else
                {
                    if(f)
                        MessageBox.Show("ثبت نام با موفقیت انجام شد");
                    else
                        MessageBox.Show("شما از قبل یک حساب کاربری دارید"+"\n"+"از قسمت بازیابی رمز اقدام نموده و وارد شوید");
                }
            }



        }
    }
}
