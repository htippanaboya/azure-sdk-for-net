// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownArtifactAccessCredential. </summary>
    internal partial class UnknownArtifactAccessCredential : ArtifactAccessCredential
    {
        /// <summary> Initializes a new instance of UnknownArtifactAccessCredential. </summary>
        /// <param name="credentialType"> The credential type. </param>
        internal UnknownArtifactAccessCredential(CredentialType credentialType) : base(credentialType)
        {
            CredentialType = credentialType;
        }
    }
}
