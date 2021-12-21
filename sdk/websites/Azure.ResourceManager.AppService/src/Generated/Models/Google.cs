// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Google provider. </summary>
    public partial class Google
    {
        /// <summary> Initializes a new instance of Google. </summary>
        public Google()
        {
        }

        /// <summary> Initializes a new instance of Google. </summary>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the Google provider. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        /// <param name="validation"> The configuration settings of the Azure Active Directory token validation flow. </param>
        internal Google(bool? enabled, ClientRegistration registration, LoginScopes login, AllowedAudiencesValidation validation)
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
            Validation = validation;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the app registration for the Google provider. </summary>
        public ClientRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        public LoginScopes Login { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory token validation flow. </summary>
        public AllowedAudiencesValidation Validation { get; set; }
    }
}
