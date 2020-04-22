/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// Defines the conditions under which stat modifications will be applied to a Character while participating in an objective.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyObjectiveStatEntryDefinition :  IEquatable<DestinyDefinitionsDestinyObjectiveStatEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyObjectiveStatEntryDefinition" /> class.
        /// </summary>
        /// <param name="stat">The stat being modified, and the value used..</param>
        /// <param name="style">Whether it will be applied as long as the objective is active, when it&#39;s completed, or until it&#39;s completed..</param>
        public DestinyDefinitionsDestinyObjectiveStatEntryDefinition(DestinyDefinitionsDestinyItemInvestmentStatDefinition stat = default(DestinyDefinitionsDestinyItemInvestmentStatDefinition), int style = default(int))
        {
            this.Stat = stat;
            this.Style = style;
        }
        
        /// <summary>
        /// The stat being modified, and the value used.
        /// </summary>
        /// <value>The stat being modified, and the value used.</value>
        [DataMember(Name="stat", EmitDefaultValue=false)]
        public DestinyDefinitionsDestinyItemInvestmentStatDefinition Stat { get; set; }

        /// <summary>
        /// Whether it will be applied as long as the objective is active, when it&#39;s completed, or until it&#39;s completed.
        /// </summary>
        /// <value>Whether it will be applied as long as the objective is active, when it&#39;s completed, or until it&#39;s completed.</value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public int Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyObjectiveStatEntryDefinition {\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyObjectiveStatEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyObjectiveStatEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyObjectiveStatEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyObjectiveStatEntryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stat == input.Stat ||
                    (this.Stat != null &&
                    this.Stat.Equals(input.Stat))
                ) && 
                (
                    this.Style == input.Style ||
                    this.Style.Equals(input.Style)
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
                if (this.Stat != null)
                    hashCode = hashCode * 59 + this.Stat.GetHashCode();
                hashCode = hashCode * 59 + this.Style.GetHashCode();
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