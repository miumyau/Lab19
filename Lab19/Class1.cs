using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Computer
    {
        private int brand_code;
        private string brand_name;
        private string processor_type;
        private int processorfreq;
        private int opmemory_volume;
        private int disk_volume;
        private int vidmemory_volume;
        private int price;
        private int number;

        public int Brand_code { get { return brand_code; } set { brand_code = value; } }
        public string Brand_name { get { return brand_name; } set { brand_name = value; } }
        public string Processor_type { get { return processor_type; } set { processor_type = value; } }
        public int Processorfreq { get {  return processorfreq; } set {  processorfreq = value; } }
        public int Opmemory_volume { get {  return opmemory_volume; } set {  opmemory_volume = value; } }
        public int Vidmemory_volume { get { return vidmemory_volume; } set { vidmemory_volume = value; } }
        public int Disk_volume { get { return disk_volume; } set { disk_volume = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Number { get { return number; } set { number = value; } }
        public Computer (int brand_code,  string brand_name, string processor_type, int processorfreq, int opmemory_volume, int disk_volume, int vidmemory_volume, int price, int number)
        {
            Brand_code=brand_code;
            Brand_name= brand_name;
            Processor_type= processor_type;
            Processorfreq= processorfreq;
            Opmemory_volume= opmemory_volume;
            Disk_volume= disk_volume;
            Vidmemory_volume= vidmemory_volume;
            Price= price;
            Number= number;

        }
       
    }

    }

