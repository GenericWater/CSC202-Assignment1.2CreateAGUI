using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class indexHorror : Form
    {
        public indexHorror()
        {
            InitializeComponent();
        }

        private void indexHorror_Load(object sender, EventArgs e)
        {

        }

        private void BTNname_Click(object sender, EventArgs e)
        {
            // If it is an integer entered in the textbox TBname - display a message that this is not a valid name
            if (int.TryParse(TBname.Text, out int value))
            {
                MessageBox.Show("This is not a valid name");
            }
            // else display a welcoming pop-up
            else
            {
                Image ghost = Image.FromFile("greetingGhost.JPG"); // assign variable name "ghost" Image value
                PBname.SizeMode = PictureBoxSizeMode.StretchImage; // sets the PictureBox size mode to change the image to fille
                PBname.Image = ghost;// Assign the PictureBox the Image of the ghost
                PBname.Visible = true; // set the PictureBox Visible property to True
            }
        }
    }
}
