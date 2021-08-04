using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static float[,] map =
        {
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 6, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 8, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 1000, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
                {0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2, 0, 1, 3, 3, 6, 2, 5, 1, 0, 0, 1, 0, 8, 2, 3, 2},
        };
        static float[,] actualMap =
        {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 1, 0, 0, 2, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 2, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        };

        static double playerX = 100;
        static double playerY = 100;
        static double playerRot = 0;

        static float playerSpeed = 5;

        static string[] chars = { "  ", "::", "OO", "XX", "SS", "$$", "##", "░░", "▒▒", "▓▓", "██" };
        static ConsoleColor[] colours = { ConsoleColor.Black, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.White,};

        static void Main(string[] args)
        {
            Console.SetWindowSize(128, 32);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                for (int x = 0; x < 32; x++)
                    for (int y = 0; y < 32; y++)
                        if (y > 14)
                            map[y, x] = 0;
                        else
                            map[y, x] = 140;
                Raycast();

                for (int x = 0; x < 32; x++)
                {
                    if(x == 1)
                        Console.Write(("X: " + ((int)playerX).ToString() + " Y: " + ((int)playerY).ToString()).PadRight(31) + "|");
                    else
                        Console.Write(" ".PadRight(31) + "|");
                    for (int y = 0; y < 32; y++)
                    {
                        if (x >= 20 && y >= 15 && y <=17)
                        {
                            map[x, y] = 140;
                            // gun
                            Console.BackgroundColor = ConsoleColor.Red;
                            if (x >= 24)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                            }
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        if (x >= 28 && y < 20 && y > 12)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            map[x, y] = 140;
                        }
                        int thing = (int)map[x, y];
                        if(thing == -1)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write("  ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                            Console.Write(chars[9 - (int)(thing / 15)]);
                        //Console.BackgroundColor = colours[(int)(thing / 25)];
                        //Console.Write("  ");
                    }
                    Console.WriteLine("|");
                }
                Console.ResetColor();

                Controls(Console.ReadKey().Key);
            }
        }

        static void Raycast()
        {
            for (short Iterator = 0; Iterator < 32; Iterator++) //Going through each degree in you FOV
            {
                double RayX = playerX;
                double RayY = playerY;
                ushort Distance = 0;
                do
                {
                    RayX += (Math.Cos(Math.PI * (playerRot + Iterator) / 180));
                    RayY -= (Math.Sin(Math.PI * (playerRot + Iterator) / 180));
                    Distance++;
                } while (actualMap[(int)RayY / 20, (int)RayX / 20] <= 0);
                for (int Y = (32 / 2) - (32 / 2) / Clamp((Distance / 16), 1, 10000); Y < (32 / 2) + (32 / 2) / Clamp((Distance / 10), 1, 10000); Y++)
                {
                    /*if (actualMap[(int)RayY / 20, (int)RayX / 20] == 2 && Iterator == 16)
                        map[15, Iterator] = -1;
                    else*/
                        map[Y, Iterator] = Distance;
                }
            }
        }

        static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        static ConsoleColor EvaluateZ(float z)
        {
            if (z <= 0)
                return (ConsoleColor.White);
            else if (z < 25)
                return (ConsoleColor.Gray);
            else if (z < 50)
                return (ConsoleColor.DarkGray);
            else if (z == 1000)
                return (ConsoleColor.DarkGreen);
            else
                return (ConsoleColor.Black);
        }

        static void Controls(ConsoleKey key)
        {

            if (key == ConsoleKey.W)
            {
                playerX += (Math.Cos(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                playerY -= (Math.Sin(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                if(actualMap[(int)playerY / 20, (int)playerX / 20] == 1) // if there's a wall there, undo
                {
                    playerX -= (Math.Cos(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                    playerY += (Math.Sin(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                }
            }
            else if (key == ConsoleKey.S)
            {
                playerX -= (Math.Cos(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                playerY += (Math.Sin(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                if (actualMap[(int)playerY / 20, (int)playerX / 20] == 1) // if there's a wall there, undo
                {
                    playerX += (Math.Cos(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                    playerY -= (Math.Sin(Math.PI * ((playerRot + 16) / 180))) * playerSpeed;
                }

            }
            else if (key == ConsoleKey.D)
            {
                playerRot += 10;
            }
            else if (key == ConsoleKey.A)
            {
                playerRot -= 10;
            }
            else if (key == ConsoleKey.Spacebar)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = Environment.CurrentDirectory + "/Assets/shoot.wav";
                sound.Play();
            }
        }

        public struct Vector3
        {
            float x;
            float y;
            float z;
        }
    }
}
