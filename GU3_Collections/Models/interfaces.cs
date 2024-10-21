namespace Models;
public interface IMyList<T>: IList<T>
{
    /// <summary>
    /// returns true if List<T> contains elements that are equal, otherwise false
    /// </summary>
    public bool ContainsDuplicates { get;}

    /// <summary>
    /// returns true if List<T> contains two elemens that are equal, otherwise false
    /// </summary>
    public bool ContainsPair { get;}

    /// <summary>
    /// returns true if List<T> contains three elemens that are equal, otherwise false
    /// </summary>
    public bool ContainsTripplets { get;}

    /// <summary>
    /// returns true if List<T> contains  four elemens that are equal, otherwise false
    /// </summary>
    public bool ContainsQuads { get;}

    /// <summary>
    /// returns true if List<T> contains two elements AND four elemens that are equal, otherwise false
    /// </summary>
    public bool ContainsFullHouse {get;}

    /// <summary>
    /// returns List<T> with all duplicates removed
    /// </summary>
    public IList<T> UniqueItems {get;}

    /// <summary>
    /// returns Dictionary<T, int> which has an entry for every unique item in the list as Dictionary Key. 
    /// Dictionary Value is the number of times the item occurs in the list
    /// </summary>
    public Dictionary<T, (int, List<T>)> ItemsOccurances {get;}
}