using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Opdracht_9_Example
{
    class prExclass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string font = Figgle.FiggleFonts.Katakana.Render(DateTime.Now.ToString("h : mm : ss tt"));
                font = font.Replace("#", "*");
                Console.WriteLine(font);               
                Thread.Sleep(1000);
                Console.Clear();
            }
        }       
    }
}
