using Demo;

namespace SoftwaretechInventory
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            playerLevelDisplay.Text = "Level: " + Player.Level ;
            healtDisplay.Text = Player.Ship.Hp.ToString();
            damageDisplay.Text = Player.Weapon.Damage.ToString();
            fireRateDisplay.Text = Player.Weapon.FireRate.ToString();
            speedDisplay.Text = Player.Engine.Speed.ToString();
        }

        //Replaces the equiped weapon with the one you clik on
        private void weapon_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new();
            pictureBox.Image = ((PictureBox)sender).Image;
            ((PictureBox)sender).Image = this.weaponEquiped.Image;
            this.weaponEquiped.Image = pictureBox.Image;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}