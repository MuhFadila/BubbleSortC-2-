using System;

namespace BubbleSortC__2_
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] = new int[20];

        // Deklarasi varibel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang di simpan pada array
            while (true)
            {
                Console.Write("Masukan elemen pada array: );
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _")
            Console.WriteLine("Masukan elemen array");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _")


        }
       
    }
}
