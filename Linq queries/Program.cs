public class Program
{
    //ICollection 
    //IList
    //List
    private static void Main(string[] args)
    {
        List<string> Data = new List<string>();
        Data.Add("chalk");
        Data.Add("tyrone");
        Data.Add("clone");
        Data.Add("reserve");
        Data.Add("align");
        Data.Add("disregard");
    }
    public static void CollectionDisplay (ICollection<string> mylist)
    {
        foreach(var item in mylist)
        {
            Console.WriteLine("the List elements are as follows:"+ item);
        }
    }
    public static void IListDisplay(ICollection<string> mylist)
    {
        foreach (var item in mylist)
        {
            Console.WriteLine("the List elements are as follows:" + item);
        }
    }
    public static void ListDisplay(ICollection<string> mylist)
    {
        foreach (var item in mylist)
        {
            Console.WriteLine("the List elements are as follows:" + item);
        }
    }
}