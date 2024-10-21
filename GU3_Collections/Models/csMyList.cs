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
            Dictionary<T, (int, List<T>)> nrItems = ItemsOccurances;
            foreach (var item in nrItems.Values)
            {
                if (item.Item1 == 2) return true;
            }
            return false;
        }}

    public bool ContainsTripplets { get
        {
            Dictionary<T, (int, List<T>)> nrItems = ItemsOccurances;
            foreach (var item in nrItems.Values)
            {
                if (item.Item1 == 3) return true;
            }
            return false;
        }}

    public bool ContainsQuads { get
        {
            Dictionary<T, (int, List<T>)> nrItems = ItemsOccurances;
            foreach (var item in nrItems.Values)
            {
                if (item.Item1 == 4) return true;
            }
            return false;
        }}

    public bool ContainsFullHouse => ContainsPair && ContainsTripplets;

    public IList<T> UniqueItems { get
        {
            var uniques = new HashSet<T>(this);
            return uniques.ToList();
        }}


    public Dictionary<T, (int, List<T>)> ItemsOccurances { get
        {
            var nrItems = new Dictionary<T,  (int, List<T>)>();
            this.ForEach(p =>
            {
                if (nrItems.ContainsKey(p))
                {
                    var t = nrItems[p];
                    t.Item1++;
                    t.Item2.Add(p);

                    nrItems[p] = t;
                }
                else
                {   
                    (int, List<T>) t = (1, null);
                    t.Item2 = new List<T>();
                    t.Item2.Add(p);

                    nrItems.Add(p, t);
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