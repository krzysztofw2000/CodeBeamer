
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace CodeBeamerRadiostacja
{
    partial class Radiostacja
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
            lblFirmware = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblFirmware
            // 
            lblFirmware.AutoSize = true;
            lblFirmware.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblFirmware.Location = new Point(63, 39);
            lblFirmware.Name = "lblFirmware";
            lblFirmware.Size = new Size(411, 54);
            lblFirmware.TabIndex = 0;
            lblFirmware.Text = "wersja Firmware: 1.0";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnStart.Location = new Point(63, 182);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(168, 71);
            btnStart.TabIndex = 1;
            btnStart.Text = "Test";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Radiostacja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(btnStart);
            Controls.Add(lblFirmware);
            Name = "Radiostacja";
            Text = "Panel radiostacji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirmware;
        private Button btnStart;
    }
}
