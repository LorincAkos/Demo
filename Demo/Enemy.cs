namespace Demo
{
    internal class Enemy
    {

        public Image enemy { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enemy(int Xpos)
        {
            enemy = Image.FromFile(@"Images\\E1.gif");
            if (Xpos > 500)
            {
                X = (Xpos - 500);
            }
            else 
            {
                X = Xpos;
            }
            
            Y = -30;
        }
    }
}
