﻿using System;
using System.IO;

using Flir.Atlas.Image;

namespace Heatscan.Scan
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Argument (scan folder) missing");
                return;
            }

            Console.WriteLine("GO Gadget");
            try
            {
                var scanFolder = new DirectoryInfo(args[0]);
                if (!scanFolder.Exists)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Argument ({args[0]}) is not an existing folder");
                }

                var scanImageFiles = scanFolder.GetFiles("*.jpg");

                var min = double.MaxValue;
                var max = double.MinValue;

                foreach (var imageFile in scanImageFiles)
                {
                    using (var file = new ThermalImageFile(imageFile.FullName))
                    {
                        //file.Changed += (fileChange, args1) =>
                        //{
                        //    Console.WriteLine("\tFile changed");
                        //    Console.WriteLine(fileChange);
                        //};
                        var fileInfo = new FileInfo(file.FileName);
                        Console.Write(fileInfo.Name);
                        Console.Write(";");
                        Console.Write(file.Scale.Range.Maximum);
                        Console.Write(";");
                        Console.Write(file.Scale.Range.Minimum);
                        Console.Write(";");

                        if (file.Scale.Range.Maximum > max)
                        {
                            max = file.Scale.Range.Maximum;
                        }

                        if (file.Scale.Range.Minimum < min
                            && file.Scale.Range.Minimum > -20)
                        {
                            min = file.Scale.Range.Minimum;
                        }

                        //file.Scale.ScaleImageChanged += (scaleChange, args2) =>
                        //{
                        //    Console.WriteLine("\tScale changed");
                        //    Console.WriteLine(scaleChange);
                        //};
                        //using (var scale = file.Scale)
                        //{
                        //    scale.Range = new Range<double>(-13, 5);
                        //}

                        Console.WriteLine();

                        // file.Save();
                        file.Close();
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Max. value: {max}");
                Console.WriteLine($"Min. value: {min}");
                Console.WriteLine();
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception);
            }

            Console.WriteLine("Ready!");
            Console.Read();
        }
    }
}