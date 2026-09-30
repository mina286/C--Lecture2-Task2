namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //Task 1
            int PerSmall = 25;
            int PerLarge = 35;
            double SalesTaxRate = 0.06;
            int StimatesValidDays = 30;

            Console.WriteLine("Number of small carpets");
            int NumberSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets");
            int NumberLargeCarpets = Convert.ToInt32(Console.ReadLine());

            double Cost = (NumberSmallCarpets * PerSmall) + (NumberLargeCarpets * PerLarge);
            double Tax = Cost * SalesTaxRate;
            double TotalEstimate = Cost + Tax;

            Console.WriteLine($"Price per small carpet : {PerSmall}");
            Console.WriteLine($"Price per large carpet : {PerLarge}");
            Console.WriteLine($"Cost : {Cost}");
            Console.WriteLine($"Tax: {Tax}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Total estimate: {TotalEstimate}");
            Console.WriteLine($"This estimate is valid for {StimatesValidDays} days");

            // Task 2
            int X = 10;
            int Y = 20;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");

            //Answer 1 
            // c حرف  يسمى Currency Format وهو بيضيع رمز العمله بناءا على اعدادت الجهاز 
            //Answer 2
            // الفائده تحويل الارقام تلقائيا واضافة الرموز 
            //Answer 3
            int number = 1000000;
            Console.WriteLine($"Amount: {number:N0}");
            
        }
    }
}
