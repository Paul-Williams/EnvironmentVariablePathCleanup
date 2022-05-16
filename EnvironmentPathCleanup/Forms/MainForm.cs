using EnvironmentPathCleanup.Controllers;

namespace EnvironmentPathCleanup.Forms;

public partial class MainForm : Form
{
  public MainForm()
  {
    InitializeComponent();

    try
    {
      //throw new  InvalidCastException("It has all gone horribly wrong!",new InvalidDataException("Beetroot"));

      BindControls();
    }
    catch (Exception ex)
    {
      ShowExceptionDialog(ex);
      Environment.Exit(ex.HResult);
    }

  }

  private void ShowExceptionDialog(Exception ex)
  {
    MessageBox.Show($"{ex.Message}\n\n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

    //var page = new TaskDialogPage
    //{
    //  Caption = ex.Message,
    //  Icon = TaskDialogIcon.Error,
    //  Text = ex.ToString()
    //};

    //page.Buttons.Add(new TaskDialogButton("Close"));



    TaskDialog.ShowDialog(this, page, TaskDialogStartupLocation.CenterScreen);


  }

  private void BindControls()
  {

    new Binder<MainFormController>(new MainFormController())
      .BindText(OriginalMachinePathTextBox, x => x.OriginalMachinePath)
      .BindText(OriginalUserPathTextBox, x => x.OriginalUserPath)
      .BindText(CleanedMachinePathTextBox, x => x.CleanedMachinePath)
      .BindText(CleanedUserPathTextBox, x => x.CleanedUserPath)
      .BindClick(SaveButton, c => c.Save)
      .BindEnabled(SaveButton, x => x.CanSave)
      .BindText(MachineDirectoriesRemovedLabel, x => x.MachinePathDirectoriesRemoved)
      .BindText(UserDirectoriesRemovedLabel, x => x.UserPathDirectoriesRemoved);
  }

}
