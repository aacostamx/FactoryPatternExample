﻿//------------------------------------------------------------------------
// <copyright file="Factory.cs" company="Volaris">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace FactoryPatternExample
{
    using Models;
    using Models.Hierarchy;

    /// <summary>
    /// Factory class
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static Position Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new CEO();
                case 1:
                    return new Director();
                case 2:
                    return new Leader();
                case 3:
                default:
                    return new Developer();
            }
        }
    }
}
