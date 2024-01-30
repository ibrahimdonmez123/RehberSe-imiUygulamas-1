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
    public partial class SonucuGoster : Form
    {
        string ilksorucevap;
        string ikincisorucevap;
        string ucuncusorucevap;
        public SonucuGoster(string ilksorucevap, string ikincisorucevap, string ucuncusorucevap)
        {
            InitializeComponent();
            this.ilksorucevap = ilksorucevap;
            this.ikincisorucevap = ikincisorucevap;
            this.ucuncusorucevap = ucuncusorucevap;
        }

        private void SonucuGoster_Load(object sender, EventArgs e)
        {

            if (ilksorucevap == "private" && ikincisorucevap == "kısa" && ucuncusorucevap == "amerikalı")
            {
                lbl_rehberin_ismi.Text = "ali";
            }


            else if (ilksorucevap == "private" && ikincisorucevap == "kısa" && ucuncusorucevap == "ortadoğulu")
            {
                lbl_rehberin_ismi.Text = "veli";

            }


            else if (ilksorucevap == "private" && ikincisorucevap == "uzun" && ucuncusorucevap == "amerikalı")
            {
                lbl_rehberin_ismi.Text = "mehmet";

            }


            else if (ilksorucevap == "private" && ikincisorucevap == "uzun" && ucuncusorucevap == "ortadoğulu")
            {
                lbl_rehberin_ismi.Text = "ahmet";

            }


            else if (ilksorucevap == "grup" && ikincisorucevap == "kısa" && ucuncusorucevap == "amerikalı")
            {
                lbl_rehberin_ismi.Text = "hasan";

            }


            else if (ilksorucevap == "grup" && ikincisorucevap == "kısa" && ucuncusorucevap == "ortadoğulu")
            {
                lbl_rehberin_ismi.Text = "yusuf";

            }


            else if (ilksorucevap == "grup" && ikincisorucevap == "uzun" && ucuncusorucevap == "amerikalı")
            {
                lbl_rehberin_ismi.Text = "ömer";

            }


            else if (ilksorucevap == "grup" && ikincisorucevap == "uzun" && ucuncusorucevap == "ortadoğulu")
            {
                lbl_rehberin_ismi.Text = "osman";

            }
        }

    }

}

