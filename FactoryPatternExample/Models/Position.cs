//------------------------------------------------------------------------
// <copyright file="Position.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample.Models
{
    /// <summary>
    /// Abstract Class Position
    /// </summary>
    public abstract class Position
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public abstract string Title { get; }
    }
}
