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
    public partial class UcuncuSoru : Form
    {
        string ilksorucevap = null;
        string ikincisorucevap = null;
        public UcuncuSoru( string ilksorucevap , string ikincisorucevap)
        {
            InitializeComponent();
            this.ilksorucevap = ilksorucevap;   
            this.ikincisorucevap=ikincisorucevap;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ucuncusorucevap = null;

            if (checkBox_amerikali.Checked ) 
            {
                ucuncusorucevap = "amerikalı";
            }
            else if (checkBox_ortadogulu.Checked ) 
            {
                ucuncusorucevap = "ortadoğulu";
            }

            SonucuGoster sonucugoster = new SonucuGoster(ilksorucevap , ikincisorucevap , ucuncusorucevap);
            sonucugoster.Show();
            this.Hide();

        }
    }
}
