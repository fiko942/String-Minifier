using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Minifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void errorHandler(string message)
        {
            MessageBox.Show(message.ToString(), "String Minifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void txtLong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMinified.Text = txtLong.Text.Replace(System.Environment.NewLine, "").Replace(@"\s+", " ").ReduceWhitespace().Trim(); 
            }
            catch (Exception ex)
            {
                errorHandler(ex.Message.ToString());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtMinified.Text.Trim());
                int strLength = txtMinified.Text.Length;
                MessageBox.Show(strLength.ToString() + " Characters has been copied to clipboard successfully", "String Minifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                errorHandler(ex.Message.ToString());
            }
        }
    }
}
