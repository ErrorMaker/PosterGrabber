namespace PosterGrabber
{
    partial class frmMain
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
            this.numW1 = new System.Windows.Forms.NumericUpDown();
            this.numW2 = new System.Windows.Forms.NumericUpDown();
            this.numL1 = new System.Windows.Forms.NumericUpDown();
            this.numL2 = new System.Windows.Forms.NumericUpDown();
            this.btnMovePoster = new System.Windows.Forms.Button();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.cmbRot = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // numW1
            // 
            this.numW1.Location = new System.Drawing.Point(12, 38);
            this.numW1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numW1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numW1.Name = "numW1";
            this.numW1.Size = new System.Drawing.Size(49, 20);
            this.numW1.TabIndex = 0;
            // 
            // numW2
            // 
            this.numW2.Location = new System.Drawing.Point(67, 38);
            this.numW2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numW2.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numW2.Name = "numW2";
            this.numW2.Size = new System.Drawing.Size(49, 20);
            this.numW2.TabIndex = 1;
            // 
            // numL1
            // 
            this.numL1.Location = new System.Drawing.Point(12, 64);
            this.numL1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numL1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numL1.Name = "numL1";
            this.numL1.Size = new System.Drawing.Size(49, 20);
            this.numL1.TabIndex = 2;
            // 
            // numL2
            // 
            this.numL2.Location = new System.Drawing.Point(67, 64);
            this.numL2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numL2.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numL2.Name = "numL2";
            this.numL2.Size = new System.Drawing.Size(49, 20);
            this.numL2.TabIndex = 3;
            // 
            // btnMovePoster
            // 
            this.btnMovePoster.Location = new System.Drawing.Point(12, 114);
            this.btnMovePoster.Name = "btnMovePoster";
            this.btnMovePoster.Size = new System.Drawing.Size(104, 23);
            this.btnMovePoster.TabIndex = 4;
            this.btnMovePoster.Text = "Move Poster";
            this.btnMovePoster.UseVisualStyleBackColor = true;
            this.btnMovePoster.Click += new System.EventHandler(this.btnMovePoster_Click);
            // 
            // numId
            // 
            this.numId.Enabled = false;
            this.numId.Location = new System.Drawing.Point(12, 12);
            this.numId.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numId.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(104, 20);
            this.numId.TabIndex = 5;
            // 
            // cmbRot
            // 
            this.cmbRot.FormattingEnabled = true;
            this.cmbRot.Items.AddRange(new object[] {
            "l",
            "r"});
            this.cmbRot.Location = new System.Drawing.Point(12, 90);
            this.cmbRot.Name = "cmbRot";
            this.cmbRot.Size = new System.Drawing.Size(104, 21);
            this.cmbRot.TabIndex = 6;
            this.cmbRot.Text = "l";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 149);
            this.Controls.Add(this.cmbRot);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.btnMovePoster);
            this.Controls.Add(this.numL2);
            this.Controls.Add(this.numL1);
            this.Controls.Add(this.numW2);
            this.Controls.Add(this.numW1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "PosterGrabber";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numW1;
        private System.Windows.Forms.NumericUpDown numW2;
        private System.Windows.Forms.NumericUpDown numL1;
        private System.Windows.Forms.NumericUpDown numL2;
        private System.Windows.Forms.Button btnMovePoster;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.ComboBox cmbRot;
    }
}

