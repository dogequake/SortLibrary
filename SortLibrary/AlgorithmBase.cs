namespace SortLibrary
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;


        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(int PositionA, int PositionB) 
        {
            if (PositionA < Items.Count && PositionB < Items.Count)
            {
                var temp = Items[PositionA];
                Items[PositionA] = Items[PositionB];
                Items[PositionB] = temp;

                SwopCount++;
            }
        }

        public virtual void Sort() 
        {
            SwopCount = 0;
            Items.Sort();
        }
    }
}