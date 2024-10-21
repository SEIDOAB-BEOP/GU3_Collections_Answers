namespace Models;
public class csMyList<T> : List<T>, IMyList<T>
{
    public bool ContainsDuplicates { get
        {
            var uniques = new HashSet<T>(this);
            return this.Count != uniques.Count;
        }}
    
    public bool ContainsPair { get
        {
            Dictionary<T, int> nrItems = ItemsOccurances;
            return nrItems.ContainsValue(2);
        }}

    public bool ContainsTripplets { get
        {
            Dictionary<T, int> nrItems = ItemsOccurances;
            return nrItems.ContainsValue(3);
        }}

    public bool ContainsQuads { get
        {
            Dictionary<T, int> nrItems = ItemsOccurances;
            return nrItems.ContainsValue(4);
        }}

    public bool ContainsFullHouse => ContainsPair && ContainsTripplets;

    public IList<T> UniqueItems { get
        {
            var uniques = new HashSet<T>(this);
            return uniques.ToList();
        }}


    public Dictionary<T, int> ItemsOccurances { get
        {
            var nrItems = new Dictionary<T, int>();
            this.ForEach(p =>
            {
                if (nrItems.ContainsKey(p))
                {
                    nrItems[p]++;
                }
                else
                {
                    nrItems.Add(p, 1);
                }
            });
            return nrItems;
        }}
}

/* extra uppgift

1.  Ändra ItemOccurances public Dictionary<T, (int, List<T>)> ItemsOccurances
2.  Modifiera ItemOccurances så att för varje Key T i dictionary ska det finnas en tupple som först ger besked om hur många gånger T förekommer,
    och sedan ger en lista på alla förekomster.
*/