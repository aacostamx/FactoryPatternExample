//------------------------------------------------------------------------
// <copyright file="FactoryPatternExample.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//-----------------------------------------------------------------------

namespace FactoryPatternExample
{
    using System;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                var position = Factory.Get(i);
                Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);
            }

            Console.ReadKey();
        }
    }
}
