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
    /// OneofDescriptor
    /// </summary>
    [DataContract]
    public partial class OneofDescriptor :  IEquatable<OneofDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneofDescriptor" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="_file">_file.</param>
        /// <param name="containingType">containingType.</param>
        /// <param name="fieldCount">fieldCount.</param>
        /// <param name="fields">fields.</param>
        /// <param name="options">options.</param>
        /// <param name="name">name.</param>
        public OneofDescriptor(int? index = default(int?), string fullName = default(string), FileDescriptor _file = default(FileDescriptor), Descriptor containingType = default(Descriptor), int? fieldCount = default(int?), List<FieldDescriptor> fields = default(List<FieldDescriptor>), OneofOptions options = default(OneofOptions), string name = default(string))
        {
            this.Index = index;
            this.FullName = fullName;
            this._File = _file;
            this.ContainingType = containingType;
            this.FieldCount = fieldCount;
            this.Fields = fields;
            this.Options = options;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets _File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public FileDescriptor _File { get; set; }

        /// <summary>
        /// Gets or Sets ContainingType
        /// </summary>
        [DataMember(Name="containingType", EmitDefaultValue=false)]
        public Descriptor ContainingType { get; set; }

        /// <summary>
        /// Gets or Sets FieldCount
        /// </summary>
        [DataMember(Name="fieldCount", EmitDefaultValue=false)]
        public int? FieldCount { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldDescriptor> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public OneofOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OneofDescriptor {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  _File: ").Append(_File).Append("\n");
            sb.Append("  ContainingType: ").Append(ContainingType).Append("\n");
            sb.Append("  FieldCount: ").Append(FieldCount).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as OneofDescriptor);
        }

        /// <summary>
        /// Returns true if OneofDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of OneofDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneofDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this._File == input._File ||
                    (this._File != null &&
                    this._File.Equals(input._File))
                ) && 
                (
                    this.ContainingType == input.ContainingType ||
                    (this.ContainingType != null &&
                    this.ContainingType.Equals(input.ContainingType))
                ) && 
                (
                    this.FieldCount == input.FieldCount ||
                    (this.FieldCount != null &&
                    this.FieldCount.Equals(input.FieldCount))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this._File != null)
                    hashCode = hashCode * 59 + this._File.GetHashCode();
                if (this.ContainingType != null)
                    hashCode = hashCode * 59 + this.ContainingType.GetHashCode();
                if (this.FieldCount != null)
                    hashCode = hashCode * 59 + this.FieldCount.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
