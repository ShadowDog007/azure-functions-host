﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs.Script.Abstractions.Rpc;

namespace Microsoft.Azure.WebJobs.Script.Dispatch
{
    internal delegate ILanguageWorkerChannel CreateChannel(WorkerConfig conf, IObservable<FunctionRegistrationContext> registrations);

    internal interface ILanguageWorkerChannel : IDisposable
    {
        string Id { get; }

        WorkerConfig Config { get; }
    }
}
