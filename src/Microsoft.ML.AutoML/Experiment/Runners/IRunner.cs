﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;

namespace Microsoft.ML.AutoML
{
    internal interface IRunner<TRunDetail> where TRunDetail : RunDetail
    {
        (SuggestedPipelineRunDetail suggestedPipelineRunDetail, TRunDetail runDetail)
            Run(SuggestedPipeline pipeline, DirectoryInfo modelDirectory, int iterationNum);
    }
}
