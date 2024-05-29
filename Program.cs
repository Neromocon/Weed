using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Traffic_light
{
    class CSignal
    {
        const bool TRUE = true;
        const bool FALSE = false;
        const bool ON = true;
        const bool OFF = false;

        void SetColor(ConsoleColor forground, ConsoleColor background)
        {
            Console.ForegroundColor = forground;
            Console.BackgroundColor = background;
        }
        public CSignal() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("프로그램을 시작합니다.");
            Console.WriteLine("**********************");
        }

        void Lamp(ConsoleColor color, bool onoff)
        {
            if(onoff ==  ON)
            {
                SetColor(color, color);
            }
            else
            {
                SetColor(ConsoleColor.White, ConsoleColor.Gray);
            }
            Console.WriteLine("          ");
            Console.WriteLine("          ");
            Console.WriteLine("          ");
            Console.WriteLine("          ");
            Console.WriteLine("          ");
            SetColor(ConsoleColor.White, ConsoleColor.Black);
        }

        void RedLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, ON);
            Lamp(ConsoleColor.Yellow, OFF); 
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("이것은 신호등입니다.");
        }
        void YellowLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, ON);
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("이것은 신호등입니다.");
        }
        void GreenLamp()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, OFF);
            Lamp(ConsoleColor.Green, ON);
            Console.WriteLine("이것은 신호등입니다.");
        }
        int nStep;
        int nCount;
        public bool loop()
        {
            switch (nStep)
            {
                case 0: // 초기화 시킴
                    nStep = 100;
                    nCount = 0;
                    RedLampOn();
                    break; // Red On
                case 100:               
                    if(nCount < 5)
                    {
                        nCount++;
                    }                
                    else
                    {
                        nCount = 6;
                        nStep = 200;
                        YellowLampOn();
                    }
                    break;
                
                case 200:  // Yellow On                   
                    if(nCount < 5)
                    {
                        nCount++;
                    }
                    else
                    {
                        nCount = 0;
                        nStep = 300;
                        GreenLamp();
                    }
                    break;
                    
                case 300:
                   
                    if( nCount < 3)
                    {
                        nCount++;
                    }
                    
                    else
                    {
                        nCount = 0;
                        nStep = 0;
                    }
                    break;
                default:
                    nStep = 0;
                    break;
                
            }
            Thread.Sleep(1000);
            return true;
        }
        //public bool loop()
        //{
        //    return true;
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CSignal sig = new CSignal();
            while (sig.loop()) ;
        }
    }
}
