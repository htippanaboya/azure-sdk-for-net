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

namespace Azure.Communication.CallAutomation
{
    internal partial class CallMediaRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of CallMediaRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CallMediaRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2023-10-15")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreatePlayRequest(string callConnectionId, PlayRequestInternal playRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":play", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(playRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Plays audio to participants in the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="playRequest"> play request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="playRequest"/> is null. </exception>
        public async Task<Response> PlayAsync(string callConnectionId, PlayRequestInternal playRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (playRequest == null)
            {
                throw new ArgumentNullException(nameof(playRequest));
            }

            using var message = CreatePlayRequest(callConnectionId, playRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Plays audio to participants in the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="playRequest"> play request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="playRequest"/> is null. </exception>
        public Response Play(string callConnectionId, PlayRequestInternal playRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (playRequest == null)
            {
                throw new ArgumentNullException(nameof(playRequest));
            }

            using var message = CreatePlayRequest(callConnectionId, playRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelAllMediaOperationsRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":cancelAllMediaOperations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancel all media operations in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> CancelAllMediaOperationsAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel all media operations in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response CancelAllMediaOperations(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRecognizeRequest(string callConnectionId, RecognizeRequestInternal recognizeRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":recognize", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(recognizeRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Recognize media from call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="recognizeRequest"> The media recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="recognizeRequest"/> is null. </exception>
        public async Task<Response> RecognizeAsync(string callConnectionId, RecognizeRequestInternal recognizeRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (recognizeRequest == null)
            {
                throw new ArgumentNullException(nameof(recognizeRequest));
            }

            using var message = CreateRecognizeRequest(callConnectionId, recognizeRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Recognize media from call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="recognizeRequest"> The media recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="recognizeRequest"/> is null. </exception>
        public Response Recognize(string callConnectionId, RecognizeRequestInternal recognizeRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (recognizeRequest == null)
            {
                throw new ArgumentNullException(nameof(recognizeRequest));
            }

            using var message = CreateRecognizeRequest(callConnectionId, recognizeRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStartContinuousDtmfRecognitionRequest(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":startContinuousDtmfRecognition", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(continuousDtmfRecognitionRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Start continuous Dtmf recognition by subscribing to tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="continuousDtmfRecognitionRequest"> The continuous recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="continuousDtmfRecognitionRequest"/> is null. </exception>
        public async Task<Response> StartContinuousDtmfRecognitionAsync(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (continuousDtmfRecognitionRequest == null)
            {
                throw new ArgumentNullException(nameof(continuousDtmfRecognitionRequest));
            }

            using var message = CreateStartContinuousDtmfRecognitionRequest(callConnectionId, continuousDtmfRecognitionRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Start continuous Dtmf recognition by subscribing to tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="continuousDtmfRecognitionRequest"> The continuous recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="continuousDtmfRecognitionRequest"/> is null. </exception>
        public Response StartContinuousDtmfRecognition(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (continuousDtmfRecognitionRequest == null)
            {
                throw new ArgumentNullException(nameof(continuousDtmfRecognitionRequest));
            }

            using var message = CreateStartContinuousDtmfRecognitionRequest(callConnectionId, continuousDtmfRecognitionRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopContinuousDtmfRecognitionRequest(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":stopContinuousDtmfRecognition", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(continuousDtmfRecognitionRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Stop continuous Dtmf recognition by unsubscribing to tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="continuousDtmfRecognitionRequest"> The continuous recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="continuousDtmfRecognitionRequest"/> is null. </exception>
        public async Task<Response> StopContinuousDtmfRecognitionAsync(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (continuousDtmfRecognitionRequest == null)
            {
                throw new ArgumentNullException(nameof(continuousDtmfRecognitionRequest));
            }

            using var message = CreateStopContinuousDtmfRecognitionRequest(callConnectionId, continuousDtmfRecognitionRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Stop continuous Dtmf recognition by unsubscribing to tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="continuousDtmfRecognitionRequest"> The continuous recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="continuousDtmfRecognitionRequest"/> is null. </exception>
        public Response StopContinuousDtmfRecognition(string callConnectionId, ContinuousDtmfRecognitionRequestInternal continuousDtmfRecognitionRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (continuousDtmfRecognitionRequest == null)
            {
                throw new ArgumentNullException(nameof(continuousDtmfRecognitionRequest));
            }

            using var message = CreateStopContinuousDtmfRecognitionRequest(callConnectionId, continuousDtmfRecognitionRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSendDtmfTonesRequest(string callConnectionId, SendDtmfTonesRequestInternal sendDtmfTonesRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":sendDtmfTones", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sendDtmfTonesRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Send dtmf tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="sendDtmfTonesRequest"> The send dtmf tones request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="sendDtmfTonesRequest"/> is null. </exception>
        public async Task<Response<SendDtmfTonesResultInternal>> SendDtmfTonesAsync(string callConnectionId, SendDtmfTonesRequestInternal sendDtmfTonesRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (sendDtmfTonesRequest == null)
            {
                throw new ArgumentNullException(nameof(sendDtmfTonesRequest));
            }

            using var message = CreateSendDtmfTonesRequest(callConnectionId, sendDtmfTonesRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        SendDtmfTonesResultInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SendDtmfTonesResultInternal.DeserializeSendDtmfTonesResultInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Send dtmf tones. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="sendDtmfTonesRequest"> The send dtmf tones request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="sendDtmfTonesRequest"/> is null. </exception>
        public Response<SendDtmfTonesResultInternal> SendDtmfTones(string callConnectionId, SendDtmfTonesRequestInternal sendDtmfTonesRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (sendDtmfTonesRequest == null)
            {
                throw new ArgumentNullException(nameof(sendDtmfTonesRequest));
            }

            using var message = CreateSendDtmfTonesRequest(callConnectionId, sendDtmfTonesRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        SendDtmfTonesResultInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SendDtmfTonesResultInternal.DeserializeSendDtmfTonesResultInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
