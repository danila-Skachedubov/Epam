namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> massiv = new DynamicArray<int>(8);
            massiv.AddRange(new int[] { 7, 9, 4, 3, 2, 2, 4, 6, 7 });
            massiv[5] = 4;
            massiv.Insert(0, 5);
          //  massiv.AddRange(new int[] { 7, 9, 4, 3, 2 });
           // massiv.RemoveAt(2);
           // massiv.Remove(9);
            // massiv.Add(6);
        }
    }
}
