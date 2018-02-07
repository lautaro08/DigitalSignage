using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        
        private void styleMouseEnter(object sender, EventArgs e)
        {

            var button = ((Button)sender);
            button.UseVisualStyleBackColor = false;
            button.BackColor = Color.DarkGray;
            button.Cursor = Cursors.Hand;
        }

        private void styleMouseLeave(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            button.UseVisualStyleBackColor = true;
            button.BackColor = Color.Transparent;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
