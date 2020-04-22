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
    /// Defines a canonical \&quot;Season\&quot; of Destiny: a range of a few months where the game highlights certain challenges, provides new loot, has new Clan-related rewards and celebrates various seasonal events.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsSeasonsDestinySeasonDefinition :  IEquatable<DestinyDefinitionsSeasonsDestinySeasonDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSeasonsDestinySeasonDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="backgroundImagePath">backgroundImagePath.</param>
        /// <param name="seasonNumber">seasonNumber.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="seasonPassHash">seasonPassHash.</param>
        /// <param name="seasonPassProgressionHash">seasonPassProgressionHash.</param>
        /// <param name="artifactItemHash">artifactItemHash.</param>
        /// <param name="sealPresentationNodeHash">sealPresentationNodeHash.</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsSeasonsDestinySeasonDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string backgroundImagePath = default(string), int seasonNumber = default(int), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), long seasonPassHash = default(long), long seasonPassProgressionHash = default(long), long artifactItemHash = default(long), long sealPresentationNodeHash = default(long), long hash = default(long), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.BackgroundImagePath = backgroundImagePath;
            this.SeasonNumber = seasonNumber;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SeasonPassHash = seasonPassHash;
            this.SeasonPassProgressionHash = seasonPassProgressionHash;
            this.ArtifactItemHash = artifactItemHash;
            this.SealPresentationNodeHash = sealPresentationNodeHash;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }
        
        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImagePath
        /// </summary>
        [DataMember(Name="backgroundImagePath", EmitDefaultValue=false)]
        public string BackgroundImagePath { get; set; }

        /// <summary>
        /// Gets or Sets SeasonNumber
        /// </summary>
        [DataMember(Name="seasonNumber", EmitDefaultValue=false)]
        public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets SeasonPassHash
        /// </summary>
        [DataMember(Name="seasonPassHash", EmitDefaultValue=false)]
        public long SeasonPassHash { get; set; }

        /// <summary>
        /// Gets or Sets SeasonPassProgressionHash
        /// </summary>
        [DataMember(Name="seasonPassProgressionHash", EmitDefaultValue=false)]
        public long SeasonPassProgressionHash { get; set; }

        /// <summary>
        /// Gets or Sets ArtifactItemHash
        /// </summary>
        [DataMember(Name="artifactItemHash", EmitDefaultValue=false)]
        public long ArtifactItemHash { get; set; }

        /// <summary>
        /// Gets or Sets SealPresentationNodeHash
        /// </summary>
        [DataMember(Name="sealPresentationNodeHash", EmitDefaultValue=false)]
        public long SealPresentationNodeHash { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public long Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsSeasonsDestinySeasonDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  BackgroundImagePath: ").Append(BackgroundImagePath).Append("\n");
            sb.Append("  SeasonNumber: ").Append(SeasonNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SeasonPassHash: ").Append(SeasonPassHash).Append("\n");
            sb.Append("  SeasonPassProgressionHash: ").Append(SeasonPassProgressionHash).Append("\n");
            sb.Append("  ArtifactItemHash: ").Append(ArtifactItemHash).Append("\n");
            sb.Append("  SealPresentationNodeHash: ").Append(SealPresentationNodeHash).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSeasonsDestinySeasonDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSeasonsDestinySeasonDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSeasonsDestinySeasonDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSeasonsDestinySeasonDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.BackgroundImagePath == input.BackgroundImagePath ||
                    (this.BackgroundImagePath != null &&
                    this.BackgroundImagePath.Equals(input.BackgroundImagePath))
                ) && 
                (
                    this.SeasonNumber == input.SeasonNumber ||
                    this.SeasonNumber.Equals(input.SeasonNumber)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.SeasonPassHash == input.SeasonPassHash ||
                    this.SeasonPassHash.Equals(input.SeasonPassHash)
                ) && 
                (
                    this.SeasonPassProgressionHash == input.SeasonPassProgressionHash ||
                    this.SeasonPassProgressionHash.Equals(input.SeasonPassProgressionHash)
                ) && 
                (
                    this.ArtifactItemHash == input.ArtifactItemHash ||
                    this.ArtifactItemHash.Equals(input.ArtifactItemHash)
                ) && 
                (
                    this.SealPresentationNodeHash == input.SealPresentationNodeHash ||
                    this.SealPresentationNodeHash.Equals(input.SealPresentationNodeHash)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.BackgroundImagePath != null)
                    hashCode = hashCode * 59 + this.BackgroundImagePath.GetHashCode();
                hashCode = hashCode * 59 + this.SeasonNumber.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.SeasonPassHash.GetHashCode();
                hashCode = hashCode * 59 + this.SeasonPassProgressionHash.GetHashCode();
                hashCode = hashCode * 59 + this.ArtifactItemHash.GetHashCode();
                hashCode = hashCode * 59 + this.SealPresentationNodeHash.GetHashCode();
                hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                hashCode = hashCode * 59 + this.Redacted.GetHashCode();
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