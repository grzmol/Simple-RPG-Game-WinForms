using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class RPG : Form
    {
        private const int MELEE_DEFAULT_DAMAGE = 90;
        private const int MAGIC_DEFAULT_DAMAGE = 120;


        private const String ATTACK_TYPE_MELEE = "MELEE";
        private const String ATTACK_TYPE_MAGIC = "MAGIC";
        private const String DEFEND = "DEFEND";


        public RPG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void performAttack(String attackType)
        {

            switch (attackType)
            {
                case ATTACK_TYPE_MELEE:
                    battleLogFeed.AppendText($"[{getLogTime()}]  Zadano {getFinalDamage(MELEE_DEFAULT_DAMAGE)} obrażeń fizycznych. {Environment.NewLine}");
                    break;
                case ATTACK_TYPE_MAGIC:
                    battleLogFeed.AppendText($"[{getLogTime()}]  Zadano {getFinalDamage(MAGIC_DEFAULT_DAMAGE)} obrażeń magicznych. {Environment.NewLine}");
                    break;
                case DEFEND:
                    battleLogFeed.AppendText($"[{getLogTime()}]  Podniesiono gardę (0 obrażeń). {Environment.NewLine}");
                    break;
            }
        }

        private int getFinalDamage(int inputDamage)
        {
            int critPercent = (int)critMultiplier.Value;
            int rnd = new Random().Next(0, 100);

            if (rnd < critPercent)
            {
                return inputDamage * 2;
            }
            return inputDamage;
        }

        private String getLogTime()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }



        private void attackMeleeButton_Click(object sender, EventArgs e)
        {
            performAttack(ATTACK_TYPE_MELEE);
        }

        private void attackMagicButton_Click(object sender, EventArgs e)
        {
            performAttack(ATTACK_TYPE_MAGIC);
        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            performAttack(DEFEND);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            new HistoryFeed(battleLogFeed.Text).ShowDialog();
        }

        private void RPG_KeyUp(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyCode);
            switch (e.KeyCode)
            {
                case Keys.Q:
                    attackMeleeButton_Click(null, null);
                    break;
                case Keys.W:
                    attackMagicButton_Click(null, null);
                    break;
                case Keys.E:
                    defendButton_Click(null, null);
                    break;
            }
        }

        private void RPG_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = MessageBox.Show("Czy na pewno chcesz opuścić program?",
                         "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
