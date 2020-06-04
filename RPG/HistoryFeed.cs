using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class HistoryFeed : Form
    {
        private String textToShow;

        public HistoryFeed(String textToShow)
        {
            this.textToShow = textToShow;
            InitializeComponent();
        }

        private void HistoryFeed_Load(object sender, EventArgs e)
        {
            historyFeedText.Text = textToShow;
        }
    }
}
