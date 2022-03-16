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
    /// MethodOptions
    /// </summary>
    [DataContract]
    public partial class MethodOptions :  IEquatable<MethodOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines IdempotencyLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdempotencyLevelEnum
        {
            
            /// <summary>
            /// Enum IDEMPOTENCYUNKNOWN for value: IDEMPOTENCY_UNKNOWN
            /// </summary>
            [EnumMember(Value = "IDEMPOTENCY_UNKNOWN")]
            IDEMPOTENCYUNKNOWN = 1,
            
            /// <summary>
            /// Enum NOSIDEEFFECTS for value: NO_SIDE_EFFECTS
            /// </summary>
            [EnumMember(Value = "NO_SIDE_EFFECTS")]
            NOSIDEEFFECTS = 2,
            
            /// <summary>
            /// Enum IDEMPOTENT for value: IDEMPOTENT
            /// </summary>
            [EnumMember(Value = "IDEMPOTENT")]
            IDEMPOTENT = 3
        }

        /// <summary>
        /// Gets or Sets IdempotencyLevel
        /// </summary>
        [DataMember(Name="idempotencyLevel", EmitDefaultValue=false)]
        public IdempotencyLevelEnum? IdempotencyLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MethodOptions" /> class.
        /// </summary>
        /// <param name="unknownFields">unknownFields.</param>
        /// <param name="initialized">initialized (default to false).</param>
        /// <param name="parserForType">parserForType.</param>
        /// <param name="defaultInstanceForType">defaultInstanceForType.</param>
        /// <param name="serializedSize">serializedSize.</param>
        /// <param name="deprecated">deprecated (default to false).</param>
        /// <param name="uninterpretedOptionList">uninterpretedOptionList.</param>
        /// <param name="uninterpretedOptionOrBuilderList">uninterpretedOptionOrBuilderList.</param>
        /// <param name="uninterpretedOptionCount">uninterpretedOptionCount.</param>
        /// <param name="idempotencyLevel">idempotencyLevel.</param>
        /// <param name="initializationErrorString">initializationErrorString.</param>
        /// <param name="descriptorForType">descriptorForType.</param>
        /// <param name="allFields">allFields.</param>
        /// <param name="allFieldsRaw">allFieldsRaw.</param>
        public MethodOptions(UnknownFieldSet unknownFields = default(UnknownFieldSet), bool? initialized = false, ParserMethodOptions parserForType = default(ParserMethodOptions), MethodOptions defaultInstanceForType = default(MethodOptions), int? serializedSize = default(int?), bool? deprecated = false, List<UninterpretedOption> uninterpretedOptionList = default(List<UninterpretedOption>), List<UninterpretedOptionOrBuilder> uninterpretedOptionOrBuilderList = default(List<UninterpretedOptionOrBuilder>), int? uninterpretedOptionCount = default(int?), IdempotencyLevelEnum? idempotencyLevel = default(IdempotencyLevelEnum?), string initializationErrorString = default(string), Descriptor descriptorForType = default(Descriptor), Dictionary<string, Object> allFields = default(Dictionary<string, Object>), Dictionary<string, Object> allFieldsRaw = default(Dictionary<string, Object>))
        {
            this.UnknownFields = unknownFields;
            // use default value if no "initialized" provided
            if (initialized == null)
            {
                this.Initialized = false;
            }
            else
            {
                this.Initialized = initialized;
            }
            this.ParserForType = parserForType;
            this.DefaultInstanceForType = defaultInstanceForType;
            this.SerializedSize = serializedSize;
            // use default value if no "deprecated" provided
            if (deprecated == null)
            {
                this.Deprecated = false;
            }
            else
            {
                this.Deprecated = deprecated;
            }
            this.UninterpretedOptionList = uninterpretedOptionList;
            this.UninterpretedOptionOrBuilderList = uninterpretedOptionOrBuilderList;
            this.UninterpretedOptionCount = uninterpretedOptionCount;
            this.IdempotencyLevel = idempotencyLevel;
            this.InitializationErrorString = initializationErrorString;
            this.DescriptorForType = descriptorForType;
            this.AllFields = allFields;
            this.AllFieldsRaw = allFieldsRaw;
        }
        
        /// <summary>
        /// Gets or Sets UnknownFields
        /// </summary>
        [DataMember(Name="unknownFields", EmitDefaultValue=false)]
        public UnknownFieldSet UnknownFields { get; set; }

        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name="initialized", EmitDefaultValue=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// Gets or Sets ParserForType
        /// </summary>
        [DataMember(Name="parserForType", EmitDefaultValue=false)]
        public ParserMethodOptions ParserForType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultInstanceForType
        /// </summary>
        [DataMember(Name="defaultInstanceForType", EmitDefaultValue=false)]
        public MethodOptions DefaultInstanceForType { get; set; }

        /// <summary>
        /// Gets or Sets SerializedSize
        /// </summary>
        [DataMember(Name="serializedSize", EmitDefaultValue=false)]
        public int? SerializedSize { get; set; }

        /// <summary>
        /// Gets or Sets Deprecated
        /// </summary>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionList
        /// </summary>
        [DataMember(Name="uninterpretedOptionList", EmitDefaultValue=false)]
        public List<UninterpretedOption> UninterpretedOptionList { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionOrBuilderList
        /// </summary>
        [DataMember(Name="uninterpretedOptionOrBuilderList", EmitDefaultValue=false)]
        public List<UninterpretedOptionOrBuilder> UninterpretedOptionOrBuilderList { get; set; }

        /// <summary>
        /// Gets or Sets UninterpretedOptionCount
        /// </summary>
        [DataMember(Name="uninterpretedOptionCount", EmitDefaultValue=false)]
        public int? UninterpretedOptionCount { get; set; }


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
        /// Gets or Sets AllFieldsRaw
        /// </summary>
        [DataMember(Name="allFieldsRaw", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllFieldsRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MethodOptions {\n");
            sb.Append("  UnknownFields: ").Append(UnknownFields).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("  ParserForType: ").Append(ParserForType).Append("\n");
            sb.Append("  DefaultInstanceForType: ").Append(DefaultInstanceForType).Append("\n");
            sb.Append("  SerializedSize: ").Append(SerializedSize).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  UninterpretedOptionList: ").Append(UninterpretedOptionList).Append("\n");
            sb.Append("  UninterpretedOptionOrBuilderList: ").Append(UninterpretedOptionOrBuilderList).Append("\n");
            sb.Append("  UninterpretedOptionCount: ").Append(UninterpretedOptionCount).Append("\n");
            sb.Append("  IdempotencyLevel: ").Append(IdempotencyLevel).Append("\n");
            sb.Append("  InitializationErrorString: ").Append(InitializationErrorString).Append("\n");
            sb.Append("  DescriptorForType: ").Append(DescriptorForType).Append("\n");
            sb.Append("  AllFields: ").Append(AllFields).Append("\n");
            sb.Append("  AllFieldsRaw: ").Append(AllFieldsRaw).Append("\n");
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
            return this.Equals(input as MethodOptions);
        }

        /// <summary>
        /// Returns true if MethodOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MethodOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MethodOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnknownFields == input.UnknownFields ||
                    (this.UnknownFields != null &&
                    this.UnknownFields.Equals(input.UnknownFields))
                ) && 
                (
                    this.Initialized == input.Initialized ||
                    (this.Initialized != null &&
                    this.Initialized.Equals(input.Initialized))
                ) && 
                (
                    this.ParserForType == input.ParserForType ||
                    (this.ParserForType != null &&
                    this.ParserForType.Equals(input.ParserForType))
                ) && 
                (
                    this.DefaultInstanceForType == input.DefaultInstanceForType ||
                    (this.DefaultInstanceForType != null &&
                    this.DefaultInstanceForType.Equals(input.DefaultInstanceForType))
                ) && 
                (
                    this.SerializedSize == input.SerializedSize ||
                    (this.SerializedSize != null &&
                    this.SerializedSize.Equals(input.SerializedSize))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.UninterpretedOptionList == input.UninterpretedOptionList ||
                    this.UninterpretedOptionList != null &&
                    this.UninterpretedOptionList.SequenceEqual(input.UninterpretedOptionList)
                ) && 
                (
                    this.UninterpretedOptionOrBuilderList == input.UninterpretedOptionOrBuilderList ||
                    this.UninterpretedOptionOrBuilderList != null &&
                    this.UninterpretedOptionOrBuilderList.SequenceEqual(input.UninterpretedOptionOrBuilderList)
                ) && 
                (
                    this.UninterpretedOptionCount == input.UninterpretedOptionCount ||
                    (this.UninterpretedOptionCount != null &&
                    this.UninterpretedOptionCount.Equals(input.UninterpretedOptionCount))
                ) && 
                (
                    this.IdempotencyLevel == input.IdempotencyLevel ||
                    (this.IdempotencyLevel != null &&
                    this.IdempotencyLevel.Equals(input.IdempotencyLevel))
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
                    this.AllFieldsRaw == input.AllFieldsRaw ||
                    this.AllFieldsRaw != null &&
                    this.AllFieldsRaw.SequenceEqual(input.AllFieldsRaw)
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
                if (this.UnknownFields != null)
                    hashCode = hashCode * 59 + this.UnknownFields.GetHashCode();
                if (this.Initialized != null)
                    hashCode = hashCode * 59 + this.Initialized.GetHashCode();
                if (this.ParserForType != null)
                    hashCode = hashCode * 59 + this.ParserForType.GetHashCode();
                if (this.DefaultInstanceForType != null)
                    hashCode = hashCode * 59 + this.DefaultInstanceForType.GetHashCode();
                if (this.SerializedSize != null)
                    hashCode = hashCode * 59 + this.SerializedSize.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.UninterpretedOptionList != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionList.GetHashCode();
                if (this.UninterpretedOptionOrBuilderList != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionOrBuilderList.GetHashCode();
                if (this.UninterpretedOptionCount != null)
                    hashCode = hashCode * 59 + this.UninterpretedOptionCount.GetHashCode();
                if (this.IdempotencyLevel != null)
                    hashCode = hashCode * 59 + this.IdempotencyLevel.GetHashCode();
                if (this.InitializationErrorString != null)
                    hashCode = hashCode * 59 + this.InitializationErrorString.GetHashCode();
                if (this.DescriptorForType != null)
                    hashCode = hashCode * 59 + this.DescriptorForType.GetHashCode();
                if (this.AllFields != null)
                    hashCode = hashCode * 59 + this.AllFields.GetHashCode();
                if (this.AllFieldsRaw != null)
                    hashCode = hashCode * 59 + this.AllFieldsRaw.GetHashCode();
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
