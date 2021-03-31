using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CalcTratamento
    {
        public CalcTratamento()
        {
            /*VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya - v));
            Cleantext.Text = Convert.ToString((VCHoya - v) + CE);
            Notext.Text = Convert.ToString((VCHoya - v) + No);
            NOBCtext.Text = Convert.ToString((VCHoya - v) + Nobc);
            BCLongtext.Text = Convert.ToString((VCHoya - v) + BClong);
            Clipboard.SetText(VPS.Text);*/
        }

        public double Validação(string basedecalc, double trat_1, double trat_2, double trat_3, double trat_4,int x)
        {
            double resl;
            double v=0;
            
            if (x==1) { v = trat_1; }
            else if (x==2) { v = trat_2; }
            else if (x==3) { v = trat_3; }
            else if (x==4){  v = trat_4; }

            resl = double.Parse(basedecalc);
            resl = (resl - v) / 2;

            return resl;

        }
        public void Calc(string valorbase,int x)
        {

            Validação(valorbase, Properties.Settings.Default.DvChrome,
                Properties.Settings.Default.DvSilver, Properties.Settings.Default.DVPlatinum, Properties.Settings.Default.DvBlueProtect,x);

        }
    }
}
