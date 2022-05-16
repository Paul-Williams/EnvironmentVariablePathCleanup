namespace EnvironmentPathCleanup.Forms;
using Controllers;

public partial class MainForm : Form
{
  public MainForm()
  {
    InitializeComponent();

    try
    {
      BindControls();
    }
    catch (Exception ex)
    {
      ShowExceptionDialog(ex);
      throw;
    }


  }

  private static void ShowExceptionDialog(Exception ex) => MessageBox.Show($"{ex.Message}\n\n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);



  private void BindControls()
  {

    new Binder<MainFormController>(new MainFormController())
      .BindText(OriginalMachinePathTextBox, x => x.OriginalMachinePath)
      .BindText(OriginalUserPathTextBox, x => x.OriginalUserPath)
      .BindText(CleanedMachinePathTextBox, x => x.CleanedMachinePath)
      .BindText(CleanedUserPathTextBox, x => x.CleanedUserPath)
      .BindClick(SaveButton, c => c.Save)
      .BindEnabled(SaveButton, nameof(MainFormController.CanSave))
      .BindText(MachineDirectoriesRemovedLabel, x => x.MachinePathDirectoriesRemoved)
      .BindText(UserDirectoriesRemovedLabel, x => x.UserPathDirectoriesRemoved);
  }

}
