namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> comps = new List<Computer>()
            {
                new Computer(123,"Lenovo","type1",9900,228,64,1000,500000,50),
                new Computer(456,"Apple","type2",1520,125,128,600,5000000,30),
                new Computer(789,"Xiaomi","type1",9900,250,225,300,10000,1),
                new Computer(124,"Lenovo","type3",5500,228,64,1000,150000,23),
                new Computer(125,"Huawei","type2",14500,125,128,800,23000,43),
                new Computer(126,"Apple","type3",8000,185,225,700,50000,56),
                new Computer(123,"Kotik","type1",5500,1200,64,400,230000,5),

            };
            Print(comps);

            Console.WriteLine("Введите название процессора ");
            string name = Console.ReadLine();
            List <Computer> comps2 = comps.Where(x=>x.Processor_type==name).ToList();
            Print(comps2);


            Console.WriteLine("Введите объем ОЗУ ");
            int vol=Convert.ToInt32(Console.ReadLine());
            List <Computer> comps3 = comps.Where (x=>x.Opmemory_volume>=vol).ToList();
            Print(comps3);
            Console.WriteLine();

            List<Computer> comps4 = comps.OrderBy(x=>x.Price).ToList();
            Print(comps4);
            Console.WriteLine();

            IEnumerable<IGrouping<string, Computer>> comps5 = comps.GroupBy(x=>x.Processor_type);

            foreach (IGrouping<string, Computer> gr in comps5)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Brand_code},{c.Brand_name},{c.Processor_type}, {c.Processorfreq},{c.Opmemory_volume},{c.Disk_volume},{c.Vidmemory_volume},{c.Price},{c.Number}");

                }
            }

            Console.WriteLine();

            Computer comp6=comps.OrderByDescending(x=>x.Price).FirstOrDefault();
            Console.WriteLine($"{comp6.Brand_code},{comp6.Brand_name},{comp6.Processor_type}, {comp6.Processorfreq},{comp6.Opmemory_volume},{comp6.Disk_volume},{comp6.Vidmemory_volume},{comp6.Price},{comp6.Number}");
            Console.WriteLine();
            Computer comp7 = comps.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{comp7.Brand_code},{comp7.Brand_name},{comp7.Processor_type}, {comp7.Processorfreq},{comp7.Opmemory_volume},{comp7.Disk_volume},{comp7.Vidmemory_volume},{comp7.Price},{comp7.Number}");
            Console.WriteLine();

            

            if (comps.Any(x=>x.Number>30)==true)
            {
                Console.WriteLine("есть");
            }
            else { Console.WriteLine("нет"); }
            Console.ReadKey();

        }

        static void Print(List <Computer> computers)
        {
            foreach (Computer c in computers)
            {

                Console.WriteLine($"{c.Brand_code},{c.Brand_name},{c.Processor_type}, {c.Processorfreq},{c.Opmemory_volume},{c.Disk_volume},{c.Vidmemory_volume},{c.Price},{c.Number}");
              

            }
            


        }
    }
}
