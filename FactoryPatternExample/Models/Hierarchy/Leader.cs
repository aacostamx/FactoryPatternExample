//------------------------------------------------------------------------
// <copyright file="Leader.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample.Models
{
    /// <summary>
    /// CEO class
    /// </summary>
    /// <seealso cref="FactoryPatternExample.Models.Position" />
    public class Leader : Position
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public override string Title
        {
            get
            {
                return "Leader";
            }
        }
    }
}
