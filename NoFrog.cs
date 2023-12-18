namespace FrogsWinFormsApp
{
    public class NoFrog : Frog
    {
        private static Image image = Properties.Resources.FrogNo;
        public NoFrog(PictureBox lily) : base(lily, image)
        {

        }
    }
}
