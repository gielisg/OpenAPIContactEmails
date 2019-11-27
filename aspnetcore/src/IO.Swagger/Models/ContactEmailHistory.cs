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
    public partial class ContactEmailHistory : IEquatable<ContactEmailHistory>
    { 
        /// <summary>
        /// The Datetime the entity was created in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.
        /// </summary>
        /// <value>The Datetime the entity was created in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.</value>
        [DataMember(Name="Created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The user who created this entity. This is automatically updated by the database, data passed to the API in this property will be ignored.
        /// </summary>
        /// <value>The user who created this entity. This is automatically updated by the database, data passed to the API in this property will be ignored.</value>
        [DataMember(Name="CreatedBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date and time the object was last updated in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.
        /// </summary>
        /// <value>The date and time the object was last updated in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.</value>
        [DataMember(Name="LastUpdated")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The user who performed the last update in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.
        /// </summary>
        /// <value>The user who performed the last update in the database. This is automatically updated by the database, data passed to the API in this property will be ignored.</value>
        [DataMember(Name="UpdatedBy")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Unique identifier of the menu item
        /// </summary>
        /// <value>Unique identifier of the menu item</value>
        [DataMember(Name="Id")]
        public decimal? Id { get; set; }

        /// <summary>
        /// The text that will appear to the user for the menu item
        /// </summary>
        /// <value>The text that will appear to the user for the menu item</value>
        [DataMember(Name="Caption")]
        public string Caption { get; set; }

        /// <summary>
        /// A mouse-over tooltip for this menu item
        /// </summary>
        /// <value>A mouse-over tooltip for this menu item</value>
        [DataMember(Name="Tooltip")]
        public string Tooltip { get; set; }

        /// <summary>
        /// The order in which this menu item appears in the menu relative to the other menu items
        /// </summary>
        /// <value>The order in which this menu item appears in the menu relative to the other menu items</value>
        [DataMember(Name="Order")]
        public decimal? Order { get; set; }

        /// <summary>
        /// The Resource to navigate to on selection of this menu item.
        /// </summary>
        /// <value>The Resource to navigate to on selection of this menu item.</value>
        [DataMember(Name="NavigationPath")]
        public string NavigationPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactEmailHistory {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  NavigationPath: ").Append(NavigationPath).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContactEmailHistory)obj);
        }

        /// <summary>
        /// Returns true if ContactEmailHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactEmailHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactEmailHistory other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(other.CreatedBy)
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
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Caption == other.Caption ||
                    Caption != null &&
                    Caption.Equals(other.Caption)
                ) && 
                (
                    Tooltip == other.Tooltip ||
                    Tooltip != null &&
                    Tooltip.Equals(other.Tooltip)
                ) && 
                (
                    Order == other.Order ||
                    Order != null &&
                    Order.Equals(other.Order)
                ) && 
                (
                    NavigationPath == other.NavigationPath ||
                    NavigationPath != null &&
                    NavigationPath.Equals(other.NavigationPath)
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
                    if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    if (LastUpdated != null)
                    hashCode = hashCode * 59 + LastUpdated.GetHashCode();
                    if (UpdatedBy != null)
                    hashCode = hashCode * 59 + UpdatedBy.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Caption != null)
                    hashCode = hashCode * 59 + Caption.GetHashCode();
                    if (Tooltip != null)
                    hashCode = hashCode * 59 + Tooltip.GetHashCode();
                    if (Order != null)
                    hashCode = hashCode * 59 + Order.GetHashCode();
                    if (NavigationPath != null)
                    hashCode = hashCode * 59 + NavigationPath.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContactEmailHistory left, ContactEmailHistory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContactEmailHistory left, ContactEmailHistory right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
