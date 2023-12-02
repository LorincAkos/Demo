using SoftwaretechInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    public partial class Base : Form
    {
        Image TheBase;
        Image Inventory;
        Image Mine;
        Image WorkBench;
        Image DefSys;
        Image ExitBase;
        
        public Base()
        {
            InitializeComponent();
            TheBase = Image.FromFile("Images\\Base.png");
            Inventory = Image.FromFile("Images\\Inventory.png");
            Mine = Image.FromFile("Images\\Mine.png");
            WorkBench = Image.FromFile("Images\\Workbench.png");
            DefSys = Image.FromFile("Images\\DefenseSystem.png");
            ExitBase = Image.FromFile("Images\\ExitButton.png");
        }

        

        private void Base_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics theBase = e.Graphics;
            Graphics inventory = e.Graphics;
            Graphics mine = e.Graphics;
            Graphics workbench = e.Graphics;
            Graphics defSys = e.Graphics;
            Graphics exitBase = e.Graphics;

            theBase.DrawImage(TheBase, 250, 250, 96, 96);
            inventory.DrawImage(Inventory, 400, 100, 96, 96);
            mine.DrawImage(Mine, 100, 400, 96, 96);
            workbench.DrawImage(WorkBench, 400, 400, 96, 96);
            defSys.DrawImage(DefSys, 100, 100, 96, 96);
            exitBase.DrawImage(ExitBase, 230, 400, 128, 128);
        }

        private void Base_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;


            if (mouse.X >= 255 && mouse.Y >= 442 && mouse.X < 255 + 64 && mouse.Y < 442 + 64)
            {
                Close();
            }

            if (mouse.X >= 250 && mouse.Y >= 250 && mouse.X < 250 + 96 && mouse.Y < 250 + 96)
            {

            }

            if (mouse.X >= 400 && mouse.Y >= 100 && mouse.X < 400 + 96 && mouse.Y < 100 + 96)
            {
                InventoryForm inventory = new InventoryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                inventory.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(inventory);
                inventory.Show();
            }

            if (mouse.X >= 100 && mouse.Y >= 400 && mouse.X < 100 + 96 && mouse.Y < 400 + 96)
            {

            }

            if (mouse.X >= 400 && mouse.Y >= 400 && mouse.X < 400 + 96 && mouse.Y < 400 + 96)
            {

            }

            if (mouse.X >= 100 && mouse.Y >= 100 && mouse.X < 100 + 96 && mouse.Y < 100 + 96)
            {

            }
        }
    }
}
