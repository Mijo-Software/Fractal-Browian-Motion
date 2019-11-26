namespace Fractal_Brownian_Motion
{
  partial class MainApp
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.cbMovementRanging = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMovementOwnedSE = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedS = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedSW = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedE = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedC = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedW = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedNE = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedN = new System.Windows.Forms.CheckBox();
            this.cbMovementOwnedNW = new System.Windows.Forms.CheckBox();
            this.rbMovementOwned = new System.Windows.Forms.RadioButton();
            this.rbMovementMooreNeumann = new System.Windows.Forms.RadioButton();
            this.rbMovementNeumann = new System.Windows.Forms.RadioButton();
            this.rbMovementMoore = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numPauseLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPauseEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundcolor = new System.Windows.Forms.Button();
            this.btnPencolor = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numDistanceConstant = new System.Windows.Forms.NumericUpDown();
            this.numDistanceVariableMax = new System.Windows.Forms.NumericUpDown();
            this.numDistanceVariableMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDistanceVariable = new System.Windows.Forms.RadioButton();
            this.rbDistanceConstant = new System.Windows.Forms.RadioButton();
            this.picView = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPauseLength)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceVariableMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceVariableMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMovementRanging
            // 
            this.cbMovementRanging.AutoSize = true;
            this.cbMovementRanging.Location = new System.Drawing.Point(11, 221);
            this.cbMovementRanging.Name = "cbMovementRanging";
            this.cbMovementRanging.Size = new System.Drawing.Size(125, 17);
            this.cbMovementRanging.TabIndex = 13;
            this.cbMovementRanging.Text = "&Bereichseingrenzung";
            this.cbMovementRanging.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(371, 487);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "St&art";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(463, 487);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "St&op";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMovementOwnedSE);
            this.groupBox2.Controls.Add(this.cbMovementOwnedS);
            this.groupBox2.Controls.Add(this.cbMovementOwnedSW);
            this.groupBox2.Controls.Add(this.cbMovementOwnedE);
            this.groupBox2.Controls.Add(this.cbMovementOwnedC);
            this.groupBox2.Controls.Add(this.cbMovementOwnedW);
            this.groupBox2.Controls.Add(this.cbMovementOwnedNE);
            this.groupBox2.Controls.Add(this.cbMovementOwnedN);
            this.groupBox2.Controls.Add(this.cbMovementOwnedNW);
            this.groupBox2.Controls.Add(this.cbMovementRanging);
            this.groupBox2.Controls.Add(this.rbMovementOwned);
            this.groupBox2.Controls.Add(this.rbMovementMooreNeumann);
            this.groupBox2.Controls.Add(this.rbMovementNeumann);
            this.groupBox2.Controls.Add(this.rbMovementMoore);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bewegungsart";
            // 
            // cbMovementOwnedSE
            // 
            this.cbMovementOwnedSE.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedSE.AutoSize = true;
            this.cbMovementOwnedSE.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedSE.Image")));
            this.cbMovementOwnedSE.Location = new System.Drawing.Point(114, 173);
            this.cbMovementOwnedSE.Name = "cbMovementOwnedSE";
            this.cbMovementOwnedSE.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedSE.TabIndex = 12;
            this.cbMovementOwnedSE.UseVisualStyleBackColor = true;
            this.cbMovementOwnedSE.CheckedChanged += new System.EventHandler(this.cbMovementOwnedSE_CheckedChanged);
            // 
            // cbMovementOwnedS
            // 
            this.cbMovementOwnedS.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedS.AutoSize = true;
            this.cbMovementOwnedS.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedS.Image")));
            this.cbMovementOwnedS.Location = new System.Drawing.Point(86, 173);
            this.cbMovementOwnedS.Name = "cbMovementOwnedS";
            this.cbMovementOwnedS.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedS.TabIndex = 11;
            this.cbMovementOwnedS.UseVisualStyleBackColor = true;
            this.cbMovementOwnedS.CheckedChanged += new System.EventHandler(this.cbMovementOwnedS_CheckedChanged);
            // 
            // cbMovementOwnedSW
            // 
            this.cbMovementOwnedSW.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedSW.AutoSize = true;
            this.cbMovementOwnedSW.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedSW.Image")));
            this.cbMovementOwnedSW.Location = new System.Drawing.Point(58, 173);
            this.cbMovementOwnedSW.Name = "cbMovementOwnedSW";
            this.cbMovementOwnedSW.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedSW.TabIndex = 10;
            this.cbMovementOwnedSW.UseVisualStyleBackColor = true;
            this.cbMovementOwnedSW.CheckedChanged += new System.EventHandler(this.cbMovementOwnedSW_CheckedChanged);
            // 
            // cbMovementOwnedE
            // 
            this.cbMovementOwnedE.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedE.AutoSize = true;
            this.cbMovementOwnedE.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedE.Image")));
            this.cbMovementOwnedE.Location = new System.Drawing.Point(114, 151);
            this.cbMovementOwnedE.Name = "cbMovementOwnedE";
            this.cbMovementOwnedE.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedE.TabIndex = 9;
            this.cbMovementOwnedE.UseVisualStyleBackColor = true;
            this.cbMovementOwnedE.CheckedChanged += new System.EventHandler(this.cbMovementOwnedE_CheckedChanged);
            // 
            // cbMovementOwnedC
            // 
            this.cbMovementOwnedC.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedC.AutoSize = true;
            this.cbMovementOwnedC.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedC.Image")));
            this.cbMovementOwnedC.Location = new System.Drawing.Point(86, 151);
            this.cbMovementOwnedC.Name = "cbMovementOwnedC";
            this.cbMovementOwnedC.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedC.TabIndex = 8;
            this.cbMovementOwnedC.UseVisualStyleBackColor = true;
            this.cbMovementOwnedC.CheckedChanged += new System.EventHandler(this.cbMovementOwnedC_CheckedChanged);
            // 
            // cbMovementOwnedW
            // 
            this.cbMovementOwnedW.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedW.AutoSize = true;
            this.cbMovementOwnedW.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedW.Image")));
            this.cbMovementOwnedW.Location = new System.Drawing.Point(58, 151);
            this.cbMovementOwnedW.Name = "cbMovementOwnedW";
            this.cbMovementOwnedW.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedW.TabIndex = 7;
            this.cbMovementOwnedW.UseVisualStyleBackColor = true;
            this.cbMovementOwnedW.CheckedChanged += new System.EventHandler(this.cbMovementOwnedW_CheckedChanged);
            // 
            // cbMovementOwnedNE
            // 
            this.cbMovementOwnedNE.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedNE.AutoSize = true;
            this.cbMovementOwnedNE.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedNE.Image")));
            this.cbMovementOwnedNE.Location = new System.Drawing.Point(114, 129);
            this.cbMovementOwnedNE.Name = "cbMovementOwnedNE";
            this.cbMovementOwnedNE.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedNE.TabIndex = 6;
            this.cbMovementOwnedNE.UseVisualStyleBackColor = true;
            this.cbMovementOwnedNE.CheckedChanged += new System.EventHandler(this.cbMovementOwnedNE_CheckedChanged);
            // 
            // cbMovementOwnedN
            // 
            this.cbMovementOwnedN.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedN.AutoSize = true;
            this.cbMovementOwnedN.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedN.Image")));
            this.cbMovementOwnedN.Location = new System.Drawing.Point(86, 129);
            this.cbMovementOwnedN.Name = "cbMovementOwnedN";
            this.cbMovementOwnedN.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedN.TabIndex = 5;
            this.cbMovementOwnedN.UseVisualStyleBackColor = true;
            this.cbMovementOwnedN.CheckedChanged += new System.EventHandler(this.cbMovementOwnedN_CheckedChanged);
            // 
            // cbMovementOwnedNW
            // 
            this.cbMovementOwnedNW.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovementOwnedNW.AutoSize = true;
            this.cbMovementOwnedNW.Image = ((System.Drawing.Image)(resources.GetObject("cbMovementOwnedNW.Image")));
            this.cbMovementOwnedNW.Location = new System.Drawing.Point(58, 129);
            this.cbMovementOwnedNW.Name = "cbMovementOwnedNW";
            this.cbMovementOwnedNW.Size = new System.Drawing.Size(22, 22);
            this.cbMovementOwnedNW.TabIndex = 4;
            this.cbMovementOwnedNW.UseVisualStyleBackColor = true;
            this.cbMovementOwnedNW.CheckedChanged += new System.EventHandler(this.cbMovementOwnedNW_CheckedChanged);
            // 
            // rbMovementOwned
            // 
            this.rbMovementOwned.AutoSize = true;
            this.rbMovementOwned.Location = new System.Drawing.Point(11, 92);
            this.rbMovementOwned.Name = "rbMovementOwned";
            this.rbMovementOwned.Size = new System.Drawing.Size(179, 17);
            this.rbMovementOwned.TabIndex = 3;
            this.rbMovementOwned.TabStop = true;
            this.rbMovementOwned.Text = "eigene Nachbarschaft definieren";
            this.rbMovementOwned.UseVisualStyleBackColor = true;
            this.rbMovementOwned.CheckedChanged += new System.EventHandler(this.rbMovementOwned_CheckChanged);
            // 
            // rbMovementMooreNeumann
            // 
            this.rbMovementMooreNeumann.AutoSize = true;
            this.rbMovementMooreNeumann.Location = new System.Drawing.Point(11, 68);
            this.rbMovementMooreNeumann.Name = "rbMovementMooreNeumann";
            this.rbMovementMooreNeumann.Size = new System.Drawing.Size(202, 17);
            this.rbMovementMooreNeumann.TabIndex = 2;
            this.rbMovementMooreNeumann.TabStop = true;
            this.rbMovementMooreNeumann.Text = "Moore- && V.-Neumann-Nachbarschaft";
            this.rbMovementMooreNeumann.UseVisualStyleBackColor = true;
            // 
            // rbMovementNeumann
            // 
            this.rbMovementNeumann.AutoSize = true;
            this.rbMovementNeumann.Location = new System.Drawing.Point(11, 44);
            this.rbMovementNeumann.Name = "rbMovementNeumann";
            this.rbMovementNeumann.Size = new System.Drawing.Size(166, 17);
            this.rbMovementNeumann.TabIndex = 1;
            this.rbMovementNeumann.TabStop = true;
            this.rbMovementNeumann.Text = "Von-Neumann-Nachbarschaft";
            this.rbMovementNeumann.UseVisualStyleBackColor = true;
            // 
            // rbMovementMoore
            // 
            this.rbMovementMoore.AutoSize = true;
            this.rbMovementMoore.Location = new System.Drawing.Point(11, 20);
            this.rbMovementMoore.Name = "rbMovementMoore";
            this.rbMovementMoore.Size = new System.Drawing.Size(128, 17);
            this.rbMovementMoore.TabIndex = 0;
            this.rbMovementMoore.TabStop = true;
            this.rbMovementMoore.Text = "Moore-Nachbarschaft";
            this.rbMovementMoore.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numPauseLength);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbPauseEnabled);
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pause";
            // 
            // numPauseLength
            // 
            this.numPauseLength.Location = new System.Drawing.Point(153, 42);
            this.numPauseLength.Name = "numPauseLength";
            this.numPauseLength.Size = new System.Drawing.Size(61, 20);
            this.numPauseLength.TabIndex = 2;
            this.numPauseLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Länge der Pause in MS";
            // 
            // cbPauseEnabled
            // 
            this.cbPauseEnabled.AutoSize = true;
            this.cbPauseEnabled.Location = new System.Drawing.Point(11, 20);
            this.cbPauseEnabled.Name = "cbPauseEnabled";
            this.cbPauseEnabled.Size = new System.Drawing.Size(113, 17);
            this.cbPauseEnabled.TabIndex = 0;
            this.cbPauseEnabled.Text = "Pause einschalten";
            this.cbPauseEnabled.UseVisualStyleBackColor = true;
            this.cbPauseEnabled.CheckedChanged += new System.EventHandler(this.cbPauseEnabled_CheckChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBackgroundcolor);
            this.groupBox4.Controls.Add(this.btnPencolor);
            this.groupBox4.Location = new System.Drawing.Point(12, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Farbe für die Ansicht";
            // 
            // btnBackgroundcolor
            // 
            this.btnBackgroundcolor.Location = new System.Drawing.Point(113, 20);
            this.btnBackgroundcolor.Name = "btnBackgroundcolor";
            this.btnBackgroundcolor.Size = new System.Drawing.Size(100, 23);
            this.btnBackgroundcolor.TabIndex = 1;
            this.btnBackgroundcolor.Text = "Hintergrundfarbe";
            this.btnBackgroundcolor.UseVisualStyleBackColor = true;
            this.btnBackgroundcolor.Click += new System.EventHandler(this.btnBackgroundcolor_Click);
            // 
            // btnPencolor
            // 
            this.btnPencolor.Location = new System.Drawing.Point(7, 20);
            this.btnPencolor.Name = "btnPencolor";
            this.btnPencolor.Size = new System.Drawing.Size(91, 23);
            this.btnPencolor.TabIndex = 0;
            this.btnPencolor.Text = "Zeichenfarbe";
            this.btnPencolor.UseVisualStyleBackColor = true;
            this.btnPencolor.Click += new System.EventHandler(this.btnPencolor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numDistanceConstant);
            this.groupBox5.Controls.Add(this.numDistanceVariableMax);
            this.groupBox5.Controls.Add(this.numDistanceVariableMin);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.rbDistanceVariable);
            this.groupBox5.Controls.Add(this.rbDistanceConstant);
            this.groupBox5.Location = new System.Drawing.Point(13, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 97);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Distanzierung";
            // 
            // numDistanceConstant
            // 
            this.numDistanceConstant.Location = new System.Drawing.Point(159, 20);
            this.numDistanceConstant.Name = "numDistanceConstant";
            this.numDistanceConstant.Size = new System.Drawing.Size(42, 20);
            this.numDistanceConstant.TabIndex = 1;
            this.numDistanceConstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDistanceVariableMax
            // 
            this.numDistanceVariableMax.Location = new System.Drawing.Point(134, 66);
            this.numDistanceVariableMax.Name = "numDistanceVariableMax";
            this.numDistanceVariableMax.Size = new System.Drawing.Size(42, 20);
            this.numDistanceVariableMax.TabIndex = 6;
            this.numDistanceVariableMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDistanceVariableMin
            // 
            this.numDistanceVariableMin.Location = new System.Drawing.Point(55, 66);
            this.numDistanceVariableMin.Name = "numDistanceVariableMin";
            this.numDistanceVariableMin.Size = new System.Drawing.Size(42, 20);
            this.numDistanceVariableMin.TabIndex = 4;
            this.numDistanceVariableMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "bis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "von";
            // 
            // rbDistanceVariable
            // 
            this.rbDistanceVariable.AutoSize = true;
            this.rbDistanceVariable.Location = new System.Drawing.Point(7, 44);
            this.rbDistanceVariable.Name = "rbDistanceVariable";
            this.rbDistanceVariable.Size = new System.Drawing.Size(136, 17);
            this.rbDistanceVariable.TabIndex = 2;
            this.rbDistanceVariable.TabStop = true;
            this.rbDistanceVariable.Text = "variable Distanz in Pixel";
            this.rbDistanceVariable.UseVisualStyleBackColor = true;
            this.rbDistanceVariable.CheckedChanged += new System.EventHandler(this.rbDistanceVariable_CheckedChanged);
            // 
            // rbDistanceConstant
            // 
            this.rbDistanceConstant.AutoSize = true;
            this.rbDistanceConstant.Location = new System.Drawing.Point(7, 20);
            this.rbDistanceConstant.Name = "rbDistanceConstant";
            this.rbDistanceConstant.Size = new System.Drawing.Size(146, 17);
            this.rbDistanceConstant.TabIndex = 0;
            this.rbDistanceConstant.TabStop = true;
            this.rbDistanceConstant.Text = "konstante Distanz in Pixel";
            this.rbDistanceConstant.UseVisualStyleBackColor = true;
            this.rbDistanceConstant.CheckedChanged += new System.EventHandler(this.rbDistanceConstant_CheckedChanged);
            // 
            // picView
            // 
            this.picView.BackColor = System.Drawing.Color.White;
            this.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picView.Location = new System.Drawing.Point(251, 15);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(438, 430);
            this.picView.TabIndex = 0;
            this.picView.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(597, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 455);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ansicht";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(701, 534);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Brownian Motion";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPauseLength)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceVariableMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceVariableMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.CheckBox cbMovementRanging;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rbMovementOwned;
    private System.Windows.Forms.RadioButton rbMovementMooreNeumann;
    private System.Windows.Forms.RadioButton rbMovementNeumann;
    private System.Windows.Forms.RadioButton rbMovementMoore;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox cbPauseEnabled;
    private System.Windows.Forms.NumericUpDown numPauseLength;
    private System.Windows.Forms.CheckBox cbMovementOwnedNW;
    private System.Windows.Forms.CheckBox cbMovementOwnedSE;
    private System.Windows.Forms.CheckBox cbMovementOwnedS;
    private System.Windows.Forms.CheckBox cbMovementOwnedSW;
    private System.Windows.Forms.CheckBox cbMovementOwnedE;
    private System.Windows.Forms.CheckBox cbMovementOwnedC;
    private System.Windows.Forms.CheckBox cbMovementOwnedW;
    private System.Windows.Forms.CheckBox cbMovementOwnedNE;
    private System.Windows.Forms.CheckBox cbMovementOwnedN;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton rbDistanceVariable;
    private System.Windows.Forms.RadioButton rbDistanceConstant;
    private System.Windows.Forms.NumericUpDown numDistanceVariableMin;
    private System.Windows.Forms.Button btnBackgroundcolor;
    private System.Windows.Forms.Button btnPencolor;
    private System.Windows.Forms.NumericUpDown numDistanceConstant;
    private System.Windows.Forms.NumericUpDown numDistanceVariableMax;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox picView;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

