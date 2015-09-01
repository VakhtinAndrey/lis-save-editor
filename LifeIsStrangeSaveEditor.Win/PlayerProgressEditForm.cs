using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LifeIsStrangeSaveEditor.Win
{
    public partial class PlayerProgressEditForm : Form
    {
        public PlayerProgress PlayerProgress { get; set; }

        public PlayerProgressEditForm(PlayerProgress playerProgress, string caption = null)
        {
            InitializeComponent();

            PlayerProgress = playerProgress;
            if (!string.IsNullOrEmpty(caption))
                this.Text = caption;

            var ms = new MemoryStream();
            var ser = new XmlSerializer(typeof (PlayerProgress));
            ser.Serialize(ms, PlayerProgress);
            ms.Position = 0;
            var sr = new StreamReader(ms);
            var progressStr = sr.ReadToEnd();
            tbProgress.Text = progressStr;

            tbProgress.Select(0, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbProgress.Text != null)
            {
                try
                {
                    var ser = new XmlSerializer(typeof(PlayerProgress));
                    using (var sr = new StringReader(tbProgress.Text))
                    {
                        PlayerProgress = (PlayerProgress)ser.Deserialize(sr);
                    }
                }
                catch (Exception)
                {
                    PlayerProgress = null;
                }
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (tbProgress.Text != null)
            {
                try
                {
                    var ser = new XmlSerializer(typeof(PlayerProgress));
                    using (var sr = new StringReader(tbProgress.Text))
                    {
                        ser.Deserialize(sr);
                    }
                }
                catch (Exception ex)
                {
                    PlayerProgress = null;
                    MessageBox.Show(string.Format("Invalid{0}{0}{1}", Environment.NewLine, ex.InnerException.Message));
                    return;
                }
                MessageBox.Show("Valid");
            }
        }
    }
}
