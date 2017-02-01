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
        public override string Title
        {
            get
            {
                return "Developer";
            }
        }
    }
}
