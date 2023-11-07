namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //list.Remove(2);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(i + j);
                    }
                    else if(i == 1)
                    {
                        Console.SetCursorPosition(i + 5, j);
                        Console.Write(i + j);
                    }
                    else
                    {
                        Console.SetCursorPosition(i + 10, j);
                        Console.Write(i + j);
                    }
                }
            }



        }
    }
}