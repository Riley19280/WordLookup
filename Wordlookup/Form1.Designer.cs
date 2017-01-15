namespace Wordlookup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtWords = new System.Windows.Forms.RichTextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.pnlSpecific = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.radThesarus = new System.Windows.Forms.RadioButton();
            this.radDict = new System.Windows.Forms.RadioButton();
            this.radWikipedia = new System.Windows.Forms.RadioButton();
            this.chkSpecific = new System.Windows.Forms.CheckBox();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblPageLoadDelay = new System.Windows.Forms.Label();
            this.numPageLoadDealy = new System.Windows.Forms.NumericUpDown();
            this.pnlSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageLoadDealy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(12, 26);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(112, 288);
            this.txtWords.TabIndex = 0;
            this.txtWords.Text = "";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(42, 9);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(41, 13);
            this.lblWords.TabIndex = 1;
            this.lblWords.Text = "Words:";
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(216, 22);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(100, 20);
            this.txtBefore.TabIndex = 2;
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(216, 48);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(100, 20);
            this.txtAfter.TabIndex = 3;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(145, 29);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(65, 13);
            this.lblBefore.TabIndex = 4;
            this.lblBefore.Text = "Text Before:";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(154, 51);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(56, 13);
            this.lblAfter.TabIndex = 5;
            this.lblAfter.Text = "Text After:";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(357, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "GO!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(261, 291);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(75, 23);
            this.btnInstructions.TabIndex = 7;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // pnlSpecific
            // 
            this.pnlSpecific.Controls.Add(this.btnRequest);
            this.pnlSpecific.Controls.Add(this.radThesarus);
            this.pnlSpecific.Controls.Add(this.radDict);
            this.pnlSpecific.Controls.Add(this.radWikipedia);
            this.pnlSpecific.Location = new System.Drawing.Point(148, 107);
            this.pnlSpecific.Name = "pnlSpecific";
            this.pnlSpecific.Size = new System.Drawing.Size(112, 102);
            this.pnlSpecific.TabIndex = 8;
            this.pnlSpecific.Visible = false;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(14, 72);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 22);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // radThesarus
            // 
            this.radThesarus.AutoSize = true;
            this.radThesarus.Location = new System.Drawing.Point(4, 49);
            this.radThesarus.Name = "radThesarus";
            this.radThesarus.Size = new System.Drawing.Size(92, 17);
            this.radThesarus.TabIndex = 2;
            this.radThesarus.TabStop = true;
            this.radThesarus.Text = "Thesarus.com";
            this.radThesarus.UseVisualStyleBackColor = true;
            // 
            // radDict
            // 
            this.radDict.AutoSize = true;
            this.radDict.Location = new System.Drawing.Point(3, 26);
            this.radDict.Name = "radDict";
            this.radDict.Size = new System.Drawing.Size(95, 17);
            this.radDict.TabIndex = 1;
            this.radDict.TabStop = true;
            this.radDict.Text = "Dictionary.com";
            this.radDict.UseVisualStyleBackColor = true;
            // 
            // radWikipedia
            // 
            this.radWikipedia.AutoSize = true;
            this.radWikipedia.Location = new System.Drawing.Point(4, 3);
            this.radWikipedia.Name = "radWikipedia";
            this.radWikipedia.Size = new System.Drawing.Size(72, 17);
            this.radWikipedia.TabIndex = 0;
            this.radWikipedia.TabStop = true;
            this.radWikipedia.Text = "Wikipedia";
            this.radWikipedia.UseVisualStyleBackColor = true;
            // 
            // chkSpecific
            // 
            this.chkSpecific.AutoSize = true;
            this.chkSpecific.Location = new System.Drawing.Point(148, 84);
            this.chkSpecific.Name = "chkSpecific";
            this.chkSpecific.Size = new System.Drawing.Size(89, 17);
            this.chkSpecific.TabIndex = 0;
            this.chkSpecific.Text = "Specific site?";
            this.chkSpecific.UseVisualStyleBackColor = true;
            this.chkSpecific.CheckedChanged += new System.EventHandler(this.chkSpecific_CheckedChanged);
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(216, 215);
            this.numDelay.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(100, 20);
            this.numDelay.TabIndex = 9;
            this.numDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(148, 217);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(59, 13);
            this.lblDelay.TabIndex = 10;
            this.lblDelay.Text = "Tab Delay:";
            // 
            // lblPageLoadDelay
            // 
            this.lblPageLoadDelay.AutoSize = true;
            this.lblPageLoadDelay.Location = new System.Drawing.Point(145, 246);
            this.lblPageLoadDelay.Name = "lblPageLoadDelay";
            this.lblPageLoadDelay.Size = new System.Drawing.Size(92, 13);
            this.lblPageLoadDelay.TabIndex = 11;
            this.lblPageLoadDelay.Text = "Page Load Delay:";
            // 
            // numPageLoadDealy
            // 
            this.numPageLoadDealy.Location = new System.Drawing.Point(238, 244);
            this.numPageLoadDealy.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numPageLoadDealy.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPageLoadDealy.Name = "numPageLoadDealy";
            this.numPageLoadDealy.Size = new System.Drawing.Size(78, 20);
            this.numPageLoadDealy.TabIndex = 12;
            this.numPageLoadDealy.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 326);
            this.Controls.Add(this.numPageLoadDealy);
            this.Controls.Add(this.lblPageLoadDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.chkSpecific);
            this.Controls.Add(this.pnlSpecific);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.txtWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Word Lookup";
            this.pnlSpecific.ResumeLayout(false);
            this.pnlSpecific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageLoadDealy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtWords;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Panel pnlSpecific;
        private System.Windows.Forms.RadioButton radThesarus;
        private System.Windows.Forms.RadioButton radDict;
        private System.Windows.Forms.RadioButton radWikipedia;
        private System.Windows.Forms.CheckBox chkSpecific;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblPageLoadDelay;
        private System.Windows.Forms.NumericUpDown numPageLoadDealy;
    }
}

