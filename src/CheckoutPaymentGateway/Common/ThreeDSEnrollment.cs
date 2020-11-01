using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Common
{
    /// <summary>
    /// 3D-Secure Enrollment Data.
    /// </summary>
    public class ThreeDSEnrollment
    {
        /// <summary>
        /// Inidicates whether this was a 3D Secure payment downgraded to non-3D Secure (when &#x60;attempt_n3d&#x60; is specified)
        /// </summary>
        /// <value>Inidicates whether this was a 3D Secure payment downgraded to non-3D Secure (when &#x60;attempt_n3d&#x60; is specified)</value>
        public bool? Downgraded { get; set; }

        /// <summary>
        /// Indicates the 3D Secure enrollment status of the issuer   * &#x60;Y&#x60; - Issuer enrolled   * &#x60;N&#x60; - Customer not enrolled   * &#x60;U&#x60; - Unknown 
        /// </summary>
        /// <value>Indicates the 3D Secure enrollment status of the issuer   * &#x60;Y&#x60; - Issuer enrolled   * &#x60;N&#x60; - Customer not enrolled   * &#x60;U&#x60; - Unknown </value>
        public string Enrolled { get; set; }

        /// <summary>
        /// Verification to ensure the integrity of the response
        /// </summary>
        /// <value>Verification to ensure the integrity of the response</value>
        public string SignatureValid { get; set; }

        /// <summary>
        /// Indicates whether or not the cardholder was authenticated   * &#x60;Y&#x60; - Customer authenticated   * &#x60;N&#x60; - Customer not authenticated   * &#x60;A&#x60; - An authentication attempt occurred but could not be completed   * &#x60;U&#x60; - Unable to perform authentication 
        /// </summary>
        /// <value>Indicates whether or not the cardholder was authenticated   * &#x60;Y&#x60; - Customer authenticated   * &#x60;N&#x60; - Customer not authenticated   * &#x60;A&#x60; - An authentication attempt occurred but could not be completed   * &#x60;U&#x60; - Unable to perform authentication </value>
        public string AuthenticationResponse { get; set; }

        /// <summary>
        /// Base64 encoded cryptographic identifier (CAVV) used by the card schemes to validate the integrity of the 3D secure payment data
        /// </summary>
        /// <value>Base64 encoded cryptographic identifier (CAVV) used by the card schemes to validate the integrity of the 3D secure payment data</value>
        public string Cryptogram { get; set; }

        /// <summary>
        /// Unique identifier for the transaction assigned by the MPI
        /// </summary>
        /// <value>Unique identifier for the transaction assigned by the MPI</value>
        public string Xid { get; set; }

        /// <summary>
        /// Indicates the version of 3D Secure that was used for authentication
        /// </summary>
        /// <value>Indicates the version of 3D Secure that was used for authentication</value>
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model3dsData {\n");
            sb.Append("  Downgraded: ").Append(Downgraded).Append("\n");
            sb.Append("  Enrolled: ").Append(Enrolled).Append("\n");
            sb.Append("  SignatureValid: ").Append(SignatureValid).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ThreeDSEnrollment)obj);
        }

        /// <summary>
        /// Returns true if Model3dsData instances are equal
        /// </summary>
        /// <param name="other">Instance of Model3dsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSEnrollment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Downgraded == other.Downgraded ||
                    Downgraded != null &&
                    Downgraded.Equals(other.Downgraded)
                ) &&
                (
                    Enrolled == other.Enrolled ||
                    Enrolled != null &&
                    Enrolled.Equals(other.Enrolled)
                ) &&
                (
                    SignatureValid == other.SignatureValid ||
                    SignatureValid != null &&
                    SignatureValid.Equals(other.SignatureValid)
                ) &&
                (
                    AuthenticationResponse == other.AuthenticationResponse ||
                    AuthenticationResponse != null &&
                    AuthenticationResponse.Equals(other.AuthenticationResponse)
                ) &&
                (
                    Cryptogram == other.Cryptogram ||
                    Cryptogram != null &&
                    Cryptogram.Equals(other.Cryptogram)
                ) &&
                (
                    Xid == other.Xid ||
                    Xid != null &&
                    Xid.Equals(other.Xid)
                ) &&
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
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
                if (Downgraded != null)
                    hashCode = hashCode * 59 + Downgraded.GetHashCode();
                if (Enrolled != null)
                    hashCode = hashCode * 59 + Enrolled.GetHashCode();
                if (SignatureValid != null)
                    hashCode = hashCode * 59 + SignatureValid.GetHashCode();
                if (AuthenticationResponse != null)
                    hashCode = hashCode * 59 + AuthenticationResponse.GetHashCode();
                if (Cryptogram != null)
                    hashCode = hashCode * 59 + Cryptogram.GetHashCode();
                if (Xid != null)
                    hashCode = hashCode * 59 + Xid.GetHashCode();
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(ThreeDSEnrollment left, ThreeDSEnrollment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ThreeDSEnrollment left, ThreeDSEnrollment right)
        {
            return !Equals(left, right);
        }
    }
}
