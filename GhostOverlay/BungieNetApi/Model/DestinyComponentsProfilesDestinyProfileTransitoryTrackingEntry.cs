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
    /// This represents a single \&quot;thing\&quot; being tracked by the player.  This can point to many types of entities, but only a subset of them will actually have a valid hash identifier for whatever it is being pointed to.  It&#39;s up to you to interpret what it means when various combinations of these entries have values being tracked.
    /// </summary>
    [DataContract]
    public partial class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry :  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry" /> class.
        /// </summary>
        /// <param name="locationHash">OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location..</param>
        /// <param name="itemHash">OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item..</param>
        /// <param name="objectiveHash">OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective..</param>
        /// <param name="activityHash">OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity..</param>
        /// <param name="questlineItemHash">OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data..</param>
        /// <param name="trackedDate">OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data..</param>
        public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry(long locationHash = default(long), long itemHash = default(long), long objectiveHash = default(long), long activityHash = default(long), long questlineItemHash = default(long), DateTime trackedDate = default(DateTime))
        {
            this.LocationHash = locationHash;
            this.ItemHash = itemHash;
            this.ObjectiveHash = objectiveHash;
            this.ActivityHash = activityHash;
            this.QuestlineItemHash = questlineItemHash;
            this.TrackedDate = trackedDate;
        }
        
        /// <summary>
        /// OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
        /// </summary>
        /// <value>OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.</value>
        [DataMember(Name="locationHash", EmitDefaultValue=false)]
        public long LocationHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
        /// </summary>
        /// <value>OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public long ItemHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
        /// </summary>
        /// <value>OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public long ObjectiveHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
        /// </summary>
        /// <value>OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public long ActivityHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
        /// </summary>
        /// <value>OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.</value>
        [DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
        public long QuestlineItemHash { get; set; }

        /// <summary>
        /// OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data.
        /// </summary>
        /// <value>OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data.</value>
        [DataMember(Name="trackedDate", EmitDefaultValue=false)]
        public DateTime TrackedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry {\n");
            sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  QuestlineItemHash: ").Append(QuestlineItemHash).Append("\n");
            sb.Append("  TrackedDate: ").Append(TrackedDate).Append("\n");
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
            return this.Equals(input as DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry);
        }

        /// <summary>
        /// Returns true if DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationHash == input.LocationHash ||
                    this.LocationHash.Equals(input.LocationHash)
                ) && 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    this.ObjectiveHash.Equals(input.ObjectiveHash)
                ) && 
                (
                    this.ActivityHash == input.ActivityHash ||
                    this.ActivityHash.Equals(input.ActivityHash)
                ) && 
                (
                    this.QuestlineItemHash == input.QuestlineItemHash ||
                    this.QuestlineItemHash.Equals(input.QuestlineItemHash)
                ) && 
                (
                    this.TrackedDate == input.TrackedDate ||
                    (this.TrackedDate != null &&
                    this.TrackedDate.Equals(input.TrackedDate))
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
                hashCode = hashCode * 59 + this.LocationHash.GetHashCode();
                hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
                hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
                hashCode = hashCode * 59 + this.QuestlineItemHash.GetHashCode();
                if (this.TrackedDate != null)
                    hashCode = hashCode * 59 + this.TrackedDate.GetHashCode();
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