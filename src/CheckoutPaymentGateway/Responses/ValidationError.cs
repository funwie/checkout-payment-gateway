using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// Request failed validation
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "request_id")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name = "error_type")]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCodes
        /// </summary>
        [DataMember(Name = "error_codes")]
        public IEnumerable<string> ErrorCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationError {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  ErrorCodes: ").Append(ErrorCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return obj.GetType() == GetType() && Equals((ValidationError)obj);
        }

        /// <summary>
        /// Returns true if ValidationError instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationError other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) &&
                (
                    ErrorType == other.ErrorType ||
                    ErrorType != null &&
                    ErrorType.Equals(other.ErrorType)
                ) &&
                (
                    ErrorCodes == other.ErrorCodes ||
                    ErrorCodes != null &&
                    ErrorCodes.Equals(other.ErrorCodes)
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
                if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                if (ErrorType != null)
                    hashCode = hashCode * 59 + ErrorType.GetHashCode();
                if (ErrorCodes != null)
                    hashCode = hashCode * 59 + ErrorCodes.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(ValidationError left, ValidationError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValidationError left, ValidationError right)
        {
            return !Equals(left, right);
        }
    }
}
