
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tPBuscar = new System.Windows.Forms.TabPage();
            this.rTBSearch = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tPInsertar = new System.Windows.Forms.TabPage();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tPActualizar = new System.Windows.Forms.TabPage();
            this.tPEliminar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarAct = new System.Windows.Forms.Button();
            this.tBNameAct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBDPIAct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBActualizar = new System.Windows.Forms.GroupBox();
            this.dTPNacimientoAct = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tBDireccionAct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tBDPIEliminar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tBNombreEliminar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabcontrol.SuspendLayout();
            this.tPBuscar.SuspendLayout();
            this.tPInsertar.SuspendLayout();
            this.tPActualizar.SuspendLayout();
            this.tPEliminar.SuspendLayout();
            this.gBActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tPBuscar);
            this.tabcontrol.Controls.Add(this.tPInsertar);
            this.tabcontrol.Controls.Add(this.tPActualizar);
            this.tabcontrol.Controls.Add(this.tPEliminar);
            this.tabcontrol.Location = new System.Drawing.Point(75, 125);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(739, 673);
            this.tabcontrol.TabIndex = 0;
            // 
            // tPBuscar
            // 
            this.tPBuscar.Controls.Add(this.rTBSearch);
            this.tPBuscar.Controls.Add(this.btnSearch);
            this.tPBuscar.Controls.Add(this.tBName);
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
            this.rTBSearch.Size = new System.Drawing.Size(616, 280);
            this.rTBSearch.TabIndex = 3;
            this.rTBSearch.Text = "";
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
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(295, 73);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(232, 35);
            this.tBName.TabIndex = 1;
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
            // 
            // tPActualizar
            // 
            this.tPActualizar.Controls.Add(this.gBActualizar);
            this.tPActualizar.Controls.Add(this.tBDPIAct);
            this.tPActualizar.Controls.Add(this.label3);
            this.tPActualizar.Controls.Add(this.btnBuscarAct);
            this.tPActualizar.Controls.Add(this.tBNameAct);
            this.tPActualizar.Controls.Add(this.label2);
            this.tPActualizar.Location = new System.Drawing.Point(10, 47);
            this.tPActualizar.Name = "tPActualizar";
            this.tPActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tPActualizar.Size = new System.Drawing.Size(719, 616);
            this.tPActualizar.TabIndex = 2;
            this.tPActualizar.Text = "Actualizar";
            this.tPActualizar.UseVisualStyleBackColor = true;
            // 
            // tPEliminar
            // 
            this.tPEliminar.Controls.Add(this.tBDPIEliminar);
            this.tPEliminar.Controls.Add(this.label6);
            this.tPEliminar.Controls.Add(this.btnEliminar);
            this.tPEliminar.Controls.Add(this.tBNombreEliminar);
            this.tPEliminar.Controls.Add(this.label7);
            this.tPEliminar.Location = new System.Drawing.Point(10, 47);
            this.tPEliminar.Name = "tPEliminar";
            this.tPEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tPEliminar.Size = new System.Drawing.Size(719, 616);
            this.tPEliminar.TabIndex = 3;
            this.tPEliminar.Text = "Eliminar";
            this.tPEliminar.UseVisualStyleBackColor = true;
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
            // btnBuscarAct
            // 
            this.btnBuscarAct.Location = new System.Drawing.Point(261, 206);
            this.btnBuscarAct.Name = "btnBuscarAct";
            this.btnBuscarAct.Size = new System.Drawing.Size(171, 43);
            this.btnBuscarAct.TabIndex = 5;
            this.btnBuscarAct.Text = "Buscar";
            this.btnBuscarAct.UseVisualStyleBackColor = true;
            // 
            // tBNameAct
            // 
            this.tBNameAct.Location = new System.Drawing.Point(295, 66);
            this.tBNameAct.Name = "tBNameAct";
            this.tBNameAct.Size = new System.Drawing.Size(232, 35);
            this.tBNameAct.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // tBDPIAct
            // 
            this.tBDPIAct.Location = new System.Drawing.Point(295, 142);
            this.tBDPIAct.Name = "tBDPIAct";
            this.tBDPIAct.Size = new System.Drawing.Size(232, 35);
            this.tBDPIAct.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "DPI";
            // 
            // gBActualizar
            // 
            this.gBActualizar.Controls.Add(this.btnActualizar);
            this.gBActualizar.Controls.Add(this.tBDireccionAct);
            this.gBActualizar.Controls.Add(this.label5);
            this.gBActualizar.Controls.Add(this.label4);
            this.gBActualizar.Controls.Add(this.dTPNacimientoAct);
            this.gBActualizar.Enabled = false;
            this.gBActualizar.Location = new System.Drawing.Point(124, 304);
            this.gBActualizar.Name = "gBActualizar";
            this.gBActualizar.Size = new System.Drawing.Size(481, 263);
            this.gBActualizar.TabIndex = 8;
            this.gBActualizar.TabStop = false;
            this.gBActualizar.Text = "Actualización de Información";
            // 
            // dTPNacimientoAct
            // 
            this.dTPNacimientoAct.Location = new System.Drawing.Point(201, 62);
            this.dTPNacimientoAct.Name = "dTPNacimientoAct";
            this.dTPNacimientoAct.Size = new System.Drawing.Size(200, 35);
            this.dTPNacimientoAct.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nacimiento:";
            // 
            // tBDireccionAct
            // 
            this.tBDireccionAct.Location = new System.Drawing.Point(196, 129);
            this.tBDireccionAct.Name = "tBDireccionAct";
            this.tBDireccionAct.Size = new System.Drawing.Size(232, 35);
            this.tBDireccionAct.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizar.Location = new System.Drawing.Point(137, 202);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(171, 43);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // tBDPIEliminar
            // 
            this.tBDPIEliminar.Location = new System.Drawing.Point(293, 228);
            this.tBDPIEliminar.Name = "tBDPIEliminar";
            this.tBDPIEliminar.Size = new System.Drawing.Size(232, 35);
            this.tBDPIEliminar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "DPI";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(259, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 43);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // tBNombreEliminar
            // 
            this.tBNombreEliminar.Location = new System.Drawing.Point(293, 152);
            this.tBNombreEliminar.Name = "tBNombreEliminar";
            this.tBNombreEliminar.Size = new System.Drawing.Size(232, 35);
            this.tBNombreEliminar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre:";
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
            this.tabcontrol.ResumeLayout(false);
            this.tPBuscar.ResumeLayout(false);
            this.tPBuscar.PerformLayout();
            this.tPInsertar.ResumeLayout(false);
            this.tPActualizar.ResumeLayout(false);
            this.tPActualizar.PerformLayout();
            this.tPEliminar.ResumeLayout(false);
            this.tPEliminar.PerformLayout();
            this.gBActualizar.ResumeLayout(false);
            this.gBActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tPBuscar;
        private System.Windows.Forms.TabPage tPInsertar;
        private System.Windows.Forms.TabPage tPActualizar;
        private System.Windows.Forms.TabPage tPEliminar;
        private System.Windows.Forms.RichTextBox rTBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gBActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tBDireccionAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPNacimientoAct;
        private System.Windows.Forms.TextBox tBDPIAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarAct;
        private System.Windows.Forms.TextBox tBNameAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBDPIEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tBNombreEliminar;
        private System.Windows.Forms.Label label7;
    }
}

