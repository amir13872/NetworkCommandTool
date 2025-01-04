using System;
using System.Windows.Forms;

namespace NetworkCommandTool.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabARP = new System.Windows.Forms.TabPage();
            this.tabPing = new System.Windows.Forms.TabPage();
            this.tabNetsh = new System.Windows.Forms.TabPage();
            this.tabNetBIOS = new System.Windows.Forms.TabPage();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabARP);
            this.tabControl.Controls.Add(this.tabPing);
            this.tabControl.Controls.Add(this.tabNetsh);
            this.tabControl.Controls.Add(this.tabNetBIOS);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 400);
            this.tabControl.TabIndex = 0;
            // 
            // tabARP
            // 
            this.tabARP.Location = new System.Drawing.Point(4, 22);
            this.tabARP.Name = "tabARP";
            this.tabARP.Padding = new System.Windows.Forms.Padding(3);
            this.tabARP.Size = new System.Drawing.Size(768, 374);
            this.tabARP.TabIndex = 0;
            this.tabARP.Text = "ARP Operations";
            this.tabARP.UseVisualStyleBackColor = true;
            // 
            // tabPing
            // 
            this.tabPing.Location = new System.Drawing.Point(4, 22);
            this.tabPing.Name = "tabPing";
            this.tabPing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPing.Size = new System.Drawing.Size(768, 374);
            this.tabPing.TabIndex = 1;
            this.tabPing.Text = "Ping Operations";
            this.tabPing.UseVisualStyleBackColor = true;
            // 
            // tabNetsh
            // 
            this.tabNetsh.Location = new System.Drawing.Point(4, 22);
            this.tabNetsh.Name = "tabNetsh";
            this.tabNetsh.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetsh.Size = new System.Drawing.Size(768, 374);
            this.tabNetsh.TabIndex = 2;
            this.tabNetsh.Text = "Network Configuration";
            this.tabNetsh.UseVisualStyleBackColor = true;
            // 
            // tabNetBIOS
            // 
            this.tabNetBIOS.Location = new System.Drawing.Point(4, 22);
            this.tabNetBIOS.Name = "tabNetBIOS";
            this.tabNetBIOS.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetBIOS.Size = new System.Drawing.Size(768, 374);
            this.tabNetBIOS.TabIndex = 3;
            this.tabNetBIOS.Text = "NetBIOS Scan";
            this.tabNetBIOS.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(12, 418);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(776, 150);
            this.richTextBoxResults.TabIndex = 1;
            this.richTextBoxResults.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 571);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Network Command Tool";
            this.tabControl.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabARP;
        private System.Windows.Forms.TabPage tabPing;
        private System.Windows.Forms.TabPage tabNetsh;
        private System.Windows.Forms.TabPage tabNetBIOS;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}