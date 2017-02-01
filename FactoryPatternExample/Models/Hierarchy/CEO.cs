//------------------------------------------------------------------------
// <copyright file="CEO.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

using System;

namespace FactoryPatternExample.Models
{
    /// <summary>
    /// CEO class
    /// </summary>
    /// <seealso cref="FactoryPatternExample.Models.Position" />
    public class CEO : Position
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
                return "CEO";
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public void GetName()
        {
            Console.WriteLine("Name: Antonio Acosta");
        }
    }
}
