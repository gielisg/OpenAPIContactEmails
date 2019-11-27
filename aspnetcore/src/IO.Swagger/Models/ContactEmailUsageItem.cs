/*
 * Contact Emails
 *
 * Manages the emails used to contact a Contact.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: gielisg@selectsoftware.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ContactEmailUsageItem : IEquatable<ContactEmailUsageItem>
    { 
        /// <summary>
        /// Id. of the Contact Email item
        /// </summary>
        /// <value>Id. of the Contact Email item</value>
        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The Email Address.
        /// </summary>
        /// <value>The Email Address.</value>
        [DataMember(Name="EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets EmailTypes
        /// </summary>
        [DataMember(Name="EmailTypes")]
        public List<ContactEmailType> EmailTypes { get; set; }

        /// <summary>
        /// Gets or Sets FromDateTime
        /// </summary>
        [DataMember(Name="FromDateTime")]
        public FromDateTime FromDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="LastUpdated")]
        public LastUpdatedDateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="UpdatedBy")]
        public LastUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactEmailUsageItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmailTypes: ").Append(EmailTypes).Append("\n");
            sb.Append("  FromDateTime: ").Append(FromDateTime).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ContactEmailUsageItem)obj);
        }

        /// <summary>
        /// Returns true if ContactEmailUsageItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactEmailUsageItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactEmailUsageItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    EmailAddress == other.EmailAddress ||
                    EmailAddress != null &&
                    EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    EmailTypes == other.EmailTypes ||
                    EmailTypes != null &&
                    EmailTypes.SequenceEqual(other.EmailTypes)
                ) && 
                (
                    FromDateTime == other.FromDateTime ||
                    FromDateTime != null &&
                    FromDateTime.Equals(other.FromDateTime)
                ) && 
                (
                    LastUpdated == other.LastUpdated ||
                    LastUpdated != null &&
                    LastUpdated.Equals(other.LastUpdated)
                ) && 
                (
                    UpdatedBy == other.UpdatedBy ||
                    UpdatedBy != null &&
                    UpdatedBy.Equals(other.UpdatedBy)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (EmailAddress != null)
                    hashCode = hashCode * 59 + EmailAddress.GetHashCode();
                    if (EmailTypes != null)
                    hashCode = hashCode * 59 + EmailTypes.GetHashCode();
                    if (FromDateTime != null)
                    hashCode = hashCode * 59 + FromDateTime.GetHashCode();
                    if (LastUpdated != null)
                    hashCode = hashCode * 59 + LastUpdated.GetHashCode();
                    if (UpdatedBy != null)
                    hashCode = hashCode * 59 + UpdatedBy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContactEmailUsageItem left, ContactEmailUsageItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContactEmailUsageItem left, ContactEmailUsageItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
