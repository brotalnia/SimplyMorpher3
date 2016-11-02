using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyMorpher
{
    public partial class Presets : Form
    {
        public string ReturnValue { get; set; }
        string previousid;
        bool retried = false;
        public Presets(string previousid)
        {
            InitializeComponent();
            this.previousid = previousid;
        }
        /*public int Rand(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }*/
        public void ReturnID(string displayid)
        {
            // The point of this mess is to try again if we get the same displayid as last time.
            if ((previousid != displayid) || retried)
            {
                ReturnValue = displayid;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                retried = true;
                object[] para = new object[2];
                System.Reflection.MethodBase lastmethod = new System.Diagnostics.StackFrame(1).GetMethod();
                if (lastmethod.Name.Contains("btn"))
                    lastmethod.Invoke(this, para);
                else
                    ReturnID(displayid);
            }
        }
        private void btnIlidan_Click(object sender, EventArgs e)
        {
            ReturnID("21137");
        }

        private void btnLichKing_Click(object sender, EventArgs e)
        {
            ReturnID("22234");
        }

        private void btnArthasEvil_Click(object sender, EventArgs e)
        {
            ReturnID("22235");
        }

        private void btnArthasGood_Click(object sender, EventArgs e)
        {
            ReturnID("21976");
        }

        private void btnTeron_Click(object sender, EventArgs e)
        {
            ReturnID("21576");
        }

        private void btnSylvanasOld_Click(object sender, EventArgs e)
        {
            ReturnID("11657");
        }

        private void btnSylvanasNew_Click(object sender, EventArgs e)
        {
            ReturnID("28213");
        }

        private void btnAlexstrasza_Click(object sender, EventArgs e)
        {
            ReturnID("28227");
        }

        private void btnMedivh_Click(object sender, EventArgs e)
        {
            ReturnID("18718");
        }

        private void btnKael_Click(object sender, EventArgs e)
        {
            ReturnID("22574");
        }

        private void btnKael2_Click(object sender, EventArgs e)
        {
            ReturnID("22906");
        }

        private void btnTirion_Click(object sender, EventArgs e)
        {
            ReturnID("22209");
        }

        private void btnVarian_Click(object sender, EventArgs e)
        {
            ReturnID("28127");
        }

        private void btnAkama_Click(object sender, EventArgs e)
        {
            ReturnID("20681");
        }

        private void btnRexxar_Click(object sender, EventArgs e)
        {
            ReturnID("20918");
        }

        private void btnJaina_Click(object sender, EventArgs e)
        {
            ReturnID("30863");
        }

        private void btnHumanMale_Click(object sender, EventArgs e)
        {
            ReturnID("19723");
        }

        private void btnHumanFemale_Click(object sender, EventArgs e)
        {
            ReturnID("19724");
        }

        private void btnDwarfMale_Click(object sender, EventArgs e)
        {
            ReturnID("20317");
        }

        private void btnDwarfFemale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 23))
            {
                case 1:
                    ReturnID("13250");
                    break;
                case 2:
                    ReturnID("13317");
                    break;
                case 3:
                    ReturnID("28200");
                    break;
                case 4:
                    ReturnID("13352");
                    break;
                case 5:
                    ReturnID("16390");
                    break;
                case 6:
                    ReturnID("13372");
                    break;
                case 7:
                    ReturnID("13380");
                    break;
                case 8:
                    ReturnID("13387");
                    break;
                case 9:
                    ReturnID("21809");
                    break;
                case 10:
                    ReturnID("21813");
                    break;
                case 11:
                    ReturnID("21815");
                    break;
                case 12:
                    ReturnID("24539");
                    break;
                case 13:
                    ReturnID("24540");
                    break;
                case 14:
                    ReturnID("24739");
                    break;
                case 15:
                    ReturnID("24866");
                    break;
                case 16:
                    ReturnID("25019");
                    break;
                case 17:
                    ReturnID("25162");
                    break;
                case 18:
                    ReturnID("27274");
                    break;
                case 19:
                    ReturnID("28138");
                    break;
                case 20:
                    ReturnID("28964");
                    break;
                case 21:
                    ReturnID("29014");
                    break;
                case 22:
                    ReturnID("30194");
                    break;
                case 23:
                    ReturnID("30605");
                    break;
            }
        }

        private void btnGnomeMale_Click(object sender, EventArgs e)
        {
            ReturnID("20580");
        }

        private void btnGnomeFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20581");
        }

        private void btnNightElfMale_Click(object sender, EventArgs e)
        {
            ReturnID("20318");
        }

        private void btnNightElfFemale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 17))
            {
                case 1:
                    ReturnID("29739");
                    break;
                case 2:
                    ReturnID("16084");
                    break;
                case 3:
                    ReturnID("30861");
                    break;
                case 4:
                    ReturnID("23050");
                    break;
                case 5:
                    ReturnID("21022");
                    break;
                case 6:
                    ReturnID("16959");
                    break;
                case 7:
                    ReturnID("19881");
                    break;
                case 8:
                    ReturnID("20420");
                    break;
                case 9:
                    ReturnID("20992");
                    break;
                case 10:
                    ReturnID("21091");
                    break;
                case 11:
                    ReturnID("21136");
                    break;
                case 12:
                    ReturnID("25060");
                    break;
                case 13:
                    ReturnID("27128");
                    break;
                case 14:
                    ReturnID("27168");
                    break;
                case 15:
                    ReturnID("27893");
                    break;
                case 16:
                    ReturnID("28190");
                    break;
                case 17:
                    ReturnID("24935");
                    break;
            }
        }

        private void btnOrcMale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 12))
            {
                case 1:
                    ReturnID("22963");
                    break;
                case 2:
                    ReturnID("25020");
                    break;
                case 3:
                    ReturnID("12810");
                    break;
                case 4:
                    ReturnID("29090");
                    break;
                case 5:
                    ReturnID("28201");
                    break;
                case 6:
                    ReturnID("28181");
                    break;
                case 7:
                    ReturnID("23008");
                    break;
                case 8:
                    ReturnID("23041");
                    break;
                case 9:
                    ReturnID("23198");
                    break;
                case 10:
                    ReturnID("18669");
                    break;
                case 11:
                    ReturnID("21249");
                    break;
                case 12:
                    ReturnID("24073");
                    break;
            }
        }

        private void btnOrcFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20316");
        }

        private void btnTrollMale_Click(object sender, EventArgs e)
        {
            ReturnID("20321");
        }

        private void btnTrollFemale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 18))
            {
                case 1:
                    ReturnID("15579");
                    break;
                case 2:
                    ReturnID("28187");
                    break;
                case 3:
                    ReturnID("30006");
                    break;
                case 4:
                    ReturnID("12677");
                    break;
                case 5:
                    ReturnID("15841");
                    break;
                case 6:
                    ReturnID("16299");
                    break;
                case 7:
                    ReturnID("16337");
                    break;
                case 8:
                    ReturnID("19428");
                    break;
                case 9:
                    ReturnID("21315");
                    break;
                case 10:
                    ReturnID("21458");
                    break;
                case 11:
                    ReturnID("23448");
                    break;
                case 12:
                    ReturnID("24093");
                    break;
                case 13:
                    ReturnID("24776");
                    break;
                case 14:
                    ReturnID("28630");
                    break;
                case 15:
                    ReturnID("28702");
                    break;
                case 16:
                    ReturnID("28852");
                    break;
                case 17:
                    ReturnID("29116");
                    break;
                case 18:
                    ReturnID("11162");
                    break;
            }
        }

        private void btnTaurenMale_Click(object sender, EventArgs e)
        {
            ReturnID("20585");
        }

        private void btnTaurenFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20584");
        }

        private void btnBloodElfMale_Click(object sender, EventArgs e)
        {
            ReturnID("20578");
        }

        private void btnBloodElfFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20579");
        }

        private void btnFelOrcMale_Click(object sender, EventArgs e)
        {
            ReturnID("21267");
        }

        private void btnBrokenMale_Click(object sender, EventArgs e)
        {
            ReturnID("21105");
        }

        private void btnUndeadMale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID("28193");
                    break;
                case 2:
                    ReturnID("30000");
                    break;
                case 3:
                    ReturnID("27257");
                    break;
                case 4:
                    ReturnID("30878");
                    break;
                case 5:
                    ReturnID("30694");
                    break;
                case 6:
                    ReturnID("22960");
                    break;
                case 7:
                    ReturnID("15722");
                    break;
                case 8:
                    ReturnID("15284");
                    break;
            }
        }

        private void btnUndeadFemale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 6))
            {
                case 1:
                    ReturnID("23112");
                    break;
                case 2:
                    ReturnID("28191");
                    break;
                case 3:
                    ReturnID("30691");
                    break;
                case 4:
                    ReturnID("15725");
                    break;
                case 5:
                    ReturnID("21751");
                    break;
                case 6:
                    ReturnID("15286");
                    break;
            }
        }

        private void btnGoblinMale_Click(object sender, EventArgs e)
        {
            ReturnID("20582");
        }

        private void btnGoblinFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20583");
        }

        private void btnDraeneiMale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 11))
            {
                case 1:
                    ReturnID("23052");
                    break;
                case 2:
                    ReturnID("29997");
                    break;
                case 3:
                    ReturnID("29089");
                    break;
                case 4:
                    ReturnID("31474");
                    break;
                case 5:
                    ReturnID("18637");
                    break;
                case 6:
                    ReturnID("22956");
                    break;
                case 7:
                    ReturnID("22958");
                    break;
                case 8:
                    ReturnID("22974");
                    break;
                case 9:
                    ReturnID("23064");
                    break;
                case 10:
                    ReturnID("18560");
                    break;
                case 11:
                    ReturnID("31194");
                    break;
            }
        }

        private void btnDraeneiFemale_Click(object sender, EventArgs e)
        {
            ReturnID("20323");
        }

        private void Presets_Load(object sender, EventArgs e)
        {
            //label2.Location = new Point(this.Size.Width / 2 - label2.Size.Width / 2, label2.Location.Y);
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnGnoll_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 5))
            {
                case 1:
                    ReturnID("174");
                    break;
                case 2:
                    ReturnID("175");
                    break;
                case 3:
                    ReturnID("204");
                    break;
                case 4:
                    ReturnID("551");
                    break;
                case 5:
                    ReturnID("986");
                    break;
            }
        }

        private void btnKobold_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("139");
                    break;
                case 2:
                    ReturnID("163");
                    break;
            }
        }

        private void btnTrogg_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("160");
                    break;
                case 2:
                    ReturnID("4905");
                    break;
            }
        }

        private void btnHarpy_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 3))
            {
                case 1:
                    ReturnID("6812");
                    break;
                case 2:
                    ReturnID("6814");
                    break;
                case 3:
                    ReturnID("10877");
                    break;
            }
        }

        private void btnArakkoa_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 6))
            {
                case 1:
                    ReturnID("18728");
                    break;
                case 2:
                    ReturnID("18517");
                    break;
                case 3:
                    ReturnID("18518");
                    break;
                case 4:
                    ReturnID("18632");
                    break;
                case 5:
                    ReturnID("18633");
                    break;
                case 6:
                    ReturnID("18635");
                    break;
            }
        }

        private void btnFurbolg_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 5))
            {
                case 1:
                    ReturnID("145");
                    break;
                case 2:
                    ReturnID("1010");
                    break;
                case 3:
                    ReturnID("3024");
                    break;
                case 4:
                    ReturnID("6824");
                    break;
                case 5:
                    ReturnID("16861");
                    break;
            }
        }

        private void btnWolvar_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("25376");
                    break;
                case 2:
                    ReturnID("25379");
                    break;
                case 3:
                    ReturnID("25380");
                    break;
                case 4:
                    ReturnID("25381");
                    break;
            }
        }

        private void btnWorgen_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 3))
            {
                case 1:
                    ReturnID("202");
                    break;
                case 2:
                    ReturnID("203");
                    break;
                case 3:
                    ReturnID("729");
                    break;
            }
        }

        private void btnMurloc_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("188");
                    break;
                case 2:
                    ReturnID("3615");
                    break;
                case 3:
                    ReturnID("757");
                    break;
                case 4:
                    ReturnID("540");
                    break;
            }
        }

        private void btnValkyr_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("24991");
                    break;
                case 2:
                    ReturnID("26096");
                    break;
            }
        }

        private void btnGhoul_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID("137");
                    break;
                case 2:
                    ReturnID("828");
                    break;
                case 3:
                    ReturnID("987");
                    break;
                case 4:
                    ReturnID("1065");
                    break;
                case 5:
                    ReturnID("24992");
                    break;
                case 6:
                    ReturnID("24993");
                    break;
                case 7:
                    ReturnID("24994");
                    break;
                case 8:
                    ReturnID("24995");
                    break;
            }
        }

        private void btnGeist_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 3))
            {
                case 1:
                    ReturnID("24579");
                    break;
                case 2:
                    ReturnID("25286");
                    break;
                case 3:
                    ReturnID("25287");
                    break;
            }
        }

        private void btnSkeleton_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID("9783");
                    break;
                case 2:
                    ReturnID("9784");
                    break;
                case 3:
                    ReturnID("9785");
                    break;
                case 4:
                    ReturnID("9786");
                    break;
                case 5:
                    ReturnID(Program.Rand(27552, 27553).ToString());
                    break;
                case 6:
                    ReturnID("27511");
                    break;
                case 7:
                    ReturnID(Program.Rand(22798, 22799).ToString());
                    break;
                case 8:
                    ReturnID("7550");
                    break;
            }
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            ReturnID("16197");
        }

        private void btnAbomination_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 3))
            {
                case 1:
                    ReturnID("1061");
                    break;
                case 2:
                    ReturnID("14692");
                    break;
                case 3:
                    ReturnID("24812");
                    break;
            }
        }

        private void btnNagaMale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 6))
            {
                case 1:
                    ReturnID("21251");
                    break;
                case 2:
                    ReturnID("4762");
                    break;
                case 3:
                    ReturnID("4763");
                    break;
                case 4:
                    ReturnID("4764");
                    break;
                case 5:
                    ReturnID("4765");
                    break;
                case 6:
                    ReturnID("22598");
                    break;
            }
        }

        private void btnNagaFemale_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 5))
            {
                case 1:
                    ReturnID("4972");
                    break;
                case 2:
                    ReturnID("4973");
                    break;
                case 3:
                    ReturnID("4974");
                    break;
                case 4:
                    ReturnID("4975");
                    break;
                case 5:
                    ReturnID("4976");
                    break;
            }
        }

        private void btnFelguard_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("18342");
                    break;
                case 2:
                    ReturnID("9018");
                    break;
                case 3:
                    ReturnID("9129");
                    break;
                case 4:
                    ReturnID("7970");
                    break;
            }
        }

        private void btnDoomguard_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("1912");
                    break;
                case 2:
                    ReturnID("2727");
                    break;
            }
        }

        private void btnTerrorfiend_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 5))
            {
                case 1:
                    ReturnID("17096");
                    break;
                case 2:
                    ReturnID("17097");
                    break;
                case 3:
                    ReturnID("17098");
                    break;
                case 4:
                    ReturnID("17099");
                    break;
                case 5:
                    ReturnID("17100");
                    break;
            }
        }

        private void btnWrathguard_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("19597");
                    break;
                case 2:
                    ReturnID("20040");
                    break;
                case 3:
                    ReturnID("20041");
                    break;
                case 4:
                    ReturnID("17542");
                    break;
            }
        }

        private void btnShivarra_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 5))
            {
                case 1:
                    ReturnID("21248");
                    break;
                case 2:
                    ReturnID("19586");
                    break;
                case 3:
                    ReturnID("19587");
                    break;
                case 4:
                    ReturnID("19588");
                    break;
                case 5:
                    ReturnID("19589");
                    break;
            }
        }

        private void btnDreadlord_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("348");
                    break;
                case 2:
                    ReturnID("8609");
                    break;
                case 3:
                    ReturnID("24593");
                    break;
                case 4:
                    ReturnID("28220");
                    break;
            }
        }

        private void btnCritter_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 23))
            {
                case 1:
                    ReturnID("1141");
                    break;
                case 2:
                    ReturnID("4960");
                    break;
                case 3:
                    ReturnID("239");
                    break;
                case 4:
                    ReturnID("18515");
                    break;
                case 5:
                    ReturnID("5555");
                    break;
                case 6:
                    ReturnID("19999");
                    break;
                case 7:
                    ReturnID("19987");
                    break;
                case 8:
                    ReturnID("25390");
                    break;
                case 9:
                    ReturnID("28501");
                    break;
                case 10:
                    ReturnID("6297");
                    break;
                case 11:
                    ReturnID("6298");
                    break;
                case 12:
                    ReturnID("6300");
                    break;
                case 13:
                    ReturnID("4626");
                    break;
                case 14:
                    ReturnID("6302");
                    break;
                case 15:
                    ReturnID("19437");
                    break;
                case 16:
                    ReturnID("856");
                    break;
                case 17:
                    ReturnID("1060");
                    break;
                case 18:
                    ReturnID("347");
                    break;
                case 19:
                    ReturnID("10990");
                    break;
                case 20:
                    ReturnID("16259");
                    break;
                case 21:
                    ReturnID("21774");
                    break;
                case 22:
                    ReturnID("23902");
                    break;
                case 23:
                    ReturnID("30996");
                    break;
            }
        }

        private void btnOgre_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 12))
            {
                case 1:
                    ReturnID("415");
                    break;
                case 2:
                    ReturnID("19953");
                    break;
                case 3:
                    ReturnID("19922");
                    break;
                case 4:
                    ReturnID("19747");
                    break;
                case 5:
                    ReturnID("19926");
                    break;
                case 6:
                    ReturnID("19941");
                    break;
                case 7:
                    ReturnID("19927");
                    break;
                case 8:
                    ReturnID("19749");
                    break;
                case 9:
                    ReturnID("19939");
                    break;
                case 10:
                    ReturnID("19752");
                    break;
                case 11:
                    ReturnID("19929");
                    break;
                case 12:
                    ReturnID("19934");
                    break;
            }
        }

        private void btnTuskarr_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID("21688");
                    break;
                case 2:
                    ReturnID("28412");
                    break;
                case 3:
                    ReturnID("24374");
                    break;
                case 4:
                    ReturnID("24382");
                    break;
                case 5:
                    ReturnID("24389");
                    break;
                case 6:
                    ReturnID("24056");
                    break;
                case 7:
                    ReturnID("31014");
                    break;
                case 8:
                    ReturnID("24387");
                    break;
            }
        }

        private void btnVrykul_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID("25800");
                    break;
                case 2:
                    ReturnID("25810");
                    break;
                case 3:
                    ReturnID("25819");
                    break;
                case 4:
                    ReturnID("25827");
                    break;
                case 5:
                    ReturnID("28018");
                    break;
                case 6:
                    ReturnID("27255");
                    break;
                case 7:
                    ReturnID("22995");
                    break;
                case 8:
                    ReturnID("27409");
                    break;
            }
        }

        private void btnFrostVrykul_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 6))
            {
                case 1:
                    ReturnID("26206");
                    break;
                case 2:
                    ReturnID("25796");
                    break;
                case 3:
                    ReturnID("25797");
                    break;
                case 4:
                    ReturnID("25837");
                    break;
                case 5:
                    ReturnID("25838");
                    break;
                case 6:
                    ReturnID("25802");
                    break;
            }
        }

        private void btnEredar_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("23178");
                    break;
                case 2:
                    ReturnID("18286");
                    break;
            }
        }

        private void btnEthereal_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    switch (Program.Rand(1, 2))
                    {
                        case 1:
                            ReturnID(Program.Rand(19645, 19647).ToString());
                            break;
                        case 2:
                            ReturnID(Program.Rand(19649, 19652).ToString());
                            break;
                    }
                    break;
                case 2:
                    ReturnID(Program.Rand(20983, 20988).ToString());
                    break;
            }
        }

        private void btnIronDwarf_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 13))
            {
                case 1:
                    ReturnID("25952");
                    break;
                case 2:
                    ReturnID("25953");
                    break;
                case 3:
                    ReturnID("25954");
                    break;
                case 4:
                    ReturnID("25986");
                    break;
                case 5:
                    ReturnID("25987");
                    break;
                case 6:
                    ReturnID("25988");
                    break;
                case 7:
                    ReturnID("25989");
                    break;
                case 8:
                    ReturnID("25990");
                    break;
                case 9:
                    ReturnID("25991");
                    break;
                case 10:
                    ReturnID("25992");
                    break;
                case 11:
                    ReturnID("25993");
                    break;
                case 12:
                    ReturnID("25994");
                    break;
                case 13:
                    ReturnID("25995");
                    break;
            }
        }

        private void btnDarkIronDwarf_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 10))
            {
                case 1:
                    ReturnID("18126");
                    break;
                case 2:
                    ReturnID("21828");
                    break;
                case 3:
                    ReturnID("25233");
                    break;
                case 4:
                    ReturnID("25235");
                    break;
                case 5:
                    ReturnID("25236");
                    break;
                case 6:
                    ReturnID("4933");
                    break;
                case 7:
                    ReturnID("7790");
                    break;
                case 8:
                    ReturnID("4934");
                    break;
                case 9:
                    ReturnID("4935");
                    break;
                case 10:
                    ReturnID("4936");
                    break;
            }
        }

        private void btnFelbloodElf_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    ReturnID("31172");
                    break;
                case 2:
                    ReturnID("31173");
                    break;
            }
        }

        private void btnDarkfallenElf_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    switch (Program.Rand(1,11))
                    {
                        case 1:
                            ReturnID("25514");
                            break;
                        case 2:
                            ReturnID("26203");
                            break;
                        case 3:
                            ReturnID("26209");
                            break;
                        case 4:
                            ReturnID("26210");
                            break;
                        case 5:
                            ReturnID("23554");
                            break;
                        case 6:
                            ReturnID("31025");
                            break;
                        case 7:
                            ReturnID("31026");
                            break;
                        case 8:
                            ReturnID(Program.Rand(31028, 31034).ToString());
                            break;
                        case 9:
                            ReturnID("31037");
                            break;
                        case 10:
                            ReturnID("24880");
                            break;
                        case 11:
                            ReturnID("24881");
                            break;
                    }
                    break;
                case 2:
                    switch (Program.Rand(1,6))
                    {
                        case 1:
                            ReturnID("31023");
                            break;
                        case 2:
                            ReturnID("31024");
                            break;
                        case 3:
                            ReturnID("31035");
                            break;
                        case 4:
                            ReturnID("31036");
                            break;
                        case 5:
                            ReturnID("31038");
                            break;
                        case 6:
                            ReturnID("30713");
                            break;
                    }
                    break;
            }
        }

        private void btnHighElfOld_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 2))
            {
                case 1:
                    switch (Program.Rand(1, 13))
                    {
                        case 1:
                            ReturnID("10381");
                            break;
                        case 2:
                            ReturnID("1643");
                            break;
                        case 3:
                            ReturnID("2240");
                            break;
                        case 4:
                            ReturnID("11161");
                            break;
                        case 5:
                            ReturnID("11163");
                            break;
                        case 6:
                            ReturnID("3293");
                            break;
                        case 7:
                            ReturnID("11069");
                            break;
                        case 8:
                            ReturnID("10199");
                            break;
                        case 9:
                            ReturnID("4729");
                            break;
                        case 10:
                            ReturnID("4730");
                            break;
                        case 11:
                            ReturnID("7922");
                            break;
                        case 12:
                            ReturnID("11157");
                            break;
                        case 13:
                            ReturnID("11164");
                            break;
                    }
                    break;
                case 2:
                    switch (Program.Rand(1, 8))
                    {
                        case 1:
                            ReturnID("4244");
                            break;
                        case 2:
                            ReturnID("10379");
                            break;
                        case 3:
                            ReturnID("4494");
                            break;
                        case 4:
                            ReturnID("9751");
                            break;
                        case 5:
                            ReturnID("4680");
                            break;
                        case 6:
                            ReturnID("6630");
                            break;
                        case 7:
                            ReturnID("6779");
                            break;
                        case 8:
                            ReturnID("9752");
                            break;
                    }
                    break;
            }
        }

        private void btnHighElfNew_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 8))
            {
                case 1:
                    ReturnID(Program.Rand(28754,28755).ToString());
                    break;
                case 2:
                    switch (Program.Rand(1,4))
                    {
                        case 1:
                            ReturnID("28740");
                            break;
                        case 2:
                            ReturnID("30260");
                            break;
                        case 3:
                            ReturnID("29477");
                            break;
                        case 4:
                            ReturnID("30310");
                            break;
                    }
                    break;
                case 3:
                    ReturnID(Program.Rand(26067, 26068).ToString());
                    break;
                case 4:
                    switch (Program.Rand(1, 2))
                    {
                        case 1:
                            ReturnID("27559");
                            break;
                        case 2:
                            ReturnID("28987");
                            break;
                    }
                    break;
                case 5:
                    switch (Program.Rand(1, 2))
                    {
                        case 1:
                            ReturnID("29483");
                            break;
                        case 2:
                            ReturnID("28756");
                            break;
                    }
                    break;
                case 6:
                    switch (Program.Rand(1, 2))
                    {
                        case 1:
                            ReturnID("28759");
                            break;
                        case 2:
                            ReturnID("30311");
                            break;
                    }
                    break;
                case 7:
                    ReturnID(Program.Rand(26069, 26070).ToString());
                    break;
                case 8:
                    switch (Program.Rand(1, 3))
                    {
                        case 1:
                            ReturnID("29475");
                            break;
                        case 2:
                            ReturnID("29611");
                            break;
                        case 3:
                            ReturnID("27556");
                            break;
                    }
                    break;
            }
        }

        private void btnPirate_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 3))
            {
                case 1:
                    ReturnID(Program.Rand(25032, 25054).ToString());
                    break;
                case 2:
                    switch (Program.Rand(1, 7))
                    {
                        case 1:
                            ReturnID("3493");
                            break;
                        case 2:
                            ReturnID("3494");
                            break;
                        case 3:
                            ReturnID("4619");
                            break;
                        case 4:
                            ReturnID("4648");
                            break;
                        case 5:
                            ReturnID("1667");
                            break;
                        case 6:
                            ReturnID("4873");
                            break;
                        case 7:
                            ReturnID("1280");
                            break;
                    }
                    break;
                case 3:
                    ReturnID(Program.Rand(1767, 1768).ToString());
                    break;
            }
        }

        private void btnDarkRanger_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 9))
            {
                case 1:
                    ReturnID("30686");
                    break;
                case 2:
                    ReturnID("30687");
                    break;
                case 3:
                    ReturnID("30071");
                    break;
                case 4:
                    ReturnID("30072");
                    break;
                case 5:
                    ReturnID("30073");
                    break;
                case 6:
                    ReturnID("21746");
                    break;
                case 7:
                    ReturnID("21741");
                    break;
                case 8:
                    ReturnID("24930");
                    break;
                case 9:
                    ReturnID("26939");
                    break;
            }
        }

        private void btnOrgrimmarGrunt_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("4601");
                    break;
                case 2:
                    ReturnID("15573");
                    break;
                case 3:
                    ReturnID("4602");
                    break;
                case 4:
                    ReturnID("15571");
                    break;
            }
        }

        private void btnStormwindGuard_Click(object sender, EventArgs e)
        {
            switch (Program.Rand(1, 4))
            {
                case 1:
                    ReturnID("3450");
                    break;
                case 2:
                    ReturnID("5446");
                    break;
                case 3:
                    ReturnID("3167");
                    break;
                case 4:
                    ReturnID("3453");
                    break;
            }
        }

        private void lblInvis_DoubleClick(object sender, EventArgs e)
        {
            ReturnID("24964");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
