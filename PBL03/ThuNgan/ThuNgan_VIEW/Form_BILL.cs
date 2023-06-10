using PBL03.Thungan.Thungan_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.Thungan.Thungan_VIEW
{
    public partial class Form_BILL : Form
    {
        public Form_BILL()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private float DeleteVND(string t)
        {
            int endIndex = t.IndexOf(" ");
            string st = t.Substring(0, endIndex);
            float sub = Convert.ToSingle(st);
            return sub;
        }

        private void Form_BILL_Load(object sender, EventArgs e)
        {
            Form_Order fo = (Form_Order)Application.OpenForms["Form_Order"];
            DataTable dt = new DataTable();
            //  dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Tên Món", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Đơn Giá", typeof(float));
            //  dt.Columns.Add("Thành Tiền",typeof(float));

            foreach (UserControl_Order uo in fo.flowLayout_Order.Controls)
            {
                DataRow temp = dt.NewRow();
                //temp["STT"] = count++;
                temp["Tên Món"] = uo.lbFood.Text;
                temp["Số Lượng"] = uo.numericquantity.Value;
                float sub = DeleteVND(uo.lbPrice.Text);
                temp["Đơn Giá"] = sub;
                //temp["Thành Tiền"] = sub * Convert.ToInt32(uo.numericquantity.Value);
                dt.Rows.Add(temp);
            }
            dt.Columns.Add(new DataColumn { ColumnName = "STT", DataType = typeof(int) });
            dt.Columns["STT"].SetOrdinal(0);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;

            }
            dt.Columns.Add(new DataColumn { ColumnName = "Thành Tiền", DataType = typeof(float) });
            dt.Columns["Thành Tiền"].SetOrdinal(dt.Columns.Count - 1);
            float tongtien = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                float donGia = Convert.ToSingle(dt.Rows[i]["Đơn Giá"]);
                int soLuong = Convert.ToInt32(dt.Rows[i]["Số Lượng"]);
                float thanhTien = donGia * soLuong;
                tongtien += thanhTien;
                dt.Rows[i]["Thành Tiền"] = thanhTien;
            }
            DateTime timein = Cashier_BLL.Instance.TakeTimeInorOut(fo.lbTable.Text, 0);
            DateTime timeout = Cashier_BLL.Instance.TakeTimeInorOut(fo.lbTable.Text, 1);
            //set Datagridview
            dtgvBillInfor.ColumnHeadersVisible = true;
            dtgvBillInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBillInfor.DataSource = dt;
            // set thuộc tính cho các Text Box
            label3.Text = "Ngày " + timein.Day.ToString() + " tháng " + timein.Month.ToString() + " năm " + timein.Year.ToString();
            lbTotal.Text = fo.lbTotal.Text;
            lbCustomerPaid.Text = fo.txtMoneyPaid.Text + " VND";
            lbReturn.Text = (Convert.ToSingle(fo.txtMoneyPaid.Text) - DeleteVND(lbTotal.Text)).ToString() + " VND";
            lbDiscount.Text = fo.lbVoucher.Text;
            // set thuộc tính
            
            lbTimeComeIn.Text = timein.Hour.ToString() + ":" + timein.Minute.ToString() + ":" + timein.Second.ToString();
            lbTimeComeOut.Text = timeout.Hour.ToString() + ":" + timeout.Minute.ToString() + ":" + timeout.Second.ToString();
            lbTableNumber.Text = fo.lbTable.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
