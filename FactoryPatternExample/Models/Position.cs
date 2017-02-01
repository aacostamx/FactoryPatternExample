//------------------------------------------------------------------------
// <copyright file="Position.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample.Models
{
    /// <summary>
    /// Interface Class Position
    /// </summary>
    public interface Position
    {
        /// <summary>
        /// Gets the get position.
        /// </summary>
        /// <value>
        /// The get position.
        /// </value>
        string GetTitle { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        void GetName();
    }
}
