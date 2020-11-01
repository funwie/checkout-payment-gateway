## Payment Gateway 

### Please see attached documents for design and architectural decisions

### To switch to production Acquirer Service, We change appsettings configuration for to the External Acquire Service

### Postman and Swagger Hub provide Mock Serveers. 
By designing the API using OpenApi standard, we can use these tools for Mock servers

The implementation assumes that external acquirer service uses Client Key and Client Secret auth

I must confess upfront that no tests have been written. Tests are critical to deliver quality software but time was against me. 
Majority time was spent learning about payment gateways and researching design patterns, architectures, technolgies and tools that will deliver the best payment gateway.
I have this knowledge and skills and will continue to implement the gateway properly.

#### Try the api from the Swagger page or use Postman.