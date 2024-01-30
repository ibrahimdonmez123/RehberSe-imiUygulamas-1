using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberSeçimiUygulaması1
{
    public partial class IkinciSoru : Form
    {
        string ilksorucevap = null;
        public IkinciSoru(string ilksorucevap)
        {
            InitializeComponent();
            this.ilksorucevap = ilksorucevap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ikincisorucevap = null;
            
            if( checkBox_kisa.Checked)
            {
                ikincisorucevap = "kısa";
            }
            else if (checkBox_uzun.Checked)
            {
                ikincisorucevap = "uzun";
            }
          

            UcuncuSoru ucuncusoru = new UcuncuSoru(ilksorucevap , ikincisorucevap);
            ucuncusoru.Show();
            this.Hide();
        }
    }
}
