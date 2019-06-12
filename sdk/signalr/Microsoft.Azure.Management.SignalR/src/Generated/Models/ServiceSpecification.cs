// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that describes a specification.
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        /// <param name="metricSpecifications">Specifications of the Metrics
        /// for Azure Monitoring.</param>
        public ServiceSpecification(IList<MetricSpecification> metricSpecifications = default(IList<MetricSpecification>))
        {
            MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifications of the Metrics for Azure Monitoring.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<MetricSpecification> MetricSpecifications { get; set; }

    }
}