// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the app registration for the Twitter provider. </summary>
    public partial class TwitterRegistration
    {
        /// <summary> Initializes a new instance of TwitterRegistration. </summary>
        public TwitterRegistration()
        {
        }

        /// <summary> Initializes a new instance of TwitterRegistration. </summary>
        /// <param name="consumerKey">
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </param>
        /// <param name="consumerSecretSettingName">
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </param>
        internal TwitterRegistration(string consumerKey, string consumerSecretSettingName)
        {
            ConsumerKey = consumerKey;
            ConsumerSecretSettingName = consumerSecretSettingName;
        }

        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        public string ConsumerKey { get; set; }
        /// <summary>
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </summary>
        public string ConsumerSecretSettingName { get; set; }
    }
}
