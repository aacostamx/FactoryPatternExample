//------------------------------------------------------------------------
// <copyright file="Director.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

using System;

namespace FactoryPatternExample.Models.Hierarchy
{
    /// <summary>
    /// Director
    /// </summary>
    /// <seealso cref="FactoryPatternExample.Models.Position" />
    public class Director : Position
    {
        /// <summary>
        /// Gets the get position.
        /// </summary>
        /// <value>
        /// The get position.
        /// </value>
        public string GetTitle
        {
            get
            {
                return "Director";
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public void GetName()
        {
            Console.WriteLine("Name: Gerardo Perez");
        }
    }
}
