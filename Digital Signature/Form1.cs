using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Signature
{
    public partial class Form1 : Form
    {
        DialogResult dialogResult = DialogResult.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_select_file_Click(object sender, EventArgs e)
        {
            dialogResult = openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            text_box_file_location.Text = openFileDialog1.FileName;
            label_generated.Visible = false;
            label_file_source.Visible = false;
        }

        private void button_gen_sig_Click(object sender, EventArgs e)
        {
            if (dialogResult==DialogResult.OK)
            {
                byte[] b = getFileBytes(openFileDialog1.FileName);
                if (rb_all_sig.Checked || rb_md5.Checked) computeMD5Hash(openFileDialog1.FileName, b);
                if (rb_all_sig.Checked || rb_sha1.Checked) computeSHAHash(openFileDialog1.FileName, b);
                label_generated.ForeColor = Color.Green;
                label_generated.Text = "Generated!";
            }
            else
            {
                label_generated.ForeColor = Color.Red;
                label_generated.Text = "Please select a file!";
            }
            label_generated.Visible = true;
        }

        private static byte[] getFileBytes(string fn)
        {
            FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fs.Length];
            for (long i=0; i<fs.Length; i++)
            {
                b[i] = (byte) fs.ReadByte();
            }
            return b;
        }

        private static byte[] computeMD5Hash(byte[] b)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(b);
        }

        private static void computeMD5Hash(string fn, byte[] b)
        {
            FileStream fs = new FileStream(fn+".md5", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] computedHash = computeMD5Hash(b);
            fs.Write(computedHash, 0, computedHash.Length);
            fs.Close();
        }

        private static byte[] computeSHAHash(byte[] b)
        {
            SHA1 sha = SHA1.Create();
            return sha.ComputeHash(b);
        }

        private static void computeSHAHash(string fn, byte[] b)
        {
            FileStream fs = new FileStream(fn + ".sha1", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] computedHash = computeSHAHash(b);
            fs.Write(computedHash, 0, computedHash.Length);
            fs.Close();
        }

        private void groupBox1_TabIndexChanged(object sender, EventArgs e)
        {
            label_generated.Visible = false;
        }

        private int compareByteArrays(byte[] b0, byte[] b1)
        {
            if (b0.Length != b1.Length) return 0;
            else
            {
                bool isEqual = b0.SequenceEqual(b1);
                if (isEqual) return 1;
                else return 2;
            }
        }

        private void button_comp_md5_Click(object sender, EventArgs e)
        {
            if (dialogResult==DialogResult.OK)
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    byte[] b0 = computeMD5Hash(getFileBytes(openFileDialog1.FileName));
                    byte[] b1 = getFileBytes(openFileDialog2.FileName);
                    int res = compareByteArrays(b0, b1);
                    switch(res)
                    {
                        case 0:
                            label_status_md5.ForeColor = Color.Gray;
                            label_status_md5.Text = "DIFF. HASH";
                            break;
                        case 1:
                            label_status_md5.ForeColor = Color.Green;
                            label_status_md5.Text = "HASH OK";
                            break;
                        case 2:
                            label_status_md5.ForeColor = Color.Red;
                            label_status_md5.Text = "WRONG HASH";
                            break;
                    }
                }
            }
            else
            {
                label_file_source.Visible = true;
            }
        }

        private void button_comp_sha1_Click(object sender, EventArgs e)
        {
            if (dialogResult == DialogResult.OK)
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    byte[] b0 = computeSHAHash(getFileBytes(openFileDialog1.FileName));
                    byte[] b1 = getFileBytes(openFileDialog2.FileName);
                    int res = compareByteArrays(b0, b1);
                    switch (res)
                    {
                        case 0:
                            label_status_sha1.ForeColor = Color.Gray;
                            label_status_sha1.Text = "DIFF. HASH";
                            break;
                        case 1:
                            label_status_sha1.ForeColor = Color.Green;
                            label_status_sha1.Text = "HASH OK";
                            break;
                        case 2:
                            label_status_sha1.ForeColor = Color.Red;
                            label_status_sha1.Text = "WRONG HASH";
                            break;
                    }
                }
            }
            else
            {
                label_file_source.Visible = true;
            }
        }
    }
}
