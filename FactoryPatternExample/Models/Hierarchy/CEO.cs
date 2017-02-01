//------------------------------------------------------------------------
// <copyright file="CEO.cs" company="Volaris">
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
    public class CEO : Position
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
                return "CEO";
            }
        }
    }
}
