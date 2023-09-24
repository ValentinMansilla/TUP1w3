namespace Transporte
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            recursosToolStripMenuItem = new ToolStripMenuItem();
            cargasToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            camionesToolStripMenuItem = new ToolStripMenuItem();
            cargasToolStripMenuItem1 = new ToolStripMenuItem();
            nuevoTransporteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, recursosToolStripMenuItem, cargasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // recursosToolStripMenuItem
            // 
            recursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { camionesToolStripMenuItem, cargasToolStripMenuItem1 });
            recursosToolStripMenuItem.Name = "recursosToolStripMenuItem";
            recursosToolStripMenuItem.Size = new Size(98, 29);
            recursosToolStripMenuItem.Text = "Recursos";
            // 
            // cargasToolStripMenuItem
            // 
            cargasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoTransporteToolStripMenuItem });
            cargasToolStripMenuItem.Name = "cargasToolStripMenuItem";
            cargasToolStripMenuItem.Size = new Size(119, 29);
            cargasToolStripMenuItem.Text = "Transportes";
            cargasToolStripMenuItem.Click += cargasToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // camionesToolStripMenuItem
            // 
            camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            camionesToolStripMenuItem.Size = new Size(270, 34);
            camionesToolStripMenuItem.Text = "Camiones";
            // 
            // cargasToolStripMenuItem1
            // 
            cargasToolStripMenuItem1.Name = "cargasToolStripMenuItem1";
            cargasToolStripMenuItem1.Size = new Size(270, 34);
            cargasToolStripMenuItem1.Text = "Cargas";
            // 
            // nuevoTransporteToolStripMenuItem
            // 
            nuevoTransporteToolStripMenuItem.Name = "nuevoTransporteToolStripMenuItem";
            nuevoTransporteToolStripMenuItem.Size = new Size(270, 34);
            nuevoTransporteToolStripMenuItem.Text = "Nuevo transporte";
            nuevoTransporteToolStripMenuItem.Click += nuevoTransporteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem recursosToolStripMenuItem;
        private ToolStripMenuItem camionesToolStripMenuItem;
        private ToolStripMenuItem cargasToolStripMenuItem1;
        private ToolStripMenuItem cargasToolStripMenuItem;
        private ToolStripMenuItem nuevoTransporteToolStripMenuItem;
    }
}