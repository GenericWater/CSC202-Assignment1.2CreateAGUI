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
                PBname.SizeMode = PictureBoxSizeMode.StretchImage; // sets the PictureBox size mode to change the image to fill
                PBname.Image = ghost;// Assign the PictureBox the Image of the ghost
                PBname.Visible = true; // set the PictureBox Visible property to True
            }
        }

        private void BTNsubmit_Click(object sender, EventArgs e)
        {
            // Get all CheckBoxes in the GroupBox "GBkillers"
            var checkBoxes = GBkillers.Controls.OfType<CheckBox>();

            // Count the checkBoxes | .Count() returns the total number of checked boxes
            int checkBoxCount = checkBoxes.Count(cb => cb.Checked); // cb is a parameter assigned to the checkBoxes class/type

            // if more than half of the boxes are checked, display message...
            if (checkBoxCount > checkBoxes.Count() / 2) 
            {
                MessageBox.Show("You have a twisted mind!");
            }
            else // less than or equal to half of the checkBoxes were selected...
            {
                MessageBox.Show("Eh, you should be fine. Keep going!");
            }
        }

        // Checks when BTNscare is clicked - will fill progress bar by 10% or 10 steps out of 100 every click
        private void BTNscare_Click(object sender, EventArgs e)
        {
            // Check if progress bar is full / 100%
            if (PBscare.Value < PBscare.Maximum)
            {
                // Increase the progress bar value by the step amount in the editor
                PBscare.PerformStep();
            }
            else
            {
                Image hatchet = Image.FromFile("hatchet.JPG"); // set variable "hatchet" equal to the image I want to display
                MessageBox.Show("BOO!"); // Display a pop-up Messsage Box
                PicBoxScare.Image = hatchet; // Assign the picture box the var "hatchet" 
                PicBoxScare.SizeMode = PictureBoxSizeMode.StretchImage; // sets the PictureBox size mode to change the image to fill
                PicBoxScare.Visible = true; // Set the Visible property to true
            }
        }
    }
}
