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
    public partial class UserRegisterForm : Form
    {

        public UserRegisterForm()
        {
            InitializeComponent();
        }

        public void closeoperation()
        {
            this.Close();
        }
        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterNowButton_Click(object sender, EventArgs e)
        {
            UserAndPassControl user= new UserAndPassControl();
            //user.newUser(nameTB,passwordTB,ConfirmTB,cityTB,groupBox1);
            this.Close();
        }
    }
}
