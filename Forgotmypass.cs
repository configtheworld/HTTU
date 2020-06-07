using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTU
{
    public partial class Forgotmypass : Form
    {
        public Forgotmypass()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UserAndPassControl user1 = new UserAndPassControl();
            bool state = user1.newpass(Usernameforgot, Passwordforgot, Confirmpassforgot);
            if (state)
            {
                this.Hide();
            }

        }
    }
}
