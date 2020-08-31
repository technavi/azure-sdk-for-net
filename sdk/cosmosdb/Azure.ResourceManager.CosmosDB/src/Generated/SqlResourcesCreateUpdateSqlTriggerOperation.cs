// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> Create or update an Azure Cosmos DB SQL trigger. </summary>
    public partial class SqlResourcesCreateUpdateSqlTriggerOperation : Operation<SqlTriggerGetResults>, IOperationSource<SqlTriggerGetResults>
    {
        private readonly ArmOperationHelpers<SqlTriggerGetResults> _operation;
        internal SqlResourcesCreateUpdateSqlTriggerOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<SqlTriggerGetResults>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlResourcesCreateUpdateSqlTriggerOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SqlTriggerGetResults Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlTriggerGetResults>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlTriggerGetResults>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SqlTriggerGetResults IOperationSource<SqlTriggerGetResults>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SqlTriggerGetResults.DeserializeSqlTriggerGetResults(document.RootElement);
        }

        async ValueTask<SqlTriggerGetResults> IOperationSource<SqlTriggerGetResults>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SqlTriggerGetResults.DeserializeSqlTriggerGetResults(document.RootElement);
        }
    }
}