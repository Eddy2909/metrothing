using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using SyncthingRestClient.Response;

namespace SyncthingRestClient
{
    public class RestClient
    {
        private readonly List<HttpStatusCode> _acceptableHttpStatusCodes = new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
            HttpStatusCode.Created,
            HttpStatusCode.Accepted,
            HttpStatusCode.NonAuthoritativeInformation,
            HttpStatusCode.NoContent,
            HttpStatusCode.ResetContent,
            HttpStatusCode.PartialContent
        };

        private readonly RestSharp.RestClient _restClient;

        public RestClient(string host, UInt16 port, bool useHttps, string apiKey)
        {
            // Disable warnings about untrusted SSL certificates
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            Host = host;
            Port = port;
            UseHttps = useHttps;
            ApiKey = apiKey;

            _restClient = GetRestClient();
        }

        public string Host { get; private set; }
        public UInt16 Port { get; private set; }
        public bool UseHttps { get; private set; }
        public string ApiKey { get; private set; }

        public Uri Uri
        {
            get
            {
                var builder = new UriBuilder(UseHttps ? "https" : "http", Host, Port);
                return builder.Uri;
            }
        }

        private IRestRequest GetBaseRequest(string resource, Method method = Method.GET)
        {
            var request = new RestRequest(@"rest/" + resource, method);
            request.AddHeader("X-API-Key", ApiKey);

            return request;
        }

        private RestSharp.RestClient GetRestClient()
        {
            var uriBuilder = new UriBuilder(UseHttps ? "https" : "http", Host, Port);
            return new RestSharp.RestClient(uriBuilder.ToString());
        }

        private void HandleRestErrors(IRestResponse response)
        {
            if (response.ResponseStatus == ResponseStatus.Completed &&
                _acceptableHttpStatusCodes.Contains(response.StatusCode))
                return;

            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                throw new SyncthingRestProxyRequestException(
                    String.Format("HTTP error, not allowed status code {0} ({1}) on {2}",
                        response.StatusCode,
                        response.StatusDescription,
                        response.ResponseUri));
            }

            throw new SyncthingRestProxyRequestException(
                String.Format("Transport error: {0} ({1}) on {2}",
                    response.StatusCode,
                    response.StatusDescription,
                    response.ResponseUri));
        }

        #region GET based requests

        public GetPingResponse GetPing()
        {
            var request = GetBaseRequest("ping");
            var response = _restClient.Execute<GetPingResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetPingResponse> GetPingAsync(CancellationToken token)
        {
            var request = GetBaseRequest("ping");
            var response = await _restClient.ExecuteGetTaskAsync<GetPingResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetVersionResponse GetVersion()
        {
            var request = GetBaseRequest("version");
            var response = _restClient.Execute<GetVersionResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetVersionResponse> GetVersionAsync(CancellationToken token)
        {
            var request = GetBaseRequest("version");
            var response = await _restClient.ExecuteGetTaskAsync<GetVersionResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetSystemResponse GetSystemStatus()
        {
            var request = GetBaseRequest("system");
            var response = _restClient.Execute<GetSystemResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetSystemResponse> GetSystemStatusAsync(CancellationToken token)
        {
            var request = GetBaseRequest("system");
            var response = await _restClient.ExecuteGetTaskAsync<GetSystemResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetUpgradeResponse GetUpgradeStatus()
        {
            var request = GetBaseRequest("upgrade");
            var response = _restClient.Execute<GetUpgradeResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetUpgradeResponse> GetUpgradeStatusAsync(CancellationToken token)
        {
            var request = GetBaseRequest("upgrade");
            var response = await _restClient.ExecuteGetTaskAsync<GetUpgradeResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetReportResponse GetReport()
        {
            var request = GetBaseRequest("report");
            var response = _restClient.Execute<GetReportResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetReportResponse> GetReportAsync(CancellationToken token)
        {
            var request = GetBaseRequest("report");
            var response = await _restClient.ExecuteGetTaskAsync<GetReportResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetConnetionResponse GetConnetions()
        {
            var customRestClient = GetRestClient();

            var request = GetBaseRequest("connections");
            var response = customRestClient.Execute(request);

            HandleRestErrors(response);

            var result = new GetConnetionResponse();
            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };

            var desResult =
                JsonConvert.DeserializeObject<Dictionary<string, GetConnetionResponse.TotalDetails>>(response.Content,
                    jsonSettings);

            result.Total = desResult.Single(x => x.Key == "total").Value;
            result.AvailableConnections = desResult.Count - 1;

            return result;
        }

        public async Task<GetConnetionResponse> GetConnectionsAsync(CancellationToken token)
        {
            var request = GetBaseRequest("connections");
            var response = await _restClient.ExecuteTaskAsync(request, token);

            HandleRestErrors(response);

            var result = new GetConnetionResponse();
            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };

            var desResult =
                JsonConvert.DeserializeObject<Dictionary<string, GetConnetionResponse.TotalDetails>>(response.Content,
                    jsonSettings);

            result.Total = desResult.Single(x => x.Key == "total").Value;
            result.AvailableConnections = desResult.Count;

            return result;
        }

        public GetConfigResponse GetConfig()
        {
            var request = GetBaseRequest("config");
            var response = _restClient.Execute<GetConfigResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetConfigResponse> GetConfigAsync(CancellationToken token)
        {
            var request = GetBaseRequest("config");
            var response = await _restClient.ExecuteGetTaskAsync<GetConfigResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetFolderStatsResponse GetFolderStats()
        {
            var request = GetBaseRequest("stats/folder");
            var response = _restClient.Execute<Dictionary<string, GetFolderStatsResponseMainNode>>(request);

            HandleRestErrors(response);

            return new GetFolderStatsResponse {Folders = response.Data};
        }

        public async Task<GetFolderStatsResponse> GetFolderStatsAsync(CancellationToken token)
        {
            var request = GetBaseRequest("stats/folder");
            var response =
                await
                    _restClient.ExecuteGetTaskAsync<Dictionary<string, GetFolderStatsResponseMainNode>>(request, token);

            HandleRestErrors(response);

            return new GetFolderStatsResponse {Folders = response.Data};
        }

        public GetFolderModelResponse GetFolderModel(string folderId)
        {
            var request = GetBaseRequest("model");
            request.AddQueryParameter("folder", folderId);
            var response = _restClient.Execute<GetFolderModelResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetFolderModelResponse> GetFolderModelAsync(string folderId, CancellationToken token)
        {
            var request = GetBaseRequest("model");
            request.AddQueryParameter("folder", folderId);
            var response = await _restClient.ExecuteGetTaskAsync<GetFolderModelResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public GetNeedResponse GetNeed(string folderId)
        {
            var request = GetBaseRequest("need");
            request.AddQueryParameter("folder", folderId);
            var response = _restClient.Execute<GetNeedResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<GetNeedResponse> GetNeedAsync(string folderId, CancellationToken token)
        {
            var request = GetBaseRequest("need");
            request.AddQueryParameter("folder", folderId);
            var response = await _restClient.ExecuteGetTaskAsync<GetNeedResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public bool VerifyDeviceIdentifier(string deviceId)
        {
            try
            {
                FormatDeviceIdentifier(deviceId);
                return true;
            }
            catch (SyncthingRestProxyRequestException)
            {
                return false;
            }
        }

        public string FormatDeviceIdentifier(string deviceId)
        {
            var request = GetBaseRequest("deviceid");
            request.AddQueryParameter("id", deviceId);

            var response = _restClient.Execute<GetDeviceIdResponse>(request);

            HandleRestErrors(response);

            if (!string.IsNullOrWhiteSpace(response.Data.Error))
            {
                throw new SyncthingRestProxyRequestException(response.Data.Error);
            }

            return response.Data.Identifier;
        }

        #endregion

        #region POST based requests

        public PostPingResponse PostPing()
        {
            var request = GetBaseRequest("ping", Method.POST);
            var response = _restClient.Execute<PostPingResponse>(request);

            HandleRestErrors(response);

            return response.Data;
        }

        public async Task<PostPingResponse> PostPingAsync(CancellationToken token)
        {
            var request = GetBaseRequest("ping");
            var response = await _restClient.ExecutePostTaskAsync<PostPingResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        public PostRestartResponse Restart()
        {
            var request = GetBaseRequest("restart", Method.POST);
            var response = _restClient.Execute(request);

            HandleRestErrors(response);

            return new PostRestartResponse();
        }

        public async Task<PostRestartResponse> RestartAsync(CancellationToken token)
        {
            var request = GetBaseRequest("restart");
            var response = await _restClient.ExecutePostTaskAsync(request, token);

            HandleRestErrors(response);

            return new PostRestartResponse();
        }

        public PostShutdownResponse Shutdown()
        {
            var request = GetBaseRequest("shutdown", Method.POST);
            var response = _restClient.Execute(request);

            HandleRestErrors(response);

            return new PostShutdownResponse();
        }

        public PostUpgradeResponse Upgrade()
        {
            var request = GetBaseRequest("upgrade", Method.POST);
            var response = _restClient.Execute(request);

            HandleRestErrors(response);

            return new PostUpgradeResponse();
        }

        public async Task<PostUpgradeResponse> UpgradeAsync(CancellationToken token)
        {
            var request = GetBaseRequest("upgrade");
            var response = await _restClient.ExecutePostTaskAsync(request, token);

            HandleRestErrors(response);

            return new PostUpgradeResponse();
        }

        public PostRescanResponse PostRescan(string folderId)
        {
            var request = GetBaseRequest("scan", Method.POST);
            request.AddQueryParameter("folder", folderId);
            var response = _restClient.Execute(request);

            HandleRestErrors(response);

            return new PostRescanResponse();
        }

        public async Task<PostRescanResponse> PostRescanAsync(string folderId, CancellationToken token)
        {
            var request = GetBaseRequest("scan");
            request.AddQueryParameter("folder", folderId);
            var response = await _restClient.ExecutePostTaskAsync(request, token);

            HandleRestErrors(response);

            return new PostRescanResponse();
        }

        public PostBumpResponse PostBump(string folderId, string fileId)
        {
            var request = GetBaseRequest("bump", Method.POST);
            request.AddQueryParameter("folder", folderId);
            request.AddQueryParameter("file", fileId);
            var response = _restClient.Execute<PostBumpResponse>(request);

            HandleRestErrors(response);

            return new PostBumpResponse();
        }

        public async Task<PostBumpResponse> PostBumpAsync(string folderId, string fileId, CancellationToken token)
        {
            var request = GetBaseRequest("need");
            request.AddQueryParameter("folder", folderId);
            request.AddQueryParameter("file", fileId);
            var response = await _restClient.ExecuteGetTaskAsync<PostBumpResponse>(request, token);

            HandleRestErrors(response);

            return response.Data;
        }

        #endregion
    }

    public class SyncthingRestProxyRequestException : Exception
    {
        public SyncthingRestProxyRequestException(string message) : base(message)
        {
        }

        public SyncthingRestProxyRequestException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}