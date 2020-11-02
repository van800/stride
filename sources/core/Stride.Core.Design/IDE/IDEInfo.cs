﻿// Copyright (c) Stride contributors (https://stride3d.net)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace Stride.Core.IDE
{
    public class IDEInfo
    {
        public Version BuildNumber { get; }
        public string DisplayName { get; }
        public string Path { get; }

        public override string ToString()
        {
            return DisplayName;
        }

        public IDEInfo(Version buildNumber, string displayName, string path)
        {
            BuildNumber = buildNumber;
            DisplayName = displayName;
            Path = path;
        }
    }
}