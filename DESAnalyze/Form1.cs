using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAnalyze
{
    public partial class Form1 : Form
    {
        string message = "";
        BitArray baMessage;
        BitArray baMessageCh;
        BitArray baCrypt;
        BitArray baCryptCh;
        int bitPosition = 0;
        int currRound = 0;
        DESKey key = new DESKey("1010101010111011000010010001100000100111001101101100110011011101");
        DESKey keyCh = new DESKey("1010101010111011000010010001100000100111001101101100110011011101");
        bool isKeyCh = false;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lNumBitChange, "Кол-во измененных бит");
            message = tbMessage.Text;
            lMessageBin.Text = BitArrayExtension.GetFromString(message, "S").ToString("B");
            lMessageBinCh.Text = lMessageBin.Text;
            tbKey.Text = key.ToString();
            lKey.Text = key.key56.ToString("B");
            lKeyCh.Text = lKey.Text;
            lCipherText.Text = DES.Encrypt_ECB(message, key);
            baMessage = BitArrayExtension.GetFromString(message, "S");
            baCrypt = DES.Encrypt(baMessage, key, currRound);
            lCipher.Text = baCrypt.ToString("B");
            lCipherCr.Text = lMessageBinCh.Text;
            updateChBit();
        }

        private void nudBitPos_ValueChanged(object sender, EventArgs e)
        {
            bitPosition = Decimal.ToInt32(nudBitPos.Value);
            updateChBit();
        }

        private void cbIsKeyCh_CheckedChanged(object sender, EventArgs e)
        {
            isKeyCh = cbIsKeyCh.Checked;
            if (isKeyCh) nudBitPos.Maximum = 58;
            else nudBitPos.Maximum = 64;
            updateChBit();
        }

        private void UpdateChangedData()
        {
            lMessageBinCh.Text = baMessageCh.ToString("B");
            lKeyCh.Text = keyCh.key56.ToString("B");
            lCipherCr.Text = baCryptCh.ToString("B");
            lRoundNum.Text = $"{currRound}";
            lCipher.Text = baCrypt.ToString("B");
            lNumBitChange.Text = $"{countChangedBits()}";
        }

        private void updateChBit()
        {
            
            baMessageCh = (BitArray)baMessage.Clone();
            keyCh.Copy(key);
            if (bitPosition == 0)
            {
                
            }
            else if(isKeyCh)
            {
                keyCh.key56[bitPosition - 1] = !keyCh.key56[bitPosition - 1];
                keyCh.updateKey64();
            }
            else
            {
                baMessageCh[bitPosition - 1] = !baMessageCh[bitPosition - 1];
            }
            baCryptCh = DES.Encrypt(baMessageCh, keyCh, currRound);
            UpdateChangedData();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void bRound_Click(object sender, EventArgs e)
        {
            if (currRound > 16) currRound = -1;
            currRound++;
            baCryptCh = DES.Encrypt(baMessageCh, keyCh, currRound);
            baCrypt = DES.Encrypt(baMessage, key, currRound);
            UpdateChangedData();
        }


        private int countChangedBits()
        {
            int num = 0;
            for(int i = 0; i < baCryptCh.Length; i++)
            {
                num += baCrypt[i] != baCryptCh[i] ? 1 : 0;
            }
            return num;
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            currRound = 0;
            baCryptCh = DES.Encrypt(baMessageCh, keyCh, currRound);
            baCrypt = DES.Encrypt(baMessage, key, currRound);
            UpdateChangedData();
        }

        private void bCalcGraph_Click(object sender, EventArgs e)
        {
            bReset_Click(sender, e);
            chart1.Series[0].Points.Clear();
            for(int i=0; i < 16; i++)
            {
                chart1.Series[0].Points.AddXY(currRound, countChangedBits());
                bRound_Click(sender, e);
            }
        }
    }
}
