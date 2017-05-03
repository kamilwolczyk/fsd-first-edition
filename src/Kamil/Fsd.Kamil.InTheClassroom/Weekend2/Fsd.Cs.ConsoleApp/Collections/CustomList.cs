namespace Fsd.Cs.ConsoleApp.Collections
{
    public class CustomList<TItem1, TItem2, TItem3>
    {
        public TItem1[] Items1 { get; set; }
        public TItem2[] Items2 { get; set; }
        public TItem3[] Items3 { get; set; }

        public CustomList()
        {
            Items1 = new TItem1[10];
            Items2 = new TItem2[10];
            Items3 = new TItem3[10];
        }
    }

    public class CustomDataPair <TItem1, TItem2>
    {
        public TItem1 Item1{ get; set; }
        public TItem2 Item2{ get; set; }
    }
}
