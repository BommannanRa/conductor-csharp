
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

namespace Conductor.Client.Models
{
    /// <summary>
    /// Action
    /// </summary>
    [DataContract]
    public partial class Action : IEquatable<Action>, IValidatableObject
    {
        /// <summary>
        /// Defines _Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Startworkflow for value: start_workflow
            /// </summary>
            [EnumMember(Value = "start_workflow")]
            Startworkflow = 1,
            /// <summary>
            /// Enum Completetask for value: complete_task
            /// </summary>
            [EnumMember(Value = "complete_task")]
            Completetask = 2,
            /// <summary>
            /// Enum Failtask for value: fail_task
            /// </summary>
            [EnumMember(Value = "fail_task")]
            Failtask = 3,
            /// <summary>
            /// Enum Terminateworkflow for value: terminate_workflow
            /// </summary>
            [EnumMember(Value = "terminate_workflow")]
            Terminateworkflow = 4,
            /// <summary>
            /// Enum Updateworkflowvariables for value: update_workflow_variables
            /// </summary>
            [EnumMember(Value = "update_workflow_variables")]
            Updateworkflowvariables = 5
        }
        /// <summary>
        /// Gets or Sets _Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? _Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="completeTask">completeTask.</param>
        /// <param name="expandInlineJSON">expandInlineJSON.</param>
        /// <param name="failTask">failTask.</param>
        /// <param name="startWorkflow">startWorkflow.</param>
        /// <param name="terminateWorkflow">terminateWorkflow.</param>
        /// <param name="updateWorkflowVariables">updateWorkflowVariables.</param>
        public Action(ActionEnum? action = default(ActionEnum?), TaskDetails completeTask = default(TaskDetails), bool? expandInlineJSON = default(bool?), TaskDetails failTask = default(TaskDetails), StartWorkflow startWorkflow = default(StartWorkflow), TerminateWorkflow terminateWorkflow = default(TerminateWorkflow), UpdateWorkflowVariables updateWorkflowVariables = default(UpdateWorkflowVariables))
        {
            this._Action = action;
            this.CompleteTask = completeTask;
            this.ExpandInlineJSON = expandInlineJSON;
            this.FailTask = failTask;
            this.StartWorkflow = startWorkflow;
            this.TerminateWorkflow = terminateWorkflow;
            this.UpdateWorkflowVariables = updateWorkflowVariables;
        }


        /// <summary>
        /// Gets or Sets CompleteTask
        /// </summary>
        [DataMember(Name = "complete_task", EmitDefaultValue = false)]
        public TaskDetails CompleteTask { get; set; }

        /// <summary>
        /// Gets or Sets ExpandInlineJSON
        /// </summary>
        [DataMember(Name = "expandInlineJSON", EmitDefaultValue = false)]
        public bool? ExpandInlineJSON { get; set; }

        /// <summary>
        /// Gets or Sets FailTask
        /// </summary>
        [DataMember(Name = "fail_task", EmitDefaultValue = false)]
        public TaskDetails FailTask { get; set; }

        /// <summary>
        /// Gets or Sets StartWorkflow
        /// </summary>
        [DataMember(Name = "start_workflow", EmitDefaultValue = false)]
        public StartWorkflow StartWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets TerminateWorkflow
        /// </summary>
        [DataMember(Name = "terminate_workflow", EmitDefaultValue = false)]
        public TerminateWorkflow TerminateWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets UpdateWorkflowVariables
        /// </summary>
        [DataMember(Name = "update_workflow_variables", EmitDefaultValue = false)]
        public UpdateWorkflowVariables UpdateWorkflowVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  _Action: ").Append(_Action).Append("\n");
            sb.Append("  CompleteTask: ").Append(CompleteTask).Append("\n");
            sb.Append("  ExpandInlineJSON: ").Append(ExpandInlineJSON).Append("\n");
            sb.Append("  FailTask: ").Append(FailTask).Append("\n");
            sb.Append("  StartWorkflow: ").Append(StartWorkflow).Append("\n");
            sb.Append("  TerminateWorkflow: ").Append(TerminateWorkflow).Append("\n");
            sb.Append("  UpdateWorkflowVariables: ").Append(UpdateWorkflowVariables).Append("\n");
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
            return this.Equals(input as Action);
        }

        /// <summary>
        /// Returns true if Action instances are equal
        /// </summary>
        /// <param name="input">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action input)
        {
            if (input == null)
                return false;

            return
                (
                    this._Action == input._Action ||
                    (this._Action != null &&
                    this._Action.Equals(input._Action))
                ) &&
                (
                    this.CompleteTask == input.CompleteTask ||
                    (this.CompleteTask != null &&
                    this.CompleteTask.Equals(input.CompleteTask))
                ) &&
                (
                    this.ExpandInlineJSON == input.ExpandInlineJSON ||
                    (this.ExpandInlineJSON != null &&
                    this.ExpandInlineJSON.Equals(input.ExpandInlineJSON))
                ) &&
                (
                    this.FailTask == input.FailTask ||
                    (this.FailTask != null &&
                    this.FailTask.Equals(input.FailTask))
                ) &&
                (
                    this.StartWorkflow == input.StartWorkflow ||
                    (this.StartWorkflow != null &&
                    this.StartWorkflow.Equals(input.StartWorkflow))
                ) &&
                (
                    this.TerminateWorkflow == input.TerminateWorkflow ||
                    (this.TerminateWorkflow != null &&
                    this.TerminateWorkflow.Equals(input.TerminateWorkflow))
                ) &&
                (
                    this.UpdateWorkflowVariables == input.UpdateWorkflowVariables ||
                    (this.UpdateWorkflowVariables != null &&
                    this.UpdateWorkflowVariables.Equals(input.UpdateWorkflowVariables))
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
                if (this._Action != null)
                    hashCode = hashCode * 59 + this._Action.GetHashCode();
                if (this.CompleteTask != null)
                    hashCode = hashCode * 59 + this.CompleteTask.GetHashCode();
                if (this.ExpandInlineJSON != null)
                    hashCode = hashCode * 59 + this.ExpandInlineJSON.GetHashCode();
                if (this.FailTask != null)
                    hashCode = hashCode * 59 + this.FailTask.GetHashCode();
                if (this.StartWorkflow != null)
                    hashCode = hashCode * 59 + this.StartWorkflow.GetHashCode();
                if (this.TerminateWorkflow != null)
                    hashCode = hashCode * 59 + this.TerminateWorkflow.GetHashCode();
                if (this.UpdateWorkflowVariables != null)
                    hashCode = hashCode * 59 + this.UpdateWorkflowVariables.GetHashCode();
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
