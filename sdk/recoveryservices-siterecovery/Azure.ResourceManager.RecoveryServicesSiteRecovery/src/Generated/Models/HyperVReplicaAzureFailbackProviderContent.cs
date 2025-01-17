// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVReplicaAzureFailback specific planned failover input. </summary>
    public partial class HyperVReplicaAzureFailbackProviderContent : PlannedFailoverProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureFailbackProviderContent"/>. </summary>
        public HyperVReplicaAzureFailbackProviderContent()
        {
            InstanceType = "HyperVReplicaAzureFailback";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureFailbackProviderContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="dataSyncOption"> Data sync option. </param>
        /// <param name="recoveryVmCreationOption"> ALR options to create alternate recovery. </param>
        /// <param name="providerIdForAlternateRecovery"> Provider Id for alternate location. </param>
        internal HyperVReplicaAzureFailbackProviderContent(string instanceType, string dataSyncOption, string recoveryVmCreationOption, string providerIdForAlternateRecovery) : base(instanceType)
        {
            DataSyncOption = dataSyncOption;
            RecoveryVmCreationOption = recoveryVmCreationOption;
            ProviderIdForAlternateRecovery = providerIdForAlternateRecovery;
            InstanceType = instanceType ?? "HyperVReplicaAzureFailback";
        }

        /// <summary> Data sync option. </summary>
        public string DataSyncOption { get; set; }
        /// <summary> ALR options to create alternate recovery. </summary>
        public string RecoveryVmCreationOption { get; set; }
        /// <summary> Provider Id for alternate location. </summary>
        public string ProviderIdForAlternateRecovery { get; set; }
    }
}
