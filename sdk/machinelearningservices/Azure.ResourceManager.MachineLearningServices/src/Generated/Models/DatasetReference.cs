// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The dataset reference object. </summary>
    public partial class DatasetReference
    {
        /// <summary> Initializes a new instance of DatasetReference. </summary>
        public DatasetReference()
        {
        }

        /// <summary> Initializes a new instance of DatasetReference. </summary>
        /// <param name="name"> The name of the dataset reference. </param>
        /// <param name="id"> The id of the dataset reference. </param>
        internal DatasetReference(string name, string id)
        {
            Name = name;
            Id = id;
        }

        /// <summary> The name of the dataset reference. </summary>
        public string Name { get; set; }
        /// <summary> The id of the dataset reference. </summary>
        public string Id { get; set; }
    }
}
