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
    /// A response containing all of the components for all requested vendors.
    /// </summary>
    [DataContract]
    public partial class DestinyResponsesDestinyVendorsResponse :  IEquatable<DestinyResponsesDestinyVendorsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyVendorsResponse" /> class.
        /// </summary>
        /// <param name="vendorGroups">For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors.</param>
        /// <param name="vendors">The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors.</param>
        /// <param name="categories">Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories.</param>
        /// <param name="sales">Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales.</param>
        /// <param name="itemComponents">The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor..</param>
        /// <param name="currencyLookups">A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups.</param>
        public DestinyResponsesDestinyVendorsResponse(SingleComponentResponseOfDestinyVendorGroupComponent vendorGroups = default(SingleComponentResponseOfDestinyVendorGroupComponent), DictionaryComponentResponseOfuint32AndDestinyVendorComponent vendors = default(DictionaryComponentResponseOfuint32AndDestinyVendorComponent), DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent categories = default(DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent), DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent sales = default(DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent), Dictionary<string, DestinyItemComponentSetOfint32> itemComponents = default(Dictionary<string, DestinyItemComponentSetOfint32>), SingleComponentResponseOfDestinyCurrenciesComponent currencyLookups = default(SingleComponentResponseOfDestinyCurrenciesComponent))
        {
            this.VendorGroups = vendorGroups;
            this.Vendors = vendors;
            this.Categories = categories;
            this.Sales = sales;
            this.ItemComponents = itemComponents;
            this.CurrencyLookups = currencyLookups;
        }
        
        /// <summary>
        /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors
        /// </summary>
        /// <value>For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors</value>
        [DataMember(Name="vendorGroups", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

        /// <summary>
        /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors
        /// </summary>
        /// <value>The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors</value>
        [DataMember(Name="vendors", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors { get; set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories
        /// </summary>
        /// <value>Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales
        /// </summary>
        /// <value>Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales</value>
        [DataMember(Name="sales", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales { get; set; }

        /// <summary>
        /// The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor.
        /// </summary>
        /// <value>The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor.</value>
        [DataMember(Name="itemComponents", EmitDefaultValue=false)]
        public Dictionary<string, DestinyItemComponentSetOfint32> ItemComponents { get; set; }

        /// <summary>
        /// A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
        /// </summary>
        /// <value>A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</value>
        [DataMember(Name="currencyLookups", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyVendorsResponse {\n");
            sb.Append("  VendorGroups: ").Append(VendorGroups).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
            sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
            sb.Append("  CurrencyLookups: ").Append(CurrencyLookups).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyVendorsResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyVendorsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyVendorsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyVendorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorGroups == input.VendorGroups ||
                    (this.VendorGroups != null &&
                    this.VendorGroups.Equals(input.VendorGroups))
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    (this.Vendors != null &&
                    this.Vendors.Equals(input.Vendors))
                ) && 
                (
                    this.Categories == input.Categories ||
                    (this.Categories != null &&
                    this.Categories.Equals(input.Categories))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
                ) && 
                (
                    this.ItemComponents == input.ItemComponents ||
                    this.ItemComponents != null &&
                    input.ItemComponents != null &&
                    this.ItemComponents.SequenceEqual(input.ItemComponents)
                ) && 
                (
                    this.CurrencyLookups == input.CurrencyLookups ||
                    (this.CurrencyLookups != null &&
                    this.CurrencyLookups.Equals(input.CurrencyLookups))
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
                if (this.VendorGroups != null)
                    hashCode = hashCode * 59 + this.VendorGroups.GetHashCode();
                if (this.Vendors != null)
                    hashCode = hashCode * 59 + this.Vendors.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Sales != null)
                    hashCode = hashCode * 59 + this.Sales.GetHashCode();
                if (this.ItemComponents != null)
                    hashCode = hashCode * 59 + this.ItemComponents.GetHashCode();
                if (this.CurrencyLookups != null)
                    hashCode = hashCode * 59 + this.CurrencyLookups.GetHashCode();
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
