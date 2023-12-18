using FrogsWinFormsApp.Properties;

namespace FrogsWinFormsApp
{
    public partial class MainForm : Form
    {
        private int numFrogs = 9;
        private List<Frog> frogs;
        private int size = 100;
        private int Y = 30;
        private int numSteps = 0;
        private string gameImmitationProgress = "LLLLERRRR";
        private string gameImmitationEnd = "RRRRELLLL";
        public MainForm()
        {
            InitializeComponent();
        }
        private PictureBox CreateField(int number)
        {
            var pictureBox = new PictureBox();
            pictureBox.Location = new Point(number * size, Y);
            pictureBox.Size = new Size(size, size);
            pictureBox.Name = number.ToString();
            pictureBox.Image = Resources.FrogNo;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Click += PictureBox_Click;

            return pictureBox;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            int status = 0;

            PictureBox clicked = (PictureBox)sender;
            int index = int.Parse(clicked.Name);
            if (frogs[index] is NoFrog)
            {
                MessageBox.Show("Вам некуда прыгать, вы нажали на пустую кувшинку");
                return;
            }
            else
            {
                for (int i = 0; i < frogs.Count; i++)
                {
                    if (frogs[i] is NoFrog)
                    {
                        frogs[index].Jump(frogs[i], out status);
                        if (status == -1)
                        {
                            MessageBox.Show("Вы не сможете прыгнуть этой лягушкой! ");
                            return;
                        }
                        ChangeGameImmitation(index, i);
                    }
                }
            }
            numSteps++;
            stepNumberLabel.Text = numSteps.ToString();
            if (CheckForEnding())
            {
                if (numSteps == 24) MessageBox.Show("Безупречно!!! МЕГАХОРОШ");
                else MessageBox.Show("Сможете выйграть за меньшее число шагов? А так ГГ ВП");
            }
        }

        private void ChangeGameImmitation(int index, int i)
        {
            var charArrTemplate = gameImmitationProgress.ToCharArray();
            var template = charArrTemplate[i];
            charArrTemplate[i] = charArrTemplate[index];
            charArrTemplate[index] = template;
            gameImmitationProgress = new string(charArrTemplate);
        }

        private void CreateField()
        {
            PictureBox pictureBox;
            int middleLilyNumber = (numFrogs - 1) / 2;
            for (int i = 0; i < middleLilyNumber; i++)
            {
                pictureBox = CreateField(i);
                Controls.Add(pictureBox);
                LeftFrog frogLeft = new LeftFrog(pictureBox);
                frogs.Add(frogLeft);
            }
            pictureBox = CreateField(middleLilyNumber);
            Controls.Add(pictureBox);
            NoFrog frog = new NoFrog(pictureBox);
            frogs.Add(frog);
            for (int i = middleLilyNumber + 1; i < numFrogs; i++)
            {
                pictureBox = CreateField(i);
                Controls.Add(pictureBox);
                RightFrog frogRight = new RightFrog(pictureBox);
                frogs.Add(frogRight);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frogs = new List<Frog>();
            CreateField();
        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gameRules = "Лягушки!\nНажимаете на лягушку чтобы она прыгнула!\n" +
                "Прыгает она либо на соседнюю либо через другую лягушку\n" +
                "Нельзя прыгать через 2 и более лягушки!\n" +
                "Желаем сделать минимальное число ходов!!!";
            MessageBox.Show(gameRules);
        }
        private bool CheckForEnding()
        {
            return gameImmitationProgress == gameImmitationEnd;
        }
    }
}