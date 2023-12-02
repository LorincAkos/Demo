namespace SoftwaretechInventory
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            playerLevelDisplay.Text = "Level: 1";
            healtDisplay.Text = "320";
            damageDisplay.Text = "120";
            fireRateDisplay.Text = "1.2";
            speedDisplay.Text = "20";
        }

        //Replaces the equiped weapon with the one you clik on
        private void weapon_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new();
            pictureBox.Image = ((PictureBox)sender).Image;
            ((PictureBox)sender).Image = this.weaponEquiped.Image;
            this.weaponEquiped.Image = pictureBox.Image;
        }

    }
}