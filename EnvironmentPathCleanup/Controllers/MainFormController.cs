namespace EnvironmentPathCleanup.Controllers;

internal class MainFormController : BindingObjectBase
{
  #region Backing Fields
  private string? cleanedMachineName;

  private string? cleanedUserPath;

  private string? originalMachinePath;

  private string? originalUserPath;
  #endregion


  public MainFormController()
  {
    Init();

  }

  public int Delme;

  private void Init()
  {
    OriginalMachinePath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
    OriginalUserPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

    if (OriginalMachinePath != null)
    {
      var originalDirectories = OriginalMachinePath.Split(';', StringSplitOptions.RemoveEmptyEntries);
      var cleanedDirectories = Cleanup(originalDirectories);

      MachinePathDirectoriesRemoved = originalDirectories.Length - cleanedDirectories.Length;
      CleanedMachinePath = string.Join(';', cleanedDirectories);
    }

    if (OriginalUserPath != null)
    {
      var originalDirectories = OriginalUserPath.Split(';', StringSplitOptions.RemoveEmptyEntries);
      var cleanedDirectories = Cleanup(originalDirectories);

      UserPathDirectoriesRemoved = originalDirectories.Length - cleanedDirectories.Length;
      CleanedUserPath = string.Join(';', cleanedDirectories);
    }
  }

  public string? CleanedMachinePath
  {
    get { return cleanedMachineName; }
    set { _ = SetPropertyValue(ref cleanedMachineName, value); }
  }

  public string? CleanedUserPath
  {
    get { return cleanedUserPath; }
    set { _ = SetPropertyValue(ref cleanedUserPath, value); }
  }

  public string? OriginalMachinePath
  {
    get { return originalMachinePath; }
    set { _ = SetPropertyValue(ref originalMachinePath, value); }
  }

  public string? OriginalUserPath
  {
    get { return originalUserPath; }
    set { _ = SetPropertyValue(ref originalUserPath, value); }
  }

  public bool CanSave => true; // Hack

  public int MachinePathDirectoriesRemoved { get; set; }

  public int UserPathDirectoriesRemoved { get; set; }


  public void Save()
  {
    if (!CanSave) throw new InvalidOperationException("CanSave is false.");

    Environment.SetEnvironmentVariable("PATH", CleanedMachinePath, EnvironmentVariableTarget.Machine);
    Environment.SetEnvironmentVariable("PATH", CleanedUserPath, EnvironmentVariableTarget.User);
    Init();
  }


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
      .ExcludeNullAndWhiteSpace()
      .EnsureIsSlashTerminated()
      .Distinct(StringComparer.OrdinalIgnoreCase)
      .Where(Directory.Exists)
      .ToArray();

  }




}
