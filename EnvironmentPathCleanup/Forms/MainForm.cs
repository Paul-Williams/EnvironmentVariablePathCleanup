using EnvironmentPathCleanup.Controllers;

namespace EnvironmentPathCleanup.Forms;

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
      Environment.Exit(ex.HResult);
    }
  }

  private static void ShowExceptionDialog(Exception ex)
  {
    MessageBox.Show($"{ex.Message}\n\n{ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }

  private void BindControls()
  {

    new Binder<MainFormController>(new MainFormController())
      .BindList(CurrentMachineEntriesListBox, x => x.CurrentMachineEntries)
      .BindList(CurrentUserEntriesListBox, x => x.CurrentUserEntries)
      .BindList(ProposedMachineEntriesListBox, x => x.ProposedMachineEntries)
      .BindList(ProposedUserEntriesListBox, x => x.ProposedUserEntries)
      .BindClick(SaveButton, c => c.Save)
      .BindEnabled(SaveButton, x => x.CanSave)
      .BindClick(RefreshButton, x => x.Refresh)
      .BindText(MachineDirectoriesRemovedLabel, x => x.MachinePathEntriesRemoved)
      .BindText(UserDirectoriesRemovedLabel, x => x.UserPathEntriesRemoved);
  }

}
