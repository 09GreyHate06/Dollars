using Dollars.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ManageProductForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageProductForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbPrdID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbPrdID.Text = new String(tbPrdID.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbPrdUnitPrice_TextChanged(object sender, EventArgs e)
        {
            // only allow floating point numbers
            tbPrdUnitPrice.Text = new String(tbPrdUnitPrice.Text.Where(c => c == '.' || ('0' <= c && c <= '9')).ToArray());
        }

        private void tbPrdUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbPrdUnitPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnBrowsePrdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF | All files (*.*)|*.*",
                FilterIndex = 0,

                RestoreDirectory = true,
                ShowReadOnly = true
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(fileDialog.FileName);
                pbPrdImage.Image = image;
            }
        }

        private void btnClearPrdImage_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ManageProductForm));
            pbPrdImage.Image = (Image)(resources.GetObject("pbPrdImage.Image"));
        }
    }
}
