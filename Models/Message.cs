/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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

namespace Conductor.Client.Models
{
    /// <summary>
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message :  IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="parserForType">parserForType.</param>
        /// <param name="serializedSize">serializedSize.</param>
        /// <param name="initialized">initialized (default to false).</param>
        /// <param name="defaultInstanceForType">defaultInstanceForType.</param>
        /// <param name="initializationErrorString">initializationErrorString.</param>
        /// <param name="descriptorForType">descriptorForType.</param>
        /// <param name="allFields">allFields.</param>
        /// <param name="unknownFields">unknownFields.</param>
        public Message(ParserMessage parserForType = default(ParserMessage), int? serializedSize = default(int?), bool? initialized = false, MessageLite defaultInstanceForType = default(MessageLite), string initializationErrorString = default(string), Descriptor descriptorForType = default(Descriptor), Dictionary<string, Object> allFields = default(Dictionary<string, Object>), UnknownFieldSet unknownFields = default(UnknownFieldSet))
        {
            this.ParserForType = parserForType;
            this.SerializedSize = serializedSize;
            // use default value if no "initialized" provided
            if (initialized == null)
            {
                this.Initialized = false;
            }
            else
            {
                this.Initialized = initialized;
            }
            this.DefaultInstanceForType = defaultInstanceForType;
            this.InitializationErrorString = initializationErrorString;
            this.DescriptorForType = descriptorForType;
            this.AllFields = allFields;
            this.UnknownFields = unknownFields;
        }
        
        /// <summary>
        /// Gets or Sets ParserForType
        /// </summary>
        [DataMember(Name="parserForType", EmitDefaultValue=false)]
        public ParserMessage ParserForType { get; set; }

        /// <summary>
        /// Gets or Sets SerializedSize
        /// </summary>
        [DataMember(Name="serializedSize", EmitDefaultValue=false)]
        public int? SerializedSize { get; set; }

        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name="initialized", EmitDefaultValue=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// Gets or Sets DefaultInstanceForType
        /// </summary>
        [DataMember(Name="defaultInstanceForType", EmitDefaultValue=false)]
        public MessageLite DefaultInstanceForType { get; set; }

        /// <summary>
        /// Gets or Sets InitializationErrorString
        /// </summary>
        [DataMember(Name="initializationErrorString", EmitDefaultValue=false)]
        public string InitializationErrorString { get; set; }

        /// <summary>
        /// Gets or Sets DescriptorForType
        /// </summary>
        [DataMember(Name="descriptorForType", EmitDefaultValue=false)]
        public Descriptor DescriptorForType { get; set; }

        /// <summary>
        /// Gets or Sets AllFields
        /// </summary>
        [DataMember(Name="allFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllFields { get; set; }

        /// <summary>
        /// Gets or Sets UnknownFields
        /// </summary>
        [DataMember(Name="unknownFields", EmitDefaultValue=false)]
        public UnknownFieldSet UnknownFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  ParserForType: ").Append(ParserForType).Append("\n");
            sb.Append("  SerializedSize: ").Append(SerializedSize).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("  DefaultInstanceForType: ").Append(DefaultInstanceForType).Append("\n");
            sb.Append("  InitializationErrorString: ").Append(InitializationErrorString).Append("\n");
            sb.Append("  DescriptorForType: ").Append(DescriptorForType).Append("\n");
            sb.Append("  AllFields: ").Append(AllFields).Append("\n");
            sb.Append("  UnknownFields: ").Append(UnknownFields).Append("\n");
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
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParserForType == input.ParserForType ||
                    (this.ParserForType != null &&
                    this.ParserForType.Equals(input.ParserForType))
                ) && 
                (
                    this.SerializedSize == input.SerializedSize ||
                    (this.SerializedSize != null &&
                    this.SerializedSize.Equals(input.SerializedSize))
                ) && 
                (
                    this.Initialized == input.Initialized ||
                    (this.Initialized != null &&
                    this.Initialized.Equals(input.Initialized))
                ) && 
                (
                    this.DefaultInstanceForType == input.DefaultInstanceForType ||
                    (this.DefaultInstanceForType != null &&
                    this.DefaultInstanceForType.Equals(input.DefaultInstanceForType))
                ) && 
                (
                    this.InitializationErrorString == input.InitializationErrorString ||
                    (this.InitializationErrorString != null &&
                    this.InitializationErrorString.Equals(input.InitializationErrorString))
                ) && 
                (
                    this.DescriptorForType == input.DescriptorForType ||
                    (this.DescriptorForType != null &&
                    this.DescriptorForType.Equals(input.DescriptorForType))
                ) && 
                (
                    this.AllFields == input.AllFields ||
                    this.AllFields != null &&
                    this.AllFields.SequenceEqual(input.AllFields)
                ) && 
                (
                    this.UnknownFields == input.UnknownFields ||
                    (this.UnknownFields != null &&
                    this.UnknownFields.Equals(input.UnknownFields))
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
                if (this.ParserForType != null)
                    hashCode = hashCode * 59 + this.ParserForType.GetHashCode();
                if (this.SerializedSize != null)
                    hashCode = hashCode * 59 + this.SerializedSize.GetHashCode();
                if (this.Initialized != null)
                    hashCode = hashCode * 59 + this.Initialized.GetHashCode();
                if (this.DefaultInstanceForType != null)
                    hashCode = hashCode * 59 + this.DefaultInstanceForType.GetHashCode();
                if (this.InitializationErrorString != null)
                    hashCode = hashCode * 59 + this.InitializationErrorString.GetHashCode();
                if (this.DescriptorForType != null)
                    hashCode = hashCode * 59 + this.DescriptorForType.GetHashCode();
                if (this.AllFields != null)
                    hashCode = hashCode * 59 + this.AllFields.GetHashCode();
                if (this.UnknownFields != null)
                    hashCode = hashCode * 59 + this.UnknownFields.GetHashCode();
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
