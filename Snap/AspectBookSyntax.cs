﻿/*
Snap v1.0

Copyright (c) 2010 Tyler Brinks

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System.Collections.Generic;
using System.Linq;

namespace Snap
{
    /// <summary>
    /// Entry point to configure set of registered aspects in a single step. 
    /// It's a place where any kind of configuration for a set of aspects (aspect book) is applicable.
    /// </summary>
    public class AspectBookSyntax : IAspectBookSyntax
    {
        private readonly IList<AspectRegistration> _aspects;

        public AspectBookSyntax(IEnumerable<AspectRegistration> aspects)
        {
            _aspects = aspects.ToList();
        }

        /// <summary>
        /// Configure aspects to be resolved from container.
        /// </summary>
        /// <remarks>
        /// Besides that, also you should register aspects in container.
        /// </remarks>>
        public void KeepInContainer()
        {
            foreach (var aspectConfiguration in _aspects)
            {
                aspectConfiguration.KeptInContainer = true;
            }
        }
    }
}