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
    /// When a Graph needs to show active Objectives, this defines those objectives as well as an identifier.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition :  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition" /> class.
        /// </summary>
        /// <param name="id">$NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works..</param>
        /// <param name="objectiveHash">The objective being shown on the map..</param>
        public DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition(long id = default(long), long objectiveHash = default(long))
        {
            this.Id = id;
            this.ObjectiveHash = objectiveHash;
        }
        
        /// <summary>
        /// $NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.
        /// </summary>
        /// <value>$NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// The objective being shown on the map.
        /// </summary>
        /// <value>The objective being shown on the map.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public long ObjectiveHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    this.ObjectiveHash.Equals(input.ObjectiveHash)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
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