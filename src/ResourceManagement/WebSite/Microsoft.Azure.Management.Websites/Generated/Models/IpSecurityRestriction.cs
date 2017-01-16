// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents an ip security restriction on a web app.
    /// </summary>
    public partial class IpSecurityRestriction
    {
        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        public IpSecurityRestriction() { }

        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        public IpSecurityRestriction(string ipAddress, string subnetMask = default(string))
        {
            IpAddress = ipAddress;
            SubnetMask = subnetMask;
        }

        /// <summary>
        /// IP address the security restriction is valid for
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Subnet mask for the range of IP addresses the restriction is valid
        /// for
        /// </summary>
        [JsonProperty(PropertyName = "subnetMask")]
        public string SubnetMask { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (IpAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpAddress");
            }
        }
    }
}