﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace MonitoringFunctions.Models
{
    /// <summary> Stores the contents of output streams of a script execution. </summary>
    internal struct ScriptExecutionResult : IEquatable<ScriptExecutionResult>
    {
        /// <summary> Contents of the output stream as string </summary>
        public string? Output { get; set; }

        /// <summary> Contents of the error stream as string </summary>
        public string? Error { get; set; }

        public bool Equals([AllowNull] ScriptExecutionResult other)
        {
            return Output == other.Output &&
                Error == other.Error;
        }

        public override string? ToString()
        {
            return $"ScriptExecutionResult - Output: {Output}, Error: {Error}";
        }
    }
}
