namespace FrogsWinFormsApp
{
    public class Frog
    {
        protected PictureBox lily;
        private int lilyLocationX;
        private int maxLilyDistance = 200;
        public Frog(PictureBox lily, Image image)
        {
            this.lily = lily;
            this.lily.Image = image;
            lilyLocationX = lily.Location.Y;
        }
        public void Jump(Frog emptyLily,out int status)
        {
            if(Math.Abs(lily.Location.X - emptyLily.lily.Location.X) > maxLilyDistance)
            {
                status = -1;
                return;
            }
            int template = lily.Location.X;
            lily.Location = new Point(emptyLily.lily.Location.X, lilyLocationX);
            emptyLily.lily.Location = new Point(template, lilyLocationX);
            lily.Refresh();
            status = 1;
        }
    }
}
