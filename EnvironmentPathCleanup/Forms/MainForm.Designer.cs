namespace EnvironmentPathCleanup.Forms
{
  partial class MainForm
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
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SaveButton = new System.Windows.Forms.Button();
      this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.MachineDirectoriesRemovedLabel = new System.Windows.Forms.Label();
      this.UserDirectoriesRemovedLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.CurrentMachineEntriesListBox = new System.Windows.Forms.ListBox();
      this.ProposedMachineEntriesListBox = new System.Windows.Forms.ListBox();
      this.CurrentUserEntriesListBox = new System.Windows.Forms.ListBox();
      this.ProposedUserEntriesListBox = new System.Windows.Forms.ListBox();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.MainLayout.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(445, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Current Machine Path Entries";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(3, 262);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(445, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Current User Path Entries";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(454, 262);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(446, 17);
      this.label4.TabIndex = 6;
      this.label4.Text = "Proposed User Path Entries";
      // 
      // SaveButton
      // 
      this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.SaveButton.Location = new System.Drawing.Point(787, 13);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(101, 33);
      this.SaveButton.TabIndex = 8;
      this.SaveButton.Text = "Save Changes";
      this.SaveButton.UseVisualStyleBackColor = true;
      // 
      // MainLayout
      // 
      this.MainLayout.ColumnCount = 2;
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.Controls.Add(this.panel1, 0, 4);
      this.MainLayout.Controls.Add(this.label1, 0, 0);
      this.MainLayout.Controls.Add(this.label3, 1, 0);
      this.MainLayout.Controls.Add(this.label2, 0, 2);
      this.MainLayout.Controls.Add(this.label4, 1, 2);
      this.MainLayout.Controls.Add(this.CurrentMachineEntriesListBox, 0, 1);
      this.MainLayout.Controls.Add(this.ProposedMachineEntriesListBox, 1, 1);
      this.MainLayout.Controls.Add(this.CurrentUserEntriesListBox, 0, 3);
      this.MainLayout.Controls.Add(this.ProposedUserEntriesListBox, 1, 3);
      this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainLayout.Location = new System.Drawing.Point(0, 0);
      this.MainLayout.Name = "MainLayout";
      this.MainLayout.RowCount = 5;
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.MainLayout.Size = new System.Drawing.Size(903, 568);
      this.MainLayout.TabIndex = 12;
      // 
      // panel1
      // 
      this.MainLayout.SetColumnSpan(this.panel1, 2);
      this.panel1.Controls.Add(this.RefreshButton);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.MachineDirectoriesRemovedLabel);
      this.panel1.Controls.Add(this.UserDirectoriesRemovedLabel);
      this.panel1.Controls.Add(this.SaveButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 511);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(897, 54);
      this.panel1.TabIndex = 13;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label7.Location = new System.Drawing.Point(10, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(147, 17);
      this.label7.TabIndex = 4;
      this.label7.Text = "Entries To Be Removed";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.Location = new System.Drawing.Point(186, 30);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 17);
      this.label6.TabIndex = 3;
      this.label6.Text = "User Path:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(10, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 17);
      this.label5.TabIndex = 2;
      this.label5.Text = "Machine Path:";
      // 
      // MachineDirectoriesRemovedLabel
      // 
      this.MachineDirectoriesRemovedLabel.AutoSize = true;
      this.MachineDirectoriesRemovedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.MachineDirectoriesRemovedLabel.Location = new System.Drawing.Point(105, 30);
      this.MachineDirectoriesRemovedLabel.Name = "MachineDirectoriesRemovedLabel";
      this.MachineDirectoriesRemovedLabel.Size = new System.Drawing.Size(63, 17);
      this.MachineDirectoriesRemovedLabel.TabIndex = 0;
      this.MachineDirectoriesRemovedLabel.Text = "Removed";
      // 
      // UserDirectoriesRemovedLabel
      // 
      this.UserDirectoriesRemovedLabel.AutoSize = true;
      this.UserDirectoriesRemovedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UserDirectoriesRemovedLabel.Location = new System.Drawing.Point(259, 30);
      this.UserDirectoriesRemovedLabel.Name = "UserDirectoriesRemovedLabel";
      this.UserDirectoriesRemovedLabel.Size = new System.Drawing.Size(63, 17);
      this.UserDirectoriesRemovedLabel.TabIndex = 1;
      this.UserDirectoriesRemovedLabel.Text = "Removed";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(454, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(446, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Proposed Machine Path Entries";
      // 
      // CurrentMachineEntriesListBox
      // 
      this.CurrentMachineEntriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.CurrentMachineEntriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentMachineEntriesListBox.FormattingEnabled = true;
      this.CurrentMachineEntriesListBox.IntegralHeight = false;
      this.CurrentMachineEntriesListBox.ItemHeight = 15;
      this.CurrentMachineEntriesListBox.Location = new System.Drawing.Point(3, 28);
      this.CurrentMachineEntriesListBox.Name = "CurrentMachineEntriesListBox";
      this.CurrentMachineEntriesListBox.Size = new System.Drawing.Size(445, 223);
      this.CurrentMachineEntriesListBox.TabIndex = 9;
      // 
      // ProposedMachineEntriesListBox
      // 
      this.ProposedMachineEntriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ProposedMachineEntriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProposedMachineEntriesListBox.FormattingEnabled = true;
      this.ProposedMachineEntriesListBox.IntegralHeight = false;
      this.ProposedMachineEntriesListBox.ItemHeight = 15;
      this.ProposedMachineEntriesListBox.Location = new System.Drawing.Point(454, 28);
      this.ProposedMachineEntriesListBox.Name = "ProposedMachineEntriesListBox";
      this.ProposedMachineEntriesListBox.Size = new System.Drawing.Size(446, 223);
      this.ProposedMachineEntriesListBox.TabIndex = 10;
      // 
      // CurrentUserEntriesListBox
      // 
      this.CurrentUserEntriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.CurrentUserEntriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentUserEntriesListBox.FormattingEnabled = true;
      this.CurrentUserEntriesListBox.IntegralHeight = false;
      this.CurrentUserEntriesListBox.ItemHeight = 15;
      this.CurrentUserEntriesListBox.Location = new System.Drawing.Point(3, 282);
      this.CurrentUserEntriesListBox.Name = "CurrentUserEntriesListBox";
      this.CurrentUserEntriesListBox.Size = new System.Drawing.Size(445, 223);
      this.CurrentUserEntriesListBox.TabIndex = 11;
      // 
      // ProposedUserEntriesListBox
      // 
      this.ProposedUserEntriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ProposedUserEntriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProposedUserEntriesListBox.FormattingEnabled = true;
      this.ProposedUserEntriesListBox.IntegralHeight = false;
      this.ProposedUserEntriesListBox.ItemHeight = 15;
      this.ProposedUserEntriesListBox.Location = new System.Drawing.Point(454, 282);
      this.ProposedUserEntriesListBox.Name = "ProposedUserEntriesListBox";
      this.ProposedUserEntriesListBox.Size = new System.Drawing.Size(446, 223);
      this.ProposedUserEntriesListBox.TabIndex = 12;
      // 
      // button1
      // 
      this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.RefreshButton.Location = new System.Drawing.Point(670, 13);
      this.RefreshButton.Name = "button1";
      this.RefreshButton.Size = new System.Drawing.Size(101, 33);
      this.RefreshButton.TabIndex = 9;
      this.RefreshButton.Text = "Refresh";
      this.RefreshButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AcceptButton = this.SaveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 568);
      this.Controls.Add(this.MainLayout);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Path Environment Variable Cleanup";
      this.MainLayout.ResumeLayout(false);
      this.MainLayout.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label4;
    private Button SaveButton;
    private TableLayoutPanel MainLayout;
    private Label UserDirectoriesRemovedLabel;
    private Label MachineDirectoriesRemovedLabel;
    private Label label6;
    private Label label5;
    private Label label3;
    private ListBox CurrentMachineEntriesListBox;
    private ListBox ProposedMachineEntriesListBox;
    private ListBox CurrentUserEntriesListBox;
    private ListBox ProposedUserEntriesListBox;
    private Panel panel1;
    private Label label7;
    private Button RefreshButton;
  }
}