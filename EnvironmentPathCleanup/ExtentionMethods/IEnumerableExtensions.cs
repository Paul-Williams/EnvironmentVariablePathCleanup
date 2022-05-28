namespace EnvironmentPathCleanup.ExtentionMethods;

public static class IEnumerableExtensions
{

  /// <summary>
  /// Ensure each string in the sequence is slash terminated.
  /// </summary>
  public static IEnumerable<string> SlashTerminate(this IEnumerable<string> seq!!)
  {
    foreach (var x in seq) yield return x[^1] == '\\' ? x : x + '\\';
  }

  public static IEnumerable<string> SkipNullAndWhiteSpace(this IEnumerable<string> seq!!)
  {
    foreach (var x in seq)
      if (!string.IsNullOrWhiteSpace(x))
        yield return x;
  }

  public static IEnumerable<string> DistinctIgnoreCase(this IEnumerable<string> seq!!)
    => seq!.Distinct(StringComparer.OrdinalIgnoreCase);


  //public static int RemoveAllIgnoreCase(this ICollection<string> seq1, IEnumerable<string> seq2)
  //  => RemoveAll(seq1, seq2, StringComparer.OrdinalIgnoreCase);

  //public static int RemoveAll<T>(this ICollection<T> first, IEnumerable<T> second, IEqualityComparer<T> comparer)
  //{
  //  var exclusiveToSeq1 = first.Intersect(second, comparer).ToArray();
  //  if (exclusiveToSeq1.Length != 0)
  //  {
  //    Array.ForEach(exclusiveToSeq1, x => _ = first.Remove(x));
  //    return exclusiveToSeq1.Length;
  //  }
  //  else return 0;
  //}

  //public static int Deduplicate<T>(this List<T> seq1, IEnumerable<T> other, IEqualityComparer<T> comparer)
  //{
  //  int r = 0;
  //  var exclusiveToSeq1 = seq1.Except(other, comparer).ToArray();
  //  if (exclusiveToSeq1.Length != seq1.Count)
  //  {
  //    r = seq1.Count - exclusiveToSeq1.Length;
  //    seq1.Clear();
  //    seq1.AddRange(exclusiveToSeq1);
  //  }
  //  return r;

  //}


}



