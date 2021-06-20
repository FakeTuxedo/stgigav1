
namespace stmegatest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Units = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.TextBox();
            this.StationID = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.midh = new System.Windows.Forms.TextBox();
            this.fasth = new System.Windows.Forms.TextBox();
            this.vfasth = new System.Windows.Forms.TextBox();
            this.vslowh = new System.Windows.Forms.TextBox();
            this.slowh = new System.Windows.Forms.TextBox();
            this.vlowlnk = new System.Windows.Forms.TextBox();
            this.lowlnk = new System.Windows.Forms.TextBox();
            this.midlnk = new System.Windows.Forms.TextBox();
            this.highlnk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vhighlnk = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(14, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Station ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 26);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // Units
            // 
            this.Units.FormattingEnabled = true;
            this.Units.Items.AddRange(new object[] {
            "english",
            "metric"});
            this.Units.Location = new System.Drawing.Point(224, 27);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(139, 23);
            this.Units.TabIndex = 4;
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(12, 27);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(100, 23);
            this.Datum.TabIndex = 5;
            this.Datum.Text = "IGLD";
            // 
            // StationID
            // 
            this.StationID.Location = new System.Drawing.Point(118, 27);
            this.StationID.Name = "StationID";
            this.StationID.Size = new System.Drawing.Size(100, 23);
            this.StationID.TabIndex = 6;
            this.StationID.Text = "9044049";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Choose Medium Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Choose Slow Directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Choose Very Slow Directory";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Units:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Choose Fast Directory";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Choose Very Fast Directory";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Heights:";
            // 
            // midh
            // 
            this.midh.Location = new System.Drawing.Point(224, 203);
            this.midh.Name = "midh";
            this.midh.Size = new System.Drawing.Size(138, 23);
            this.midh.TabIndex = 15;
            this.midh.Text = "575.77";
            // 
            // fasth
            // 
            this.fasth.Location = new System.Drawing.Point(224, 262);
            this.fasth.Name = "fasth";
            this.fasth.Size = new System.Drawing.Size(138, 23);
            this.fasth.TabIndex = 16;
            this.fasth.Text = "575.89";
            // 
            // vfasth
            // 
            this.vfasth.Location = new System.Drawing.Point(224, 321);
            this.vfasth.Name = "vfasth";
            this.vfasth.Size = new System.Drawing.Size(138, 23);
            this.vfasth.TabIndex = 17;
            this.vfasth.Text = "576";
            // 
            // vslowh
            // 
            this.vslowh.Location = new System.Drawing.Point(224, 86);
            this.vslowh.Name = "vslowh";
            this.vslowh.Size = new System.Drawing.Size(138, 23);
            this.vslowh.TabIndex = 18;
            this.vslowh.Text = "574.69";
            // 
            // slowh
            // 
            this.slowh.Location = new System.Drawing.Point(224, 144);
            this.slowh.Name = "slowh";
            this.slowh.Size = new System.Drawing.Size(138, 23);
            this.slowh.TabIndex = 19;
            this.slowh.Text = "575.74";
            // 
            // vlowlnk
            // 
            this.vlowlnk.Location = new System.Drawing.Point(13, 115);
            this.vlowlnk.Name = "vlowlnk";
            this.vlowlnk.Size = new System.Drawing.Size(205, 23);
            this.vlowlnk.TabIndex = 20;
            // 
            // lowlnk
            // 
            this.lowlnk.Location = new System.Drawing.Point(13, 174);
            this.lowlnk.Name = "lowlnk";
            this.lowlnk.Size = new System.Drawing.Size(205, 23);
            this.lowlnk.TabIndex = 21;
            // 
            // midlnk
            // 
            this.midlnk.Location = new System.Drawing.Point(14, 233);
            this.midlnk.Name = "midlnk";
            this.midlnk.Size = new System.Drawing.Size(204, 23);
            this.midlnk.TabIndex = 22;
            // 
            // highlnk
            // 
            this.highlnk.Location = new System.Drawing.Point(14, 292);
            this.highlnk.Name = "highlnk";
            this.highlnk.Size = new System.Drawing.Size(204, 23);
            this.highlnk.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Directory/Web Link (choose one)";
            // 
            // vhighlnk
            // 
            this.vhighlnk.Location = new System.Drawing.Point(14, 349);
            this.vhighlnk.Name = "vhighlnk";
            this.vhighlnk.Size = new System.Drawing.Size(204, 23);
            this.vhighlnk.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 422);
            this.Controls.Add(this.vhighlnk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highlnk);
            this.Controls.Add(this.midlnk);
            this.Controls.Add(this.lowlnk);
            this.Controls.Add(this.vlowlnk);
            this.Controls.Add(this.slowh);
            this.Controls.Add(this.vslowh);
            this.Controls.Add(this.vfasth);
            this.Controls.Add(this.fasth);
            this.Controls.Add(this.midh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StationID);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ComboBox Units;
        private System.Windows.Forms.TextBox Datum;
        private System.Windows.Forms.TextBox StationID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox midh;
        private System.Windows.Forms.TextBox fasth;
        private System.Windows.Forms.TextBox vfasth;
        private System.Windows.Forms.TextBox vslowh;
        private System.Windows.Forms.TextBox slowh;
        private System.Windows.Forms.TextBox vlowlnk;
        private System.Windows.Forms.TextBox lowlnk;
        private System.Windows.Forms.TextBox midlnk;
        private System.Windows.Forms.TextBox highlnk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vhighlnk;
    }
}

