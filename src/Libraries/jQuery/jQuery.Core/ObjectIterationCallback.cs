// ObjectIterationCallback.cs
// Script#/Libraries/jQuery/jQueryCore
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi {

    /// <summary>
    /// A callback to be invoked for each property in an object being iterated.
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="value">The value of the property.</param>
    [IgnoreNamespace]
    [Imported]
    public delegate void ObjectIterationCallback(string name, object value);

    /// <summary>
    /// A callback to be invoked for each property in an object being iterated.
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="value">The value of the property.</param>
    /// <returns>false if the iteration is to be stopped; true otherwise.</returns>
    [IgnoreNamespace]
    [Imported]
    public delegate bool ObjectInterruptableIterationCallback(string name, object value);
}
