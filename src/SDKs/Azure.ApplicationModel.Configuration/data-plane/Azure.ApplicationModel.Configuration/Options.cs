﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using Azure.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Azure.ApplicationModel.Configuration
{
    [Flags]
    public enum SettingFields : uint
    {
        None = 0x0000,
        Key = 0x0001,
        Label = 0x0002,
        Value = 0x0004,
        ContentType = 0x0008,
        ETag = 0x0010,
        LastModified = 0x0020,
        Locked = 0x0040,
        Tags = 0x0080,

        All = uint.MaxValue
    }

    public class SettingSelector
    {
        public static readonly string Any = "*";
        /// <summary>
        /// Keys that will be used to filter.
        /// </summary>
        /// <remarks>See the documentation for this client library for details on the format of filter expressions</remarks>
        public IList<string> Keys { get; set; }
        /// <summary>
        /// Labels that will be used to filter.
        /// </summary>
        /// <remarks>See the documentation for this client library for details on the format of filter expressions</remarks>
        public IList<string> Labels { get; set; }
        /// <summary>
        /// IKeyValue fields that will be retrieved.
        /// </summary>
        public SettingFields Fields { get; set; } = SettingFields.All;
        /// <summary>
        /// If set, then key values will be retrieved exactly as they existed at the provided time.
        /// </summary>
        public DateTimeOffset? AsOf { get; set; }

        public SettingSelector() : this(Any, Any) { }

        public SettingSelector(string key, string label = default)
        {
            Keys = new List<string> { key };
            Labels = new List<string>();
            if (label != null) Labels.Add(label);
        }

        internal string BatchLink { get; set; }

        internal SettingSelector CloneWithBatchLink(string batchLink)
        {
            return new SettingSelector()
            {
                Keys = new List<string>(Keys),
                Labels = new List<string>(Labels),
                Fields = Fields,
                AsOf = AsOf,
                BatchLink = batchLink
            };
        }

        #region nobody wants to see these
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(SettingSelector other)
        {
            if (other == null) return false;
            if( Keys.Except(other.Keys).ToList().Count != 0) return false;
            if (Keys.Except(other.Keys).ToList().Count != 0) return false;
            if (!Fields.Equals(other.Fields)) return false;
            if (AsOf != other.AsOf) return false;
            if (!string.Equals(BatchLink, other.BatchLink, StringComparison.Ordinal)) return false;

            return true;
        }
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is SettingSelector other)
            {
                return Equals(other);
            }
            else return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        // TODO ()
        public override string ToString() => base.ToString();
        #endregion
    }
}
