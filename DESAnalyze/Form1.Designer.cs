
namespace DESAnalyze
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lRoundNum = new System.Windows.Forms.Label();
            this.cbIsKeyCh = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudBitPos = new System.Windows.Forms.NumericUpDown();
            this.lMessageBin = new System.Windows.Forms.Label();
            this.lKey = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lMessageBinCh = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lKeyCh = new System.Windows.Forms.Label();
            this.lCipherCr = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lCipher = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bRound = new System.Windows.Forms.Button();
            this.bCalcGraph = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lCipherText = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.lNumBitChange = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitPos)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(357, 378);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(458, 19);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(220, 20);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.Text = "majimago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ: ";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(458, 134);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(220, 20);
            this.tbKey.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "В двоичном виде:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Зашифрованный текст: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "В двоичном виде:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ранд";
            // 
            // lRoundNum
            // 
            this.lRoundNum.AutoSize = true;
            this.lRoundNum.Location = new System.Drawing.Point(447, 385);
            this.lRoundNum.Name = "lRoundNum";
            this.lRoundNum.Size = new System.Drawing.Size(13, 13);
            this.lRoundNum.TabIndex = 13;
            this.lRoundNum.Text = "0";
            // 
            // cbIsKeyCh
            // 
            this.cbIsKeyCh.AutoSize = true;
            this.cbIsKeyCh.Location = new System.Drawing.Point(544, 351);
            this.cbIsKeyCh.Name = "cbIsKeyCh";
            this.cbIsKeyCh.Size = new System.Drawing.Size(118, 17);
            this.cbIsKeyCh.TabIndex = 16;
            this.cbIsKeyCh.Text = "Менять бит ключа";
            this.cbIsKeyCh.UseVisualStyleBackColor = true;
            this.cbIsKeyCh.CheckedChanged += new System.EventHandler(this.cbIsKeyCh_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Позиция бита:";
            // 
            // nudBitPos
            // 
            this.nudBitPos.Location = new System.Drawing.Point(495, 350);
            this.nudBitPos.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudBitPos.Name = "nudBitPos";
            this.nudBitPos.Size = new System.Drawing.Size(43, 20);
            this.nudBitPos.TabIndex = 18;
            this.nudBitPos.ValueChanged += new System.EventHandler(this.nudBitPos_ValueChanged);
            // 
            // lMessageBin
            // 
            this.lMessageBin.AutoSize = true;
            this.lMessageBin.Location = new System.Drawing.Point(397, 55);
            this.lMessageBin.Name = "lMessageBin";
            this.lMessageBin.Size = new System.Drawing.Size(391, 13);
            this.lMessageBin.TabIndex = 20;
            this.lMessageBin.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Location = new System.Drawing.Point(397, 170);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(391, 13);
            this.lKey.TabIndex = 21;
            this.lKey.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            this.lKey.UseMnemonic = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Измененный:";
            // 
            // lMessageBinCh
            // 
            this.lMessageBinCh.AutoSize = true;
            this.lMessageBinCh.Location = new System.Drawing.Point(397, 99);
            this.lMessageBinCh.Name = "lMessageBinCh";
            this.lMessageBinCh.Size = new System.Drawing.Size(391, 13);
            this.lMessageBinCh.TabIndex = 23;
            this.lMessageBinCh.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(536, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Измененный:";
            // 
            // lKeyCh
            // 
            this.lKeyCh.AutoSize = true;
            this.lKeyCh.Location = new System.Drawing.Point(397, 207);
            this.lKeyCh.Name = "lKeyCh";
            this.lKeyCh.Size = new System.Drawing.Size(391, 13);
            this.lKeyCh.TabIndex = 25;
            this.lKeyCh.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            // 
            // lCipherCr
            // 
            this.lCipherCr.AutoSize = true;
            this.lCipherCr.Location = new System.Drawing.Point(397, 312);
            this.lCipherCr.Name = "lCipherCr";
            this.lCipherCr.Size = new System.Drawing.Size(391, 13);
            this.lCipherCr.TabIndex = 29;
            this.lCipherCr.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(536, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Текущий:";
            // 
            // lCipher
            // 
            this.lCipher.AutoSize = true;
            this.lCipher.Location = new System.Drawing.Point(397, 275);
            this.lCipher.Name = "lCipher";
            this.lCipher.Size = new System.Drawing.Size(391, 13);
            this.lCipher.TabIndex = 27;
            this.lCipher.Text = "0101010101010101010101010101010101010101010101010101010101010101";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(536, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Изначальный:";
            // 
            // bRound
            // 
            this.bRound.Location = new System.Drawing.Point(495, 380);
            this.bRound.Name = "bRound";
            this.bRound.Size = new System.Drawing.Size(75, 23);
            this.bRound.TabIndex = 30;
            this.bRound.Text = "РАУНД!";
            this.bRound.UseVisualStyleBackColor = true;
            this.bRound.Click += new System.EventHandler(this.bRound_Click);
            // 
            // bCalcGraph
            // 
            this.bCalcGraph.Location = new System.Drawing.Point(400, 415);
            this.bCalcGraph.Name = "bCalcGraph";
            this.bCalcGraph.Size = new System.Drawing.Size(129, 23);
            this.bCalcGraph.TabIndex = 31;
            this.bCalcGraph.Text = "Рассчитать графики";
            this.bCalcGraph.UseVisualStyleBackColor = true;
            this.bCalcGraph.Click += new System.EventHandler(this.bCalcGraph_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(698, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button3, "\"Слишком много проверок\"");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(698, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button4, "\"Мне лень\"");
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lCipherText
            // 
            this.lCipherText.AutoSize = true;
            this.lCipherText.Location = new System.Drawing.Point(534, 242);
            this.lCipherText.Name = "lCipherText";
            this.lCipherText.Size = new System.Drawing.Size(47, 13);
            this.lCipherText.TabIndex = 34;
            this.lCipherText.Text = "пукпукп";
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(587, 380);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 35;
            this.bReset.Text = "Сбросить";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // lNumBitChange
            // 
            this.lNumBitChange.AutoSize = true;
            this.lNumBitChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumBitChange.Location = new System.Drawing.Point(716, 352);
            this.lNumBitChange.Name = "lNumBitChange";
            this.lNumBitChange.Size = new System.Drawing.Size(39, 42);
            this.lNumBitChange.TabIndex = 36;
            this.lNumBitChange.Text = "0";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNumBitChange);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lCipherText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bCalcGraph);
            this.Controls.Add(this.bRound);
            this.Controls.Add(this.lCipherCr);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lCipher);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lKeyCh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lMessageBinCh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.lMessageBin);
            this.Controls.Add(this.nudBitPos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbIsKeyCh);
            this.Controls.Add(this.lRoundNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DES Analyze (ABCDRa)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lRoundNum;
        private System.Windows.Forms.CheckBox cbIsKeyCh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudBitPos;
        private System.Windows.Forms.Label lMessageBin;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lMessageBinCh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lKeyCh;
        private System.Windows.Forms.Label lCipherCr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lCipher;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button bRound;
        private System.Windows.Forms.Button bCalcGraph;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lCipherText;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lNumBitChange;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

