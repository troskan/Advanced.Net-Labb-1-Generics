namespace Labb1_Advanced_Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxes = new BoxCollection();
            boxes.Add(new Box(10, 20, 30));
            boxes.Add(new Box(20, 50, 90));
            boxes.Add(new Box(30, 80, 100));
            boxes.Add(new Box(40, 90, 110));//<- Same volume

            boxes.Add(new Box(110, 90, 40));//^

            boxes.Add(new Box(10, 20, 30)); //<- Same Dimension as first box
             
           // boxes.Add(new Box(9, 5, 3));

            boxes.Remove(new Box(20, 50, 90));
            boxes.Remove(new Box(24, 8888, 9000000));
            //boxes.Remove(new Box(3, 6, 5));
            Console.WriteLine("---");
            int counter = 0;
            foreach (var box in boxes)
            {
                counter++;
                Console.WriteLine();
                Console.WriteLine($"Box #{counter}: {box}");
            }
            //Display Method

            boxes.Display();

            Console.WriteLine("---");
            Console.WriteLine(boxes.BoxExist(new Box(20, 90, 50)));

            //Contains
            //Console.WriteLine(boxes.BoxExist(new Box(9, 3, 5)));

        }
    }
}