﻿// <copyright file="SampleClass.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace FormattingSample
{
    using System.Threading.Tasks;

    /// <summary>
    /// Provides a sample code for formatting capabilities of the editor.
    /// </summary>
    public class SampleClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleClass"/> class.
        /// </summary>
        public SampleClass()
        {
            /* intentionally left blank */
        }

        /// <summary>
        /// A sample method that returns a task.
        /// </summary>
        /// <returns>An instance of the task.</returns>
        public async Task SampleMethod()
        {
            await Task.Run(async () => await Task.Delay(1000));
        }
    }
}
