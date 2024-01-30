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
    public partial class IlkSoru : Form
    {
        public IlkSoru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ilksorucevap = null;

            if(checkBox_private.Checked) 
            {
                ilksorucevap = "private";
            }

            else if (checkBox_grup.Checked) 
            {
                ilksorucevap = "grup";
            }

            IkinciSoru ikincisoru = new IkinciSoru(ilksorucevap); 
            ikincisoru.Show();
            this.Hide();

        }
    }
}
