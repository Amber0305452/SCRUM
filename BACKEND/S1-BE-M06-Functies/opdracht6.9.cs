using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media; 


namespace Opdracht_9_Example
{
    class prExclass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Convert time to a figglefoint so it displays the time big with *'s               
                string font = Figgle.FiggleFonts.Katakana.Render(DateTime.Now.ToString("h | mm | ss tt"));
                font = font.Replace("#", "*");
                //displays the time in the selected font
                Console.WriteLine(font);               
                Thread.Sleep(1000);
                Console.Clear();
                //calls the function for the sound
                Playsound();
            }
        }
        static void Playsound()
        {
            //Selects current time and gets seconds and minutes from it.
            DateTime Now = DateTime.Now;
            int seconds = Now.Second;
            int minutes = Now.Minute;
            //When both the minutes and seconds equal 0 it plays a cuckoo sound
            if(seconds==0 && minutes == 0)
            {                
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Amber\source\repos\opdracht6.9\Opdracht9Test\cuckoo.wav");
                simpleSound.Play();
            }
        }
    }
}
