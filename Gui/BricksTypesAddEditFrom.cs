using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickWorks
{
    public partial class BricksTypesAddEditFrom : MetroFramework.Forms.MetroForm
    {
        Brick brick;
        public BricksTypesAddEditFrom(Brick obj)
        {
            InitializeComponent();
            brick = obj;
            brickBindingSource.DataSource = brick;
        }

        private void mbtSave_Click(object sender, EventArgs e)
        {
            if (mtbMark.Text.Trim().Length==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не указана марка кирпича",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(mtbLenght.Text)==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не указана длина кирпича",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(mtbHeight.Text)==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не указана высота кирпича",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(mtbWidth.Text)==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не указана ширина кирпича",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
