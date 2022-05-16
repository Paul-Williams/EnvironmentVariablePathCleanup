namespace EnvironmentPathCleanup.ExtentionMethods;

public static class IEnumerableExtensions
{

  /// <summary>
  /// Ensure each string in the sequence is slash terminated.
  /// </summary>
  public static IEnumerable<string> EnsureIsSlashTerminated(this IEnumerable<string> seq!!)
  {
    foreach (var x in seq) yield return x[^1] == '\\' ? x : x + '\\';
  }

  public static IEnumerable<string> ExcludeNullAndWhiteSpace(this IEnumerable<string> seq!!)
  {
    foreach (var x in seq) 
      if (!string.IsNullOrWhiteSpace(x))  
        yield return x[^1] == '\\' ? x : x + '\\';
  }


}



