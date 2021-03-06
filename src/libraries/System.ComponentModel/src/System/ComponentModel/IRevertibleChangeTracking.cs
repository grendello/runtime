// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.ComponentModel
{
    /// <summary>
    /// Provides support for rolling back the changes
    /// </summary>
    public interface IRevertibleChangeTracking : IChangeTracking
    {
        /// <summary>
        /// Resets the object's state to unchanged by rejecting the modifications.
        /// </summary>
        void RejectChanges();
    }
}
