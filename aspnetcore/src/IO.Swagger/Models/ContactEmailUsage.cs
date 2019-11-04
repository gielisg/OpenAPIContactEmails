/*
 * Contact Emails
 *
 * Manages the emails used to contact Contacts.
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
    public partial class ContactEmailUsage : IEquatable<ContactEmailUsage>
    { 
        /// <summary>
        /// Gets or Sets _ContactEmailUsage
        /// </summary>
        [DataMember(Name="ContactEmailUsage")]
        public List<ContactEmailUsageItem> _ContactEmailUsage { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmailMandatoryRules
        /// </summary>
        [DataMember(Name="ContactEmailMandatoryRules")]
        public List<ContactEmailMandatoryRule> ContactEmailMandatoryRules { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmailTypes
        /// </summary>
        [DataMember(Name="ContactEmailTypes")]
        public List<ContactEmailType> ContactEmailTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactEmailUsage {\n");
            sb.Append("  _ContactEmailUsage: ").Append(_ContactEmailUsage).Append("\n");
            sb.Append("  ContactEmailMandatoryRules: ").Append(ContactEmailMandatoryRules).Append("\n");
            sb.Append("  ContactEmailTypes: ").Append(ContactEmailTypes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContactEmailUsage)obj);
        }

        /// <summary>
        /// Returns true if ContactEmailUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactEmailUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactEmailUsage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _ContactEmailUsage == other._ContactEmailUsage ||
                    _ContactEmailUsage != null &&
                    _ContactEmailUsage.SequenceEqual(other._ContactEmailUsage)
                ) && 
                (
                    ContactEmailMandatoryRules == other.ContactEmailMandatoryRules ||
                    ContactEmailMandatoryRules != null &&
                    ContactEmailMandatoryRules.SequenceEqual(other.ContactEmailMandatoryRules)
                ) && 
                (
                    ContactEmailTypes == other.ContactEmailTypes ||
                    ContactEmailTypes != null &&
                    ContactEmailTypes.SequenceEqual(other.ContactEmailTypes)
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
                    if (_ContactEmailUsage != null)
                    hashCode = hashCode * 59 + _ContactEmailUsage.GetHashCode();
                    if (ContactEmailMandatoryRules != null)
                    hashCode = hashCode * 59 + ContactEmailMandatoryRules.GetHashCode();
                    if (ContactEmailTypes != null)
                    hashCode = hashCode * 59 + ContactEmailTypes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContactEmailUsage left, ContactEmailUsage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContactEmailUsage left, ContactEmailUsage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}