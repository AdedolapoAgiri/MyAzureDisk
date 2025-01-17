// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Input of the custom domain to be validated for DNS mapping. </summary>
    public partial class FrontDoorValidateCustomDomainContent
    {
        /// <summary> Initializes a new instance of <see cref="FrontDoorValidateCustomDomainContent"/>. </summary>
        /// <param name="hostName"> The host name of the custom domain. Must be a domain name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public FrontDoorValidateCustomDomainContent(string hostName)
        {
            Argument.AssertNotNull(hostName, nameof(hostName));

            HostName = hostName;
        }

        /// <summary> The host name of the custom domain. Must be a domain name. </summary>
        public string HostName { get; }
    }
}
