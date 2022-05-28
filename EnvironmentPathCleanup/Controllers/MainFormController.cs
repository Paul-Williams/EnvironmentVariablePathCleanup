namespace EnvironmentPathCleanup.Controllers;

using System.ComponentModel;
using System.Linq;
using static PW.Extensions.ICollectionExtensions;
using static PW.Extensions.IEnumerableExtensions;

internal class MainFormController : BindingObjectBase
{
  public MainFormController()
  {
    Init();
  }

  private static IList<string> GetPathEntries(EnvironmentVariableTarget target)
  {
    return Environment.GetEnvironmentVariable("PATH", target) is string path
      ? path.Split(';', StringSplitOptions.RemoveEmptyEntries)
      : (IList<string>)new List<string>();
  }


  private static int InitListPair(BindingList<string> original!!, BindingList<string> cleaned!!, EnvironmentVariableTarget source)
  {
    original.RaiseListChangedEvents = false;
    cleaned.RaiseListChangedEvents = false;

    original.Clear();
    cleaned.Clear();

    GetPathEntries(source).ForEach(original.Add);

    if (original.Count != 0) Cleanup(original).ForEach(cleaned.Add);

    original.RaiseListChangedEvents = true;
    cleaned.RaiseListChangedEvents = true;

    return original.Count - cleaned.Count;
  }


  private void Init()
  {
    MachinePathEntriesRemoved = InitListPair(CurrentMachineEntries, ProposedMachineEntries, EnvironmentVariableTarget.Machine);
    UserPathEntriesRemoved = InitListPair(CurrentUserEntries, ProposedUserEntries, EnvironmentVariableTarget.User)
      + ProposedUserEntries.RemoveAll(ProposedMachineEntries);
  }


  public BindingList<string> ProposedMachineEntries { get; } = new();

  public BindingList<string> ProposedUserEntries { get; } = new();

  public BindingList<string> CurrentMachineEntries { get; } = new();

  public BindingList<string> CurrentUserEntries { get; } = new();

  public bool CanSave => true; // Hack

  public int MachinePathEntriesRemoved { get; set; }

  public int UserPathEntriesRemoved { get; set; }


  public void Save()
  {
    if (!CanSave) throw new InvalidOperationException("CanSave is false.");

    Environment.SetEnvironmentVariable("PATH", string.Join(';', ProposedMachineEntries), EnvironmentVariableTarget.Machine);
    Environment.SetEnvironmentVariable("PATH", string.Join(';', ProposedUserEntries), EnvironmentVariableTarget.User);
    Init();
  }

  public void Refresh() => Init();

  /// <summary>
  /// Cleans up a list of directories by removing duplicates and non-existent ones.
  /// </summary>
  /// <param name="directories"></param>
  /// <returns></returns>
  /// <remarks>
  /// Method:
  /// Begin by excluding and elements that are null or whitespace, just in case.
  /// Some directories were duplicates, other than for a trailing slashes
  /// so remove and reinstate trailing slashes first, to normalize things.
  /// This is designed for Windows, so we ignore case when removing duplicate directories.
  /// Finally remove any remaining directory entries which don't actually exist on disk.
  /// </remarks>
  private static string[] Cleanup(IEnumerable<string> directories!!)
  {

    return directories
      .SkipNullAndWhiteSpace()
      .SlashTerminate()
      .DistinctIgnoreCase()
      .Where(Directory.Exists)
      .ToArray();

  }




}
