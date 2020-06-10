using System;
using System.Drawing;
using System.Windows.Forms;
using GradedImageConversions.Filters;

namespace GradedImageConversions
{    
    public partial class Form1 : Form
    {
        private const string CHOOSE_IMAGE_MSG = "Выберите изображение...";
        private const char DOUBLE_POINT = ',';

        private IFilterable filter;
        public Form1()
        {
            InitializeComponent();
            filter = FilterFabrica.createFilter(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showInfoMessage(CHOOSE_IMAGE_MSG);
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            if (src_pic_box.Image == null)
            {
                showInfoMessage(CHOOSE_IMAGE_MSG);
                return;
            }
            hideErrorMessage();

            res_pic_box.Image = filter.convertImage(src_pic_box.Image, aTextBox.Text, bTextBox.Text, darkCheckBox.Checked);                 
        }
        
        private void negativeBtn_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(Filter.NEGATIVE);
        }

        private void logBtn_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(Filter.LOG);
        }

        private void gammaBtn_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(Filter.GAMMA);
        }

        private void monochromeBtn_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(Filter.MONOCHROME);
        }

        private void brightBtn_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(Filter.BRIGHT);
        }

        private void setFilter(Filter f)
        {
            filter = FilterFabrica.createFilter(f);
            hideAllElsFilter();
            if (string.IsNullOrEmpty(filter.getFirstParamName()))
            {
                return;
            }
            setText(aTextBox, aLabel, filter.getFirstParamName());


            if (string.IsNullOrEmpty(filter.getSecondParamName()))
            {
                return;
            }
            setText(bTextBox, bLabel, filter.getSecondParamName());

            darkCheckBox.Visible = filter.hasDarknessParam(); 
        }

        private void setText(TextBox textBox, Label label, string val)
        {
            label.Text = val;
            label.Visible = true;
            textBox.Text = "";
            textBox.Visible = true;
        }

        private void hideAllElsFilter()
        {
            darkCheckBox.Visible = false;
            aLabel.Visible = false;
            bLabel.Visible = false;
            aTextBox.Visible = false;
            bTextBox.Visible = false;
        }

        private void aTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isHandled(e, aTextBox.Text);
        }

        private void bTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isHandled(e, bTextBox.Text);
        }

        private bool isHandled(KeyPressEventArgs e, string text)
        {
            if(e.KeyChar == '.')
            {
                e.KeyChar = DOUBLE_POINT;
            }
            char value = e.KeyChar;
            return !(Char.IsDigit(value) || (value == DOUBLE_POINT && text.IndexOf(DOUBLE_POINT)==-1) || value == 8);
        }
        
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                hideErrorMessage();
                try
                {
                    src_pic_box.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    showInfoMessage("Невозможно открыть выбранный файл");
                }
            }
        }

        private void showInfoMessage(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void hideErrorMessage()
        {
            if(errorLabel.Visible == false)
            {
                return;
            }
            errorLabel.Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (res_pic_box.Image == null)
            {
                showInfoMessage("Преобразуйте изображение...");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить изображение как...";
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    res_pic_box.Image.Save(sfd.FileName);
                }
                catch
                {
                    showInfoMessage("Невозможно сохранить изображение");
                }
            }
            
        }
    }
}
