
namespace LAB01_EDII
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tPInsertar = new System.Windows.Forms.TabPage();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tPBuscar = new System.Windows.Forms.TabPage();
            this.rTBSearch = new System.Windows.Forms.RichTextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tPInsertar.SuspendLayout();
            this.tPBuscar.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Talent Hub Software";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tPInsertar
            // 
            this.tPInsertar.Controls.Add(this.btnInsertar);
            this.tPInsertar.Location = new System.Drawing.Point(10, 47);
            this.tPInsertar.Name = "tPInsertar";
            this.tPInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tPInsertar.Size = new System.Drawing.Size(719, 616);
            this.tPInsertar.TabIndex = 1;
            this.tPInsertar.Text = "Insertar";
            this.tPInsertar.UseVisualStyleBackColor = true;
            this.tPInsertar.Click += new System.EventHandler(this.tPInsertar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(253, 243);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(171, 43);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar CSV";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tPBuscar
            // 
            this.tPBuscar.Controls.Add(this.rTBSearch);
            this.tPBuscar.Controls.Add(this.tBName);
            this.tPBuscar.Controls.Add(this.btnSearch);
            this.tPBuscar.Controls.Add(this.lblName);
            this.tPBuscar.Location = new System.Drawing.Point(10, 47);
            this.tPBuscar.Name = "tPBuscar";
            this.tPBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tPBuscar.Size = new System.Drawing.Size(719, 616);
            this.tPBuscar.TabIndex = 0;
            this.tPBuscar.Text = "Buscar";
            this.tPBuscar.UseVisualStyleBackColor = true;
            // 
            // rTBSearch
            // 
            this.rTBSearch.Location = new System.Drawing.Point(39, 244);
            this.rTBSearch.Name = "rTBSearch";
            this.rTBSearch.ReadOnly = true;
            this.rTBSearch.Size = new System.Drawing.Size(616, 280);
            this.rTBSearch.TabIndex = 3;
            this.rTBSearch.Text = "";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(295, 73);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(232, 35);
            this.tBName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(250, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(152, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tPBuscar);
            this.tabcontrol.Controls.Add(this.tPInsertar);
            this.tabcontrol.Location = new System.Drawing.Point(75, 125);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(739, 673);
            this.tabcontrol.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Form1";
            this.Text = "Talent Hub";
            this.tPInsertar.ResumeLayout(false);
            this.tPBuscar.ResumeLayout(false);
            this.tPBuscar.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tPInsertar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TabPage tPBuscar;
        private System.Windows.Forms.RichTextBox rTBSearch;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabcontrol;
    }
}

