using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuyersTerminal
{
    public partial class frm_Buyer_Terminal : Form
    {
        public frm_Buyer_Terminal()
        {
            InitializeComponent();
        }


        private void cmd_Clear_Click(object sender, EventArgs e)
        {
            txt_Buyer_Number.Text = "";
            txt_Cut_Number.Text = "";
            txt_Password.Text = "";
        }

        private void cmd_Print_WC_Click(object sender, EventArgs e)
        {
            string buyernum = "";
            string cutnum = "";
            bool skip_unassigned_checks_for_PO = false;
            string BuyingCustID = "";
            string Unassigned_List = "";

            buyernum = txt_Buyer_Number.Text.Trim();
            cutnum = txt_Cut_Number.Text.Trim();

            if (string.IsNullOrEmpty(buyernum))
            {
                MessageBox.Show("Must Enter a Valid Buyer Number");
                txt_Buyer_Number.Focus();
            }

            if (Valid_buyer_number(true))
            {
                if (string.IsNullOrEmpty(cutnum))
                {
                    if (Valid_buyer_cut_number(buyernum, cutnum)) ;
                    //Do nothing - let proceed
                }
            }

        }

        private bool Valid_buyer_cut_number(string buyernum, string cutnum)
        {
            throw new NotImplementedException();
        }

        public bool Valid_buyer_number(bool buyernum)
        {
            Utilities utils = new Utilities();
            utils.Open("auctiondb");
            long rcount = 0;

            MySqlCommand cmd = new MySqlCommand(" SELECT COUNT(*) AS BCOUNT FROM Buyer WHERE Buyer_Number = '" +
                                                buyernum + "' ");
            rcount = Execute_Sql_Return_Long_Field(cmd.CommandText, "BCOUNT");
            Valid_buyer_number(rcount > 0);

            return buyernum;
        }

        private long Execute_Sql_Return_Long_Field(string cmd, string bcount)
        {
            throw new NotImplementedException();
        }
    }
}
