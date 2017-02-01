//------------------------------------------------------------------------
// <copyright file="Developer.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample.Models.Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Developer
    /// </summary>
    /// <seealso cref="FactoryPatternExample.Models.Position" />
    public class Developer : Position
    {
        /// <summary>
        /// Gets the get position.
        /// </summary>
        /// <value>
        /// The get position.
        /// </value>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTitle
        {
            get
            {
                return "Developer";
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public void GetName()
        {
            Console.WriteLine("Name: Jose López");
        }
    }
}
