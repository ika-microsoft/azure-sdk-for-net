// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The List Virtual Machine operation response.
    /// </summary>
    public partial class VirtualMachineScaleSetListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetListResultInner class.
        /// </summary>
        public VirtualMachineScaleSetListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetListResultInner class.
        /// </summary>
        /// <param name="value">the list of virtual machine scale sets.</param>
        /// <param name="nextLink">the uri to fetch the next page of Virtual
        /// Machine Scale Sets. Call ListNext() with this to fetch the next
        /// page of VMSS.</param>
        public VirtualMachineScaleSetListResultInner(System.Collections.Generic.IList<VirtualMachineScaleSetInner> value = default(System.Collections.Generic.IList<VirtualMachineScaleSetInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the list of virtual machine scale sets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<VirtualMachineScaleSetInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the uri to fetch the next page of Virtual Machine
        /// Scale Sets. Call ListNext() with this to fetch the next page of
        /// VMSS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}