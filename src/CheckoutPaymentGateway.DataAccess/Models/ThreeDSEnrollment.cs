using System;

namespace CheckoutPaymentGateway.DataAccess.Models
{

    public class ThreeDSEnrollment : DatabaseEntity
    {
        public Guid Id { get; set; }
        public bool? Downgraded { get; set; }
       
        public string Enrolled { get; set; }

        public string SignatureValid { get; set; }

        public string AuthenticationResponse { get; set; }

        public string Cryptogram { get; set; }

        public string Xid { get; set; }

        public string Version { get; set; }
    }
}
