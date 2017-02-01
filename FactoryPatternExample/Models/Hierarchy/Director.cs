//------------------------------------------------------------------------
// <copyright file="Director.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample.Models.Hierarchy
{
    /// <summary>
    /// Director
    /// </summary>
    /// <seealso cref="FactoryPatternExample.Models.Position" />
    public class Director : Position
    {
        public override string Title
        {
            get
            {
                return "Director";
            }
        }
    }
}
