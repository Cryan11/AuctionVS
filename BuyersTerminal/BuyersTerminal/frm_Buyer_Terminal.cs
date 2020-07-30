using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (Valid_buyer_number(buyernum))
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

        private bool Valid_buyer_number(string Buyer_Number)
        {
            string Sql_String = "";
            long rcount = 0;
            
            Sql_String = " SELECT COUNT(*) AS BCOUNT FROM Buyer WHERE Buyer_Number = '" + Buyer_Number + "' ";
            rcount = Execute_Sql_Return_Long_Field(Sql_String, "BCOUNT")
            if (rcount > 0)
                Valid_buyer_number(true);
            else
            {
                Valid_buyer_number(false);
            }


            return Valid_buyer_number(buyernum);
        }

      
    }
}
