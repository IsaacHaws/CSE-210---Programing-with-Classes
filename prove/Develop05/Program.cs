using System;

class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/hPF1QZen4CRlynI1_yLbzGL4n7-r5Q58gOSUIYbnTsf3iycIPAMbzTsxcqdQiEYXeWT9ledV_FB5cLd7ZMig2ONarhAbvf9zmkXvroxMlC8niyu8jGlI0crXHEs4LhtAdHRAsJ5hlm4caxbMrZM5qsOwXRop7T1nfbhN8GkRyjTlsFsKrTuc0_YtHBSC48CiDejo2dAaIZ190V9xBBGfFKX6bFb2s5hoZwZjjIWXNzcvhcg93ijEt6ejuG3jnqSp-HgDs4Pq1xfz8buxD8hBdZf_nU9D2kky3a0nHuSOTX4xXdunFtDsW4Dln7wCiqiaGEpXeWJVGxNdi5w2ZT3Ij2dPhLQDNJSLUORz_qetodc9NI1hMZjHOLZw9XbZz2U-2WXRDE5kKOuaGJuT0vT_Yc73z-Xl_o8agcI82UWcgEdSF1ZXi2l47edThURbKRjMwhOhLU9xeYKnzKiK6AdXHQHGQEEHnoSWnYDJVthYuxI75pt035NPLF8R

        int points = 0;

        bool quit = false;

        List<Goal> goals = new List<Goal>();

        while (quit != true) {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            int menuAnswer = int.Parse(Console.ReadLine());



            switch (menuAnswer)
            {
                case 1: 
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goaltype = int.Parse(Console.ReadLine());

                    if (goaltype == 1) {
                        Console.WriteLine("What is the name of your goal? ");

                    }

                    else if (goaltype == 2) {

                    }

                    else if (goaltype == 3) {

                    }
                    
                    
                    
                    
                    
                    break;
    
                default:
                    Console.WriteLine("Error!");
                    break;
            }







        }
    }
}