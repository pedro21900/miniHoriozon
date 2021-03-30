using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }
        public int x;
        private void Calcular_Click(object sender, EventArgs e)
        {
            float ch, resl1, co, c2;
            ch = float.Parse(textBox1.Text);
            resl1 = ch / 2;
            co = ch;
            textBox2.Text = Convert.ToString(resl1);
            textBox3.Text = Convert.ToString(co + 330);
            textBox4.Text = Convert.ToString(co + 550);
            textBox5.Text = Convert.ToString(co + 700);
            textBox6.Text = Convert.ToString(co + 750);
            c2 = resl1 * 2;
            textBox7.Text = Convert.ToString(ch);
            Clipboard.SetText(textBox2.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float bp, resl4, co;
            bp = float.Parse(textBox1.Text);
            resl4 = (bp - 750) / 2;
            textBox2.Text = Convert.ToString(resl4);
            textBox3.Text = Convert.ToString((bp - 750) + 330);
            textBox4.Text = Convert.ToString((bp - 750) + 550);
            textBox5.Text = Convert.ToString((bp - 750) + 700);
            textBox6.Text = Convert.ToString(bp);
            co = resl4 * 2;
            textBox7.Text = Convert.ToString(co);
            Clipboard.SetText(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pl, resl3, co;
            pl = float.Parse(textBox1.Text);
            resl3 = (pl - 700) / 2;
            textBox2.Text = Convert.ToString(resl3);
            textBox3.Text = Convert.ToString((pl - 700) + 330);
            textBox4.Text = Convert.ToString((pl - 700) + 550);
            textBox5.Text = Convert.ToString(pl);
            textBox6.Text = Convert.ToString((pl - 700) + 750);
            co = resl3 * 2;
            textBox7.Text = Convert.ToString(co);
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float si, resl2, co;
            si = float.Parse(textBox1.Text);
            resl2 = (si - 550) / 2;
            textBox2.Text = Convert.ToString(resl2);
            textBox3.Text = Convert.ToString((si - 550) + 330);
            textBox4.Text = Convert.ToString(si);
            textBox5.Text = Convert.ToString((si - 550) + 700);
            textBox6.Text = Convert.ToString((si - 550) + 750);
            co = resl2 * 2;
            textBox7.Text = Convert.ToString(co);
            Clipboard.SetText(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float ch, resl1, co, c2;
            ch = float.Parse(textBox1.Text);
            resl1 = (ch - 330) / 2;
            co = ch - 330;
            textBox2.Text = Convert.ToString(resl1);
            textBox3.Text = Convert.ToString(ch);
            textBox4.Text = Convert.ToString(co + 550);
            textBox5.Text = Convert.ToString(co + 700);
            textBox6.Text = Convert.ToString(co + 750);
            c2 = resl1 * 2;
            textBox7.Text = Convert.ToString(c2);
            Clipboard.SetText(textBox2.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            float sar, resl, co;
            sar = float.Parse(textBox13.Text);
            resl = sar / 2;
            textBox9.Text = Convert.ToString(resl);
            textBox14.Text = Convert.ToString(sar + 460);
            textBox12.Text = Convert.ToString(sar + 660);
            textBox11.Text = Convert.ToString(sar + 660);
            textBox10.Text = Convert.ToString(sar + 860);
            co = resl * 2;
            textBox8.Text = Convert.ToString(co);
            Clipboard.SetText(textBox9.Text);
            this.AcceptButton = b2;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            float resl4, co, s2, sh2, sdb, xtc, tbxtc;
            s2 = 460;
            sh2 = 660;
            sdb = 660;
            xtc = 860;
            tbxtc = float.Parse(textBox13.Text);
            resl4 = (tbxtc - xtc) / 2;
            textBox9.Text = Convert.ToString(resl4);
            textBox14.Text = Convert.ToString((tbxtc - xtc) + s2);
            textBox12.Text = Convert.ToString((tbxtc - xtc) + sh2);
            textBox11.Text = Convert.ToString((tbxtc - xtc) + sdb);
            textBox10.Text = Convert.ToString(tbxtc);
            co = resl4 * 2;
            textBox8.Text = Convert.ToString(co);
            Clipboard.SetText(textBox9.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            float resl4, co, s2, sh2, sdb, xtc, bsdb;
            s2 = 460;
            sh2 = 660;
            sdb = 660;
            xtc = 860;
            bsdb = float.Parse(textBox13.Text);
            resl4 = (bsdb - 660) / 2;
            textBox9.Text = Convert.ToString(resl4);
            textBox14.Text = Convert.ToString((bsdb - sdb) + s2);
            textBox12.Text = Convert.ToString((bsdb - sdb) + sh2);
            textBox10.Text = Convert.ToString((bsdb - sdb) + xtc);
            textBox11.Text = Convert.ToString(bsdb);
            co = resl4 * 2;
            textBox8.Text = Convert.ToString(co);
            Clipboard.SetText(textBox9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float si, resl2, co, s2, sh2, sdb, xtc;
            si = float.Parse(textBox13.Text);
            resl2 = (si - 660) / 2;
            s2 = 460;
            sh2 = 660;
            sdb = 660;
            xtc = 860;
            textBox9.Text = Convert.ToString(resl2);
            textBox14.Text = Convert.ToString((si - sh2) + s2);
            textBox12.Text = Convert.ToString(si);
            textBox11.Text = Convert.ToString((si - sh2) + sdb);
            textBox10.Text = Convert.ToString((si - sh2) + xtc);
            co = resl2 * 2;
            textBox8.Text = Convert.ToString(co);
            Clipboard.SetText(textBox9.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float ch, resl1, co, c2;
            ch = float.Parse(textBox13.Text);
            resl1 = (ch - 460) / 2;
            co = ch - 460;
            textBox9.Text = Convert.ToString(resl1);
            textBox14.Text = Convert.ToString(ch);
            textBox12.Text = Convert.ToString(co + 660);
            textBox11.Text = Convert.ToString(co + 660);
            textBox10.Text = Convert.ToString(co + 860);
            c2 = resl1 * 2;
            textBox8.Text = Convert.ToString(c2);
            Clipboard.SetText(textBox9.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double resl4, CE, No, Nobc, BClong, VCHoya, v;
            CE = 196.90;
            No = 548.90;
            Nobc = 548.90;
            BClong = 886.60;
            v = CE;
            VCHoya = double.Parse(VCHoyatext.Text);
            resl4 = (VCHoya - v) / 2;
            VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya - v));
            Cleantext.Text = Convert.ToString((VCHoya - v) + CE);
            Notext.Text = Convert.ToString((VCHoya - v) + No);
            NOBCtext.Text = Convert.ToString((VCHoya - v) + Nobc);
            BCLongtext.Text = Convert.ToString((VCHoya - v) + BClong);
            Clipboard.SetText(VPS.Text);
        }
        private void BCLong_Click(object sender, EventArgs e)
        {
            double resl4, CE, No, Nobc, BClong, VCHoya, v;
            CE = 196.90;
            No = 548.90;
            Nobc = 548.90;
            BClong = 886.60;
            v = BClong;
            VCHoya = double.Parse(VCHoyatext.Text);
            resl4 = (VCHoya - v) / 2;
            VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya - v));
            Cleantext.Text = Convert.ToString((VCHoya - v) + CE);
            Notext.Text = Convert.ToString((VCHoya - v) + No);
            NOBCtext.Text = Convert.ToString((VCHoya - v) + Nobc);
            BCLongtext.Text = Convert.ToString((VCHoya - v) + BClong);
            Clipboard.SetText(VPS.Text);
        }

        private void NoBC_Click(object sender, EventArgs e)
        {
            double resl4, CE, No, Nobc, BClong, VCHoya, v;
            CE = 196.90;
            No = 548.90;
            Nobc = 548.90;
            BClong = 886.60;
            v = Nobc;
            VCHoya = double.Parse(VCHoyatext.Text);
            resl4 = (VCHoya - v) / 2;
            VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya - v));
            Cleantext.Text = Convert.ToString((VCHoya - v) + CE);
            Notext.Text = Convert.ToString((VCHoya - v) + No);
            NOBCtext.Text = Convert.ToString((VCHoya - v) + Nobc);
            BCLongtext.Text = Convert.ToString((VCHoya - v) + BClong);
            Clipboard.SetText(VPS.Text);
        }

        private void No_Click(object sender, EventArgs e)
        {
            double resl4, CE, No, Nobc, BClong, VCHoya, v;
            CE = 196.90;
            No = 548.90;
            Nobc = 548.90;
            BClong = 886.60;
            v = No;
            VCHoya = double.Parse(VCHoyatext.Text);
            resl4 = (VCHoya - v) / 2;
            VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya - v));
            Cleantext.Text = Convert.ToString((VCHoya - v) + CE);
            Notext.Text = Convert.ToString((VCHoya - v) + No);
            NOBCtext.Text = Convert.ToString((VCHoya - v) + Nobc);
            BCLongtext.Text = Convert.ToString((VCHoya - v) + BClong);
            Clipboard.SetText(VPS.Text);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            double resl4, VCEssi, TE, CE, CF, CP, v;
            TE = 243;
            CE = 408;
            CF = 849;
            CP = 954;
            v = TE;
            VCEssi = double.Parse(VCEssilor.Text);
            resl4 = (VCEssi - v) / 2;
            VPS4.Text = Convert.ToString(resl4);
            VSar4.Text = Convert.ToString((VCEssi - v));
            a41.Text = Convert.ToString((VCEssi - v) + TE);
            a42.Text = Convert.ToString((VCEssi - v) + CE);
            a43.Text = Convert.ToString((VCEssi - v) + CF);
            a44.Text = Convert.ToString((VCEssi - v) + CP);
            Clipboard.SetText(VPS4.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double resl4, VCEssi, TE, CE, CF, CP, v;
            TE = 243;
            CE = 408;
            CF = 849;
            CP = 954;
            v = CP;
            VCEssi = double.Parse(VCEssilor.Text);
            resl4 = (VCEssi - v) / 2;
            VPS4.Text = Convert.ToString(resl4);
            VSar4.Text = Convert.ToString((VCEssi - v));
            a41.Text = Convert.ToString((VCEssi - v) + TE);
            a42.Text = Convert.ToString((VCEssi - v) + CE);
            a43.Text = Convert.ToString((VCEssi - v) + CF);
            a44.Text = Convert.ToString((VCEssi - v) + CP);
            Clipboard.SetText(VPS4.Text);
        }

        private void cforte_Click(object sender, EventArgs e)
        {
            double resl4, VCEssi, TE, CE, CF, CP, v;
            TE = 243;
            CE = 408;
            CF = 849;
            CP = 954;
            v = CF;
            VCEssi = double.Parse(VCEssilor.Text);
            resl4 = (VCEssi - v) / 2;
            VPS4.Text = Convert.ToString(resl4);
            VSar4.Text = Convert.ToString((VCEssi - v));
            a41.Text = Convert.ToString((VCEssi - v) + TE);
            a42.Text = Convert.ToString((VCEssi - v) + CE);
            a43.Text = Convert.ToString((VCEssi - v) + CF);
            a44.Text = Convert.ToString((VCEssi - v) + CP);
            Clipboard.SetText(VPS4.Text);
        }

        private void ceasy_Click(object sender, EventArgs e)
        {
            double resl4, VCEssi, TE, CE, CF, CP, v;
            TE = 243;
            CE = 408;
            CF = 849;
            CP = 954;
            v = CE;
            VCEssi = double.Parse(VCEssilor.Text);
            resl4 = (VCEssi - v) / 2;
            VPS4.Text = Convert.ToString(resl4);
            VSar4.Text = Convert.ToString((VCEssi - v));
            a41.Text = Convert.ToString((VCEssi - v) + TE);
            a42.Text = Convert.ToString((VCEssi - v) + CE);
            a43.Text = Convert.ToString((VCEssi - v) + CF);
            a44.Text = Convert.ToString((VCEssi - v) + CP);
            Clipboard.SetText(VPS4.Text);
        }

        private void Hoyacalc(object sender, EventArgs e)
        {
            double resl4, CE, No, Nobc, BClong, VCHoya;
            CE = 196.90;
            No = 548.90;
            Nobc = 548.90;
            BClong = 886.60;
            VCHoya = double.Parse(VCHoyatext.Text);
            resl4 = (VCHoya) / 2;
            VPS.Text = Convert.ToString(resl4);
            VSar.Text = Convert.ToString((VCHoya));
            Cleantext.Text = Convert.ToString(VCHoya + CE);
            Notext.Text = Convert.ToString(VCHoya + No);
            NOBCtext.Text = Convert.ToString(VCHoya + Nobc);
            BCLongtext.Text = Convert.ToString(VCHoya + BClong);
            Clipboard.SetText(VPS.Text);
        }

        private void Essilorcalc(object sender, EventArgs e)
        {
            double resl4, VCEssi, TE, CE, CF, CP, v;
            TE = 243;
            CE = 408;
            CF = 849;
            CP = 954;
            v = CP;
            VCEssi = double.Parse(VCEssilor.Text);
            resl4 = VCEssi / 2;
            VPS4.Text = Convert.ToString(resl4);
            VSar4.Text = Convert.ToString((VCEssi));
            a41.Text = Convert.ToString((VCEssi) + TE);
            a42.Text = Convert.ToString((VCEssi) + CE);
            a43.Text = Convert.ToString((VCEssi) + CF);
            a44.Text = Convert.ToString((VCEssi) + CP);
            Clipboard.SetText(VPS4.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {x = 1;}
        private void tabPage2_Click(object sender, EventArgs e)
        { x = 2;}
        private void tabPage3_Click(object sender, EventArgs e)
        { x = 3;}
        private void tabPage4_Click(object sender, EventArgs e)
        { x = 4;}
 
        private void lolazum_KeyUp(object sender, KeyEventArgs e)
        {   if (x == 1) { if (e.KeyCode == Keys.Enter) Calcular_Click(sender, e); }
            if (x == 2) { if (e.KeyCode == Keys.Enter) button7_Click(sender, e); }
            if (x == 3) { if (e.KeyCode == Keys.Enter) Hoyacalc(sender, e); }
            if (x == 4) { if (e.KeyCode == Keys.Enter) Essilorcalc(sender, e); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = 1;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            x = 2;
        }

        private void VCHoyatext_TextChanged(object sender, EventArgs e)
        {
            x = 3;
        }

        private void VCEssilor_TextChanged(object sender, EventArgs e)
        {
            x = 4;
        }

    }
}
    
