using PBL03.BLL;
using PBL03.Thungan.Thungan_BLL;
using PBL03.Thungan.Thungan_VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03
{
    public partial class Form_Order : Form
    {

        dynamic[] Foods = new dynamic[3] 
        { 
            Cashier_BLL.Instance.getFoodbyBooking(),
            Cashier_BLL.Instance.getDrinkbyBooking(), 
            Cashier_BLL.Instance.getCreamsbyBooking() 
        }; 
        private OrderFood_BLL bll;
        private Bill_BLL bill;
        private Change_StatusTable_BLL statusTable;
       
        private bool btnSaveClicked = false;
        public Form_Order()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bll = new OrderFood_BLL();
            bill = new Bill_BLL();
            statusTable = new Change_StatusTable_BLL();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void ShowFood(int i)
        {
           
            foreach(var food in Foods[i])
            {
                
                    if (food.QuantityFood > 0)
                    {
                        // Tạo một đối tượng UserControl_Menu mới
                        UserControl_Food uf = new UserControl_Food();

                        // Truyền giá trị cho các label của user control

                        uf.lbFood.Text = food.NameFood.ToString();
                        uf.lbPrice.Text = food.Price.ToString() + " VND";
                        string imagepath = Path.Combine(Application.StartupPath, food.PictureFood.ToString());
                        //Image img = Image.FromFile(imagepath);
                        //uf.BackgroundImage = img;

                        byte[] imagedata = File.ReadAllBytes(imagepath);
                        using (MemoryStream ms = new MemoryStream(imagedata))
                        {
                            Image img = Image.FromStream(ms);
                            uf.BackgroundImage = img;
                        }


                    // Thêm user control vào FlowLayoutPanel
                        flowLayout_Food.Controls.Add(uf);
                    }
                    else
                    {
                        // Tạo một đối tượng UserControl_Menu mới
                        UserControl_Food uf = new UserControl_Food();

                        // Truyền giá trị cho các label của user control

                        uf.lbFood.Text = food.NameFood.ToString();
                        string imagepath = Path.Combine(Application.StartupPath, food.PictureFood.ToString());
                        //Image img = Image.FromFile(imagepath);
                        //uf.BackgroundImage = img;

                        byte[] imagedata = File.ReadAllBytes(imagepath);
                        using (MemoryStream ms = new MemoryStream(imagedata))
                        {
                            Image img = Image.FromStream(ms);
                            uf.BackgroundImage = img;
                        }
                        uf.pnSoldOut.Visible = true;


                        // Thêm user control vào FlowLayoutPanel
                        flowLayout_Food.Controls.Add(uf);
                    
                }
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnFood.Height;
            pnStast.Top = btnFood.Top;
            //bll.getFood_BLL(flowLayout_Food);
            ShowFood(0);
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            //if (tbSearch.Text == "")
            //{
            //    tbSearch.Text = "Search for menu";
            //    tbSearch.ForeColor = Color.DimGray;
            //}
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            //if (tbSearch.Text == "Search for menu")
            //{
            //    tbSearch.Text = "";
            //    tbSearch.ForeColor = Color.DimGray;
            //}
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnDrink.Height;
            pnStast.Top = btnDrink.Top;
            ShowFood(1);
        }

        private void btnCream_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Controls.Clear();
            pnStast.Height = btnCream.Height;
            pnStast.Top = btnCream.Top;
            ShowFood(2);
        }

        private void btnSubtotal_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            double total = 0;
            int kh = Convert.ToInt32(lbNumberCustomer.Text);
            if (ckbVoucher.Checked)
            {
                if (kh >= 5 && kh <= 10)
                {
                    lbVoucher.Text = "5 %";
                }
                else if (kh > 10)
                {
                    lbVoucher.Text = "10 %";
                }
                else if (kh < 5)
                {
                    lbVoucher.Text = "0 %";
                }    
            }
            else
            {
                lbVoucher.Text = "0 %";
            }    
            foreach (UserControl_Order uo in flowLayout_Order.Controls)
            {
                string t = uo.lbPrice.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                subtotal += Convert.ToDouble(st) * (double)uo.numericquantity.Value;
            }
            string vc = lbVoucher.Text;
            int percent = vc.IndexOf(" ");
            string voucher = vc.Substring(0, percent);
            total = subtotal - subtotal * Convert.ToDouble(voucher) / 100;
            lbSubtotal.Text = subtotal.ToString() + " VND";
            lbTotal.Text = total.ToString() + " VND";
            btnSave.Enabled = true;
            btnPayNow.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (btnSave.Text == "Save")
            {
                btnSaveClicked = true;
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                int count = 0;
                foreach(UserControl_Order uo in flowLayout_Order.Controls)
                {
                    count++;
                    Cashier_BLL.Instance.OrderMeal(count, Cashier_BLL.Instance.GetIdFood(uo.lbFood.Text), (int)uo.numericquantity.Value, lbTable.Text);
                    Cashier_BLL.Instance.subQuantityFood(uo.lbFood.Text, (int)uo.numericquantity.Value);
                }
                string Username = Cashier_BLL.Instance.GetIdEmployee(lbUsername.Text);
                Cashier_BLL.Instance.AddBill(dt, Username, lbTable.Text, sub);
                MessageBox.Show("Đã lưu order vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                
                btnSaveClicked = true;
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                
                int count = Cashier_BLL.Instance.CountOrder(lbTable.Text);
                
                foreach (UserControl_Order uo in flowLayout_Order.Controls)
                {
                    
                    if (Cashier_BLL.Instance.CheckExistFood(Cashier_BLL.Instance.GetIdFood(uo.lbFood.Text)) == true)
                    {
                        Cashier_BLL.Instance.UpdateMeal(lbTable.Text, (int)uo.numericquantity.Value, uo.lbFood.Text);
                    }
                    else
                    {
                        count++;
                        Cashier_BLL.Instance.OrderMeal(count, Cashier_BLL.Instance.GetIdFood(uo.lbFood.Text), (int)uo.numericquantity.Value, lbTable.Text);
                        Cashier_BLL.Instance.subQuantityFood(uo.lbFood.Text,(int)uo.numericquantity.Value);
                    }
                }

                
                string Username = Cashier_BLL.Instance.GetIdEmployee(lbUsername.Text);
                Cashier_BLL.Instance.UpdateBill(dt, Username, lbTable.Text, sub);
                MessageBox.Show("Đã cập nhật order vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }    
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (ckbVoucher.Checked)
            {
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                string tt = lbTotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                string stt = tt.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                float total = Convert.ToSingle(stt);
                int people = Convert.ToInt32(lbNumberCustomer.Text);
                if (txtMoneyPaid.Text == "")
                {
                    MessageBox.Show("Chưa nhập tiền khách trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    float paid = Convert.ToSingle(txtMoneyPaid.Text);
                    //bill.addBillHistoryWithDC_BLL(lbTable.Text, dt, sub, sub + 50000, change, people);
                    //bill.payBill_BLL(dt, lbTable.Text);
                    //bll.removeOrder_BLL(lbTable.Text);
                    if (paid < total)
                    {
                        MessageBox.Show("Chưa đủ số tiền phải trả! Đề nghị nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMoneyPaid.Text = "";
                    }
                    else
                    {
                        Cashier_BLL.Instance.AddBillHistoryWithDC(lbTable.Text, dt, sub, paid, paid - total, people);
                        Cashier_BLL.Instance.PayBill(dt, lbTable.Text);
                        Cashier_BLL.Instance.RemoveOrder(lbTable.Text);
                        Cashier_BLL.Instance.AddOrUpdateRevenue(Cashier_BLL.Instance.CountRowInRevenue(), total, people);
                        statusTable.refreshTable_BLL(lbTable.Text);
                        Form_StatusTable ftb = (Form_StatusTable)Application.OpenForms["Form_StatusTable"];
                        ftb.setColorTable();
                        Form_BILL fb = new Form_BILL();
                        fb.Show();
                        MessageBox.Show("Đã thanh toán hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    this.Dispose();
                    }   
                }
            }
            else
            {
                DateTime dt = DateTime.Now;
                string t = lbSubtotal.Text;
                string tt = lbTotal.Text;
                int endIndex = t.IndexOf(" ");
                string st = t.Substring(0, endIndex);
                string stt = tt.Substring(0, endIndex);
                float sub = Convert.ToSingle(st);
                float total = Convert.ToSingle(stt);
                int people = Convert.ToInt32(lbNumberCustomer.Text);
                //bill.addBillHistoryWithoutDC_BLL(lbTable.Text, dt, sub, sub + 50000, "KM003", 50000, people);
                //bill.payBill_BLL(dt, lbTable.Text);

                if (txtMoneyPaid.Text == "")
                {
                    MessageBox.Show("Chưa nhập tiền khách trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    float paid = Convert.ToSingle(txtMoneyPaid.Text);
                    if (paid < total)
                    {
                        MessageBox.Show("Chưa đủ số tiền phải trả! Đề nghị nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMoneyPaid.Text = "";
                    }   
                    else
                    {
                        Cashier_BLL.Instance.AddBillHistoryWithoutDC(lbTable.Text, dt, sub, paid, "KM003", paid - total, people);
                        Cashier_BLL.Instance.PayBill(dt, lbTable.Text);
                        Cashier_BLL.Instance.RemoveOrder(lbTable.Text);
                        statusTable.refreshTable_BLL(lbTable.Text);
                        Cashier_BLL.Instance.AddOrUpdateRevenue(Cashier_BLL.Instance.CountRowInRevenue(), total, people);
                        Form_StatusTable ftb = (Form_StatusTable)Application.OpenForms["Form_StatusTable"];
                        ftb.setColorTable();
                        Form_BILL fb = new Form_BILL();
                        fb.Show();
                        MessageBox.Show("Đã thanh toán hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //    this.Dispose();
                    }    
                    
                }
                
            }
        }

        private void ShowFoods(string name)
        {
            foreach(var food in Cashier_BLL.Instance.GetFoodBySearch(name))
            {
                // Tạo một đối tượng UserControl_Menu mới
                UserControl_Food uf = new UserControl_Food();

                // Truyền giá trị cho các label của user control

                uf.lbFood.Text = food.NameFood.ToString();
                uf.lbPrice.Text = food.Price.ToString() + " VND";
                string imagepath = Path.Combine(Application.StartupPath, food.PictureFood.ToString());
                //Image img = Image.FromFile(imagepath);
                //uf.BackgroundImage = img;

                byte[] imagedata = File.ReadAllBytes(imagepath);
                using (MemoryStream ms = new MemoryStream(imagedata))
                {
                    Image img = Image.FromStream(ms);
                    uf.BackgroundImage = img;
                }


                // Thêm user control vào FlowLayoutPanel
                flowLayout_Food.Controls.Add(uf);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayout_Food.Controls.Clear();
            //bll.getFoodBySearch_BLL(flowLayout_Food, tbSearch.Text);
            ShowFoods(tbSearch.Text);
        }

        private void btnExitFormOrder_Click(object sender, EventArgs e)
        {
            if (btnSaveClicked || btnSave.Text == "Update")
            {
                this.Dispose();
                Form_BILL f = (Form_BILL)Application.OpenForms["Form_BILL"];
                f.Dispose();
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
