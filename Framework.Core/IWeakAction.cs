﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IWeakAction
    {
        /// <summary>
        /// Executes an action.
        /// </summary>
        void Execute();

        /// <summary>
        /// Deletes all references, which notifies the cleanup method
        /// that this entry must be deleted.
        /// </summary>
        void MarkForDeletion();

        /// <summary>
        /// The target of the WeakAction.
        /// </summary>
        object Target { get; }
    }
}
