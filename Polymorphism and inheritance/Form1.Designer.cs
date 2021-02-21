
namespace Polymorphism_and_inheritance
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
            this.rdParrot = new System.Windows.Forms.RadioButton();
            this.rdCat = new System.Windows.Forms.RadioButton();
            this.rdHuman = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSentences = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnCaress = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdParrot
            // 
            this.rdParrot.AutoSize = true;
            this.rdParrot.Location = new System.Drawing.Point(38, 24);
            this.rdParrot.Name = "rdParrot";
            this.rdParrot.Size = new System.Drawing.Size(53, 17);
            this.rdParrot.TabIndex = 0;
            this.rdParrot.TabStop = true;
            this.rdParrot.Text = "Parrot";
            this.rdParrot.UseVisualStyleBackColor = true;
            // 
            // rdCat
            // 
            this.rdCat.AutoSize = true;
            this.rdCat.Location = new System.Drawing.Point(38, 62);
            this.rdCat.Name = "rdCat";
            this.rdCat.Size = new System.Drawing.Size(41, 17);
            this.rdCat.TabIndex = 1;
            this.rdCat.TabStop = true;
            this.rdCat.Text = "Cat";
            this.rdCat.UseVisualStyleBackColor = true;
            // 
            // rdHuman
            // 
            this.rdHuman.AutoSize = true;
            this.rdHuman.Location = new System.Drawing.Point(38, 100);
            this.rdHuman.Name = "rdHuman";
            this.rdHuman.Size = new System.Drawing.Size(59, 17);
            this.rdHuman.TabIndex = 2;
            this.rdHuman.TabStop = true;
            this.rdHuman.Text = "Human";
            this.rdHuman.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHuman);
            this.groupBox1.Controls.Add(this.rdCat);
            this.groupBox1.Controls.Add(this.rdParrot);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose something to say:";
            // 
            // lbSentences
            // 
            this.lbSentences.FormattingEnabled = true;
            this.lbSentences.Location = new System.Drawing.Point(35, 259);
            this.lbSentences.Name = "lbSentences";
            this.lbSentences.Size = new System.Drawing.Size(238, 69);
            this.lbSentences.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(642, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 55);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(396, 383);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(189, 55);
            this.btnTalk.TabIndex = 7;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(195, 383);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(178, 55);
            this.btnEat.TabIndex = 8;
            this.btnEat.Text = "Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnCaress
            // 
            this.btnCaress.Location = new System.Drawing.Point(13, 386);
            this.btnCaress.Name = "btnCaress";
            this.btnCaress.Size = new System.Drawing.Size(170, 51);
            this.btnCaress.TabIndex = 9;
            this.btnCaress.Text = "Caress";
            this.btnCaress.UseVisualStyleBackColor = true;
            this.btnCaress.Click += new System.EventHandler(this.btnCaress_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(548, 40);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(239, 69);
            this.btnMake.TabIndex = 10;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Give your animal the name";
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(243, 66);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(183, 20);
            this.txtAnimal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnCaress);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbSentences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdParrot;
        private System.Windows.Forms.RadioButton rdCat;
        private System.Windows.Forms.RadioButton rdHuman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSentences;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnCaress;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimal;
    }
}

