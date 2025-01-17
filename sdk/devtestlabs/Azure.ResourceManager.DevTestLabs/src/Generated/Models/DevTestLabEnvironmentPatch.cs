// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> An environment, which is essentially an ARM template deployment. </summary>
    public partial class DevTestLabEnvironmentPatch : DevTestLabResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabEnvironmentPatch"/>. </summary>
        public DevTestLabEnvironmentPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabEnvironmentPatch"/>. </summary>
        /// <param name="tags"> The tags of the resource. </param>
        internal DevTestLabEnvironmentPatch(IDictionary<string, string> tags) : base(tags)
        {
        }
    }
}
