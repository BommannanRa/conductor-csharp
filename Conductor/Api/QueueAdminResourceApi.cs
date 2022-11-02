
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Client;

namespace Conductor.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IQueueAdminResourceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Queue Names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> Names ();

        /// <summary>
        /// Get Queue Names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        ApiResponse<Dictionary<string, string>> NamesWithHttpInfo ();
        /// <summary>
        /// Get the queue length
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        Dictionary<string, Dictionary<string, long?>> Size1 ();

        /// <summary>
        /// Get the queue length
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        ApiResponse<Dictionary<string, Dictionary<string, long?>>> Size1WithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Queue Names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, string>> NamesAsync ();

        /// <summary>
        /// Get Queue Names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, string>>> NamesAsyncWithHttpInfo ();
        /// <summary>
        /// Get the queue length
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Dictionary<string, long?>>> Size1Async ();

        /// <summary>
        /// Get the queue length
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Dictionary<string, long?>>>> Size1AsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class QueueAdminResourceApi : IQueueAdminResourceApi
    {
        private Conductor.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAdminResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QueueAdminResourceApi(String basePath)
        {
            this.Configuration = new Conductor.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAdminResourceApi"/> class
        /// </summary>
        /// <returns></returns>
        public QueueAdminResourceApi()
        {
            this.Configuration = Conductor.Client.Configuration.Default;

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAdminResourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QueueAdminResourceApi(Conductor.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Conductor.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Conductor.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Conductor.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Queue Names 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> Names ()
        {
             ApiResponse<Dictionary<string, string>> localVarResponse = NamesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Queue Names 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        public ApiResponse< Dictionary<string, string> > NamesWithHttpInfo ()
        {

            var localVarPath = "/api/queue/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Authorization")))
            {
                localVarHeaderParams["X-Authorization"] = this.Configuration.GetApiKeyWithPrefix("X-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Names", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, string>)));
        }

        /// <summary>
        /// Get Queue Names 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, string>> NamesAsync ()
        {
             ApiResponse<Dictionary<string, string>> localVarResponse = await NamesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Queue Names 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, string>>> NamesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/queue/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Authorization")))
            {
                localVarHeaderParams["X-Authorization"] = this.Configuration.GetApiKeyWithPrefix("X-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Names", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, string>)));
        }

        /// <summary>
        /// Get the queue length 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        public Dictionary<string, Dictionary<string, long?>> Size1 ()
        {
             ApiResponse<Dictionary<string, Dictionary<string, long?>>> localVarResponse = Size1WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the queue length 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        public ApiResponse< Dictionary<string, Dictionary<string, long?>> > Size1WithHttpInfo ()
        {

            var localVarPath = "/api/queue/size";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Authorization")))
            {
                localVarHeaderParams["X-Authorization"] = this.Configuration.GetApiKeyWithPrefix("X-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Size1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Dictionary<string, long?>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Dictionary<string, long?>>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Dictionary<string, long?>>)));
        }

        /// <summary>
        /// Get the queue length 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Dictionary<string, long?>>> Size1Async ()
        {
             ApiResponse<Dictionary<string, Dictionary<string, long?>>> localVarResponse = await Size1AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the queue length 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Dictionary<string, long?>>>> Size1AsyncWithHttpInfo ()
        {

            var localVarPath = "/api/queue/size";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Authorization")))
            {
                localVarHeaderParams["X-Authorization"] = this.Configuration.GetApiKeyWithPrefix("X-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Size1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Dictionary<string, long?>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Dictionary<string, long?>>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Dictionary<string, long?>>)));
        }

    }
}
