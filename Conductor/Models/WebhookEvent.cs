
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Conductor.Client.SwaggerDateConverter;

namespace Conductor.Models
{
    /// <summary>
    /// WebhookEvent
    /// </summary>
    [DataContract]
        public partial class WebhookEvent :  IEquatable<WebhookEvent>, IValidatableObject
    {
        /// <summary>
        /// Defines Verifier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VerifierEnum
        {
            /// <summary>
            /// Enum SLACKBASED for value: SLACK_BASED
            /// </summary>
            [EnumMember(Value = "SLACK_BASED")]
            SLACKBASED = 1,
            /// <summary>
            /// Enum SIGNATUREBASED for value: SIGNATURE_BASED
            /// </summary>
            [EnumMember(Value = "SIGNATURE_BASED")]
            SIGNATUREBASED = 2,
            /// <summary>
            /// Enum HEADERBASED for value: HEADER_BASED
            /// </summary>
            [EnumMember(Value = "HEADER_BASED")]
            HEADERBASED = 3,
            /// <summary>
            /// Enum TWITTER for value: TWITTER
            /// </summary>
            [EnumMember(Value = "TWITTER")]
            TWITTER = 4        }
        /// <summary>
        /// Gets or Sets Verifier
        /// </summary>
        [DataMember(Name="verifier", EmitDefaultValue=false)]
        public VerifierEnum? Verifier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent" /> class.
        /// </summary>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="headerKey">headerKey.</param>
        /// <param name="headers">headers.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="receiverWorkflowNamesToVersions">receiverWorkflowNamesToVersions.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="secretValue">secretValue.</param>
        /// <param name="sourcePlatform">sourcePlatform.</param>
        /// <param name="urlVerified">urlVerified.</param>
        /// <param name="verifier">verifier.</param>
        /// <param name="webhookExecutionHistory">webhookExecutionHistory.</param>
        /// <param name="workflowsToStart">workflowsToStart.</param>
        public WebhookEvent(string createdBy = default(string), string headerKey = default(string), Dictionary<string, string> headers = default(Dictionary<string, string>), string id = default(string), string name = default(string), Dictionary<string, int?> receiverWorkflowNamesToVersions = default(Dictionary<string, int?>), string secretKey = default(string), string secretValue = default(string), string sourcePlatform = default(string), bool? urlVerified = default(bool?), VerifierEnum? verifier = default(VerifierEnum?), List<WebhookExecutionHistory> webhookExecutionHistory = default(List<WebhookExecutionHistory>), Dictionary<string, int?> workflowsToStart = default(Dictionary<string, int?>))
        {
            this.CreatedBy = createdBy;
            this.HeaderKey = headerKey;
            this.Headers = headers;
            this.Id = id;
            this.Name = name;
            this.ReceiverWorkflowNamesToVersions = receiverWorkflowNamesToVersions;
            this.SecretKey = secretKey;
            this.SecretValue = secretValue;
            this.SourcePlatform = sourcePlatform;
            this.UrlVerified = urlVerified;
            this.Verifier = verifier;
            this.WebhookExecutionHistory = webhookExecutionHistory;
            this.WorkflowsToStart = workflowsToStart;
        }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets HeaderKey
        /// </summary>
        [DataMember(Name="headerKey", EmitDefaultValue=false)]
        public string HeaderKey { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverWorkflowNamesToVersions
        /// </summary>
        [DataMember(Name="receiverWorkflowNamesToVersions", EmitDefaultValue=false)]
        public Dictionary<string, int?> ReceiverWorkflowNamesToVersions { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name="secretKey", EmitDefaultValue=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets SecretValue
        /// </summary>
        [DataMember(Name="secretValue", EmitDefaultValue=false)]
        public string SecretValue { get; set; }

        /// <summary>
        /// Gets or Sets SourcePlatform
        /// </summary>
        [DataMember(Name="sourcePlatform", EmitDefaultValue=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// Gets or Sets UrlVerified
        /// </summary>
        [DataMember(Name="urlVerified", EmitDefaultValue=false)]
        public bool? UrlVerified { get; set; }


        /// <summary>
        /// Gets or Sets WebhookExecutionHistory
        /// </summary>
        [DataMember(Name="webhookExecutionHistory", EmitDefaultValue=false)]
        public List<WebhookExecutionHistory> WebhookExecutionHistory { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowsToStart
        /// </summary>
        [DataMember(Name="workflowsToStart", EmitDefaultValue=false)]
        public Dictionary<string, int?> WorkflowsToStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEvent {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  HeaderKey: ").Append(HeaderKey).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReceiverWorkflowNamesToVersions: ").Append(ReceiverWorkflowNamesToVersions).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  SecretValue: ").Append(SecretValue).Append("\n");
            sb.Append("  SourcePlatform: ").Append(SourcePlatform).Append("\n");
            sb.Append("  UrlVerified: ").Append(UrlVerified).Append("\n");
            sb.Append("  Verifier: ").Append(Verifier).Append("\n");
            sb.Append("  WebhookExecutionHistory: ").Append(WebhookExecutionHistory).Append("\n");
            sb.Append("  WorkflowsToStart: ").Append(WorkflowsToStart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookEvent);
        }

        /// <summary>
        /// Returns true if WebhookEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.HeaderKey == input.HeaderKey ||
                    (this.HeaderKey != null &&
                    this.HeaderKey.Equals(input.HeaderKey))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReceiverWorkflowNamesToVersions == input.ReceiverWorkflowNamesToVersions ||
                    this.ReceiverWorkflowNamesToVersions != null &&
                    input.ReceiverWorkflowNamesToVersions != null &&
                    this.ReceiverWorkflowNamesToVersions.SequenceEqual(input.ReceiverWorkflowNamesToVersions)
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
                ) && 
                (
                    this.SecretValue == input.SecretValue ||
                    (this.SecretValue != null &&
                    this.SecretValue.Equals(input.SecretValue))
                ) && 
                (
                    this.SourcePlatform == input.SourcePlatform ||
                    (this.SourcePlatform != null &&
                    this.SourcePlatform.Equals(input.SourcePlatform))
                ) && 
                (
                    this.UrlVerified == input.UrlVerified ||
                    (this.UrlVerified != null &&
                    this.UrlVerified.Equals(input.UrlVerified))
                ) && 
                (
                    this.Verifier == input.Verifier ||
                    (this.Verifier != null &&
                    this.Verifier.Equals(input.Verifier))
                ) && 
                (
                    this.WebhookExecutionHistory == input.WebhookExecutionHistory ||
                    this.WebhookExecutionHistory != null &&
                    input.WebhookExecutionHistory != null &&
                    this.WebhookExecutionHistory.SequenceEqual(input.WebhookExecutionHistory)
                ) && 
                (
                    this.WorkflowsToStart == input.WorkflowsToStart ||
                    this.WorkflowsToStart != null &&
                    input.WorkflowsToStart != null &&
                    this.WorkflowsToStart.SequenceEqual(input.WorkflowsToStart)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.HeaderKey != null)
                    hashCode = hashCode * 59 + this.HeaderKey.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReceiverWorkflowNamesToVersions != null)
                    hashCode = hashCode * 59 + this.ReceiverWorkflowNamesToVersions.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.SecretValue != null)
                    hashCode = hashCode * 59 + this.SecretValue.GetHashCode();
                if (this.SourcePlatform != null)
                    hashCode = hashCode * 59 + this.SourcePlatform.GetHashCode();
                if (this.UrlVerified != null)
                    hashCode = hashCode * 59 + this.UrlVerified.GetHashCode();
                if (this.Verifier != null)
                    hashCode = hashCode * 59 + this.Verifier.GetHashCode();
                if (this.WebhookExecutionHistory != null)
                    hashCode = hashCode * 59 + this.WebhookExecutionHistory.GetHashCode();
                if (this.WorkflowsToStart != null)
                    hashCode = hashCode * 59 + this.WorkflowsToStart.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
