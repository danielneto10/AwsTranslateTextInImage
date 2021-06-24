using AwsTranslateTextInImage.Controllers;
using AwsTranslateTextInImage.Models.AwsServices;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsTranslateTextInImage
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> languagesFrom = new Dictionary<string, string>()
        {
            {"auto", "Auto" }, {"pt", "Português" }, {"en", "Inglês"}, {"ja", "Japonês"}, {"es", "Espanhol"}, {"de", "Alemão"}
        };

        Dictionary<string, string> languagesTo = new Dictionary<string, string>()
        {
            {"pt", "Português" }, {"en", "Inglês"}, {"ja", "Japonês"}, {"es", "Espanhol"}, {"de", "Alemão"}
        };

        public Form1()
        {
            InitializeComponent();
            LoadDataS3();
            LoadDataTranslate();
        }

        private async void LoadDataS3()
        {
            cbListBucket.Items.Clear();
            try
            {
                foreach (var bucket in await new S3Service().GetBuckets())
                {
                    cbListBucket.Items.Add(bucket.BucketName);
                }
                cbListBucket.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataTranslate()
        {
            cbFrom.DataSource = new BindingSource(languagesFrom, null);
            cbTo.DataSource = new BindingSource(languagesTo, null);

            cbFrom.DisplayMember = "Value";
            cbTo.DisplayMember = "Value";

            cbFrom.ValueMember = "Key";
            cbTo.ValueMember = "Key";

            cbFrom.SelectedIndex = 0;
            cbTo.SelectedIndex = 0;
        }

        private void btnReloadBucket_Click(object sender, EventArgs e)
        {
            LoadDataS3();
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            openFileImg.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (openFileImg.ShowDialog() == DialogResult.OK)
            {
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImg.Load(openFileImg.FileName);
                txtImgPath.Text = openFileImg.FileName;
                btnTranslate.Enabled = true;
            };
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                #region Mudar Controles
                txtStatus.Text = "Translating the text";
                progressBar1.Value = 0;
                progressBar1.Style = ProgressBarStyle.Marquee;
                btnTranslate.Enabled = false;
                btnOpenImg.Enabled = false;
                btnReloadBucket.Enabled = false;
                rtbTranslatedText.Clear();
                #endregion

                AwsController controller = new AwsController();
                string text = await controller.GetTextInImage(openFileImg.FileName, cbListBucket.SelectedItem.ToString());
                string translatedText = await controller.GetTranslatedText(text, cbFrom.SelectedValue.ToString(), cbTo.SelectedValue.ToString());

                #region Mudar Controles
                txtStatus.Text = "Finished";
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 100;
                btnTranslate.Enabled = true;
                btnOpenImg.Enabled = true;
                btnReloadBucket.Enabled = true;
                #endregion

                rtbTranslatedText.AppendText(translatedText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
