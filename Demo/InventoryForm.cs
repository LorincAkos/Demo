using Demo;

namespace SoftwaretechInventory
{
    public partial class InventoryForm : Form
    {

        public InventoryForm()
        {
            InitializeComponent();
            playerLevelDisplay.Text = "Level: " + Player.Level;
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
            pictureBox.ImageLocation = ((PictureBox)sender).ImageLocation;
            ((PictureBox)sender).Image = this.weaponEquiped.Image;
            ((PictureBox)sender).ImageLocation = this.weaponEquiped.ImageLocation;
            this.weaponEquiped.Image = pictureBox.Image;
            this.weaponEquiped.ImageLocation = pictureBox.ImageLocation;
            Player.Weapon.ChangeWeapon(this.weaponEquiped.ImageLocation);
        }

        private void engine_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new();
            pictureBox.Image = ((PictureBox)sender).Image;
            pictureBox.ImageLocation = ((PictureBox)sender).ImageLocation;
            ((PictureBox)sender).Image = this.engineEquiped.Image;
            ((PictureBox)sender).ImageLocation = this.engineEquiped.ImageLocation;
            this.engineEquiped.Image = pictureBox.Image;
            this.engineEquiped.ImageLocation = pictureBox.ImageLocation;
        }

        private void ship_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new();
            pictureBox.Image = ((PictureBox)sender).Image;
            pictureBox.ImageLocation = ((PictureBox)sender).ImageLocation;
            ((PictureBox)sender).Image = this.shipbodyEquiped.Image;
            ((PictureBox)sender).ImageLocation = this.shipbodyEquiped.ImageLocation;
            this.shipbodyEquiped.Image = pictureBox.Image;
            this.shipbodyEquiped.ImageLocation = pictureBox.ImageLocation;
            pictureBox1.Image = this.shipbodyEquiped.Image;
            Player.Ship.ChangeShip(this.shipbodyEquiped.ImageLocation);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}