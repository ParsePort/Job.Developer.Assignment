namespace Job.Developer.Assignment
{
    /// <summary>
    /// List Extensions.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Returns all combinations of <paramref name="matches"/> in <paramref name="sequence"/>.
        /// Example:
        /// - sequence: { 0, 1, 1 }
        /// - matches: { 0, 1 }
        /// - combinations: { 0, 1 }, { 0, 2 }
        /// </summary>
        /// <param name="sequence">The sequence to find matches.</param>
        /// <param name="matches">The matches to find.</param>
        /// <returns>The collection of match results, that contains the positions of a match.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<IEnumerable<int>> FindCombinations<T>(this IList<T> sequence, IList<T> matches)
        {
            throw new NotImplementedException();
        }
    }
}
