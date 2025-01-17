// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownLexicalTokenizer. </summary>
    internal partial class UnknownLexicalTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of <see cref="UnknownLexicalTokenizer"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal UnknownLexicalTokenizer(string oDataType, string name) : base(oDataType, name)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
