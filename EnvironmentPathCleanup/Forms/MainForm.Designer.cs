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
      this.OriginalMachinePathTextBox = new System.Windows.Forms.TextBox();
      this.OriginalUserPathTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.CleanedMachinePathTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.CleanedUserPathTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SaveButton = new System.Windows.Forms.Button();
      this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
      this.FooterLayout = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.UserDirectoriesRemovedLabel = new System.Windows.Forms.Label();
      this.MachineDirectoriesRemovedLabel = new System.Windows.Forms.Label();
      this.MainLayout.SuspendLayout();
      this.FooterLayout.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(853, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Original Machine Path";
      // 
      // OriginalMachinePathTextBox
      // 
      this.OriginalMachinePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OriginalMachinePathTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OriginalMachinePathTextBox.Location = new System.Drawing.Point(3, 28);
      this.OriginalMachinePathTextBox.Multiline = true;
      this.OriginalMachinePathTextBox.Name = "OriginalMachinePathTextBox";
      this.OriginalMachinePathTextBox.ReadOnly = true;
      this.OriginalMachinePathTextBox.Size = new System.Drawing.Size(853, 42);
      this.OriginalMachinePathTextBox.TabIndex = 1;
      // 
      // OriginalUserPathTextBox
      // 
      this.OriginalUserPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OriginalUserPathTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OriginalUserPathTextBox.Location = new System.Drawing.Point(3, 174);
      this.OriginalUserPathTextBox.Multiline = true;
      this.OriginalUserPathTextBox.Name = "OriginalUserPathTextBox";
      this.OriginalUserPathTextBox.ReadOnly = true;
      this.OriginalUserPathTextBox.Size = new System.Drawing.Size(853, 42);
      this.OriginalUserPathTextBox.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(3, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(853, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Original User Path";
      // 
      // CleanedMachinePathTextBox
      // 
      this.CleanedMachinePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CleanedMachinePathTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.CleanedMachinePathTextBox.Location = new System.Drawing.Point(3, 101);
      this.CleanedMachinePathTextBox.Multiline = true;
      this.CleanedMachinePathTextBox.Name = "CleanedMachinePathTextBox";
      this.CleanedMachinePathTextBox.Size = new System.Drawing.Size(853, 42);
      this.CleanedMachinePathTextBox.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(3, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(853, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Cleaned Machine Path";
      // 
      // CleanedUserPathTextBox
      // 
      this.CleanedUserPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CleanedUserPathTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.CleanedUserPathTextBox.Location = new System.Drawing.Point(3, 247);
      this.CleanedUserPathTextBox.Multiline = true;
      this.CleanedUserPathTextBox.Name = "CleanedUserPathTextBox";
      this.CleanedUserPathTextBox.Size = new System.Drawing.Size(853, 42);
      this.CleanedUserPathTextBox.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(3, 227);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(853, 17);
      this.label4.TabIndex = 6;
      this.label4.Text = "Cleaned User Path";
      // 
      // SaveButton
      // 
      this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.SaveButton.Location = new System.Drawing.Point(756, 26);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(94, 33);
      this.SaveButton.TabIndex = 8;
      this.SaveButton.Text = "Save Changes";
      this.SaveButton.UseVisualStyleBackColor = true;
      // 
      // MainLayout
      // 
      this.MainLayout.ColumnCount = 1;
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.MainLayout.Controls.Add(this.label1, 0, 0);
      this.MainLayout.Controls.Add(this.OriginalMachinePathTextBox, 0, 1);
      this.MainLayout.Controls.Add(this.CleanedMachinePathTextBox, 0, 3);
      this.MainLayout.Controls.Add(this.OriginalUserPathTextBox, 0, 5);
      this.MainLayout.Controls.Add(this.label3, 0, 2);
      this.MainLayout.Controls.Add(this.label2, 0, 4);
      this.MainLayout.Controls.Add(this.label4, 0, 6);
      this.MainLayout.Controls.Add(this.CleanedUserPathTextBox, 0, 7);
      this.MainLayout.Controls.Add(this.FooterLayout, 0, 8);
      this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainLayout.Location = new System.Drawing.Point(0, 0);
      this.MainLayout.Name = "MainLayout";
      this.MainLayout.RowCount = 9;
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.MainLayout.Size = new System.Drawing.Size(859, 383);
      this.MainLayout.TabIndex = 12;
      // 
      // FooterLayout
      // 
      this.FooterLayout.ColumnCount = 2;
      this.FooterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.FooterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.FooterLayout.Controls.Add(this.groupBox1, 0, 0);
      this.FooterLayout.Controls.Add(this.SaveButton, 1, 0);
      this.FooterLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.FooterLayout.Location = new System.Drawing.Point(3, 295);
      this.FooterLayout.Name = "FooterLayout";
      this.FooterLayout.RowCount = 1;
      this.FooterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.FooterLayout.Size = new System.Drawing.Size(853, 85);
      this.FooterLayout.TabIndex = 8;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.groupBox1.Controls.Add(this.UserDirectoriesRemovedLabel);
      this.groupBox1.Controls.Add(this.MachineDirectoriesRemovedLabel);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(203, 80);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Directories Removed";
      // 
      // UserDirectoriesRemovedLabel
      // 
      this.UserDirectoriesRemovedLabel.AutoSize = true;
      this.UserDirectoriesRemovedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UserDirectoriesRemovedLabel.Location = new System.Drawing.Point(6, 51);
      this.UserDirectoriesRemovedLabel.Name = "UserDirectoriesRemovedLabel";
      this.UserDirectoriesRemovedLabel.Size = new System.Drawing.Size(63, 17);
      this.UserDirectoriesRemovedLabel.TabIndex = 1;
      this.UserDirectoriesRemovedLabel.Text = "Removed";
      // 
      // MachineDirectoriesRemovedLabel
      // 
      this.MachineDirectoriesRemovedLabel.AutoSize = true;
      this.MachineDirectoriesRemovedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.MachineDirectoriesRemovedLabel.Location = new System.Drawing.Point(6, 28);
      this.MachineDirectoriesRemovedLabel.Name = "MachineDirectoriesRemovedLabel";
      this.MachineDirectoriesRemovedLabel.Size = new System.Drawing.Size(63, 17);
      this.MachineDirectoriesRemovedLabel.TabIndex = 0;
      this.MachineDirectoriesRemovedLabel.Text = "Removed";
      // 
      // MainForm
      // 
      this.AcceptButton = this.SaveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(859, 383);
      this.Controls.Add(this.MainLayout);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Path Environment Variable Cleanup";
      this.MainLayout.ResumeLayout(false);
      this.MainLayout.PerformLayout();
      this.FooterLayout.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Label label1;
    private TextBox OriginalMachinePathTextBox;
    private TextBox OriginalUserPathTextBox;
    private Label label2;
    private TextBox CleanedMachinePathTextBox;
    private Label label3;
    private TextBox CleanedUserPathTextBox;
    private Label label4;
    private Button SaveButton;
    private TableLayoutPanel MainLayout;
    private TableLayoutPanel FooterLayout;
    private GroupBox groupBox1;
    private Label UserDirectoriesRemovedLabel;
    private Label MachineDirectoriesRemovedLabel;
  }
}