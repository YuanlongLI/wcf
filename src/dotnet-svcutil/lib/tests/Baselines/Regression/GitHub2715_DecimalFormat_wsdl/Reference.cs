//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitHub2715_DecimalFormat_wsdl_NS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4", ConfigurationName="GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType")]
    public interface AddressValidationPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fedex.com/ws/addressvalidation/v4/addressValidation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<GitHub2715_DecimalFormat_wsdl_NS.addressValidationResponse> addressValidationAsync(GitHub2715_DecimalFormat_wsdl_NS.addressValidationRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4")]
    public partial class AddressValidationRequest
    {
        
        private VersionId versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VersionId Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4")]
    public partial class VersionId
    {
        
        private string serviceIdField;
        
        private decimal intermediateField;
        
        public VersionId()
        {
            this.serviceIdField = "aval";
            this.intermediateField = ((decimal)(3.33m));
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ServiceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal Intermediate
        {
            get
            {
                return this.intermediateField;
            }
            set
            {
                this.intermediateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4")]
    public partial class AddressValidationReply
    {
        
        private VersionId versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VersionId Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addressValidationRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4", Order=0)]
        public GitHub2715_DecimalFormat_wsdl_NS.AddressValidationRequest AddressValidationRequest;
        
        public addressValidationRequest1()
        {
        }
        
        public addressValidationRequest1(GitHub2715_DecimalFormat_wsdl_NS.AddressValidationRequest AddressValidationRequest)
        {
            this.AddressValidationRequest = AddressValidationRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addressValidationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fedex.com/ws/addressvalidation/v4", Order=0)]
        public GitHub2715_DecimalFormat_wsdl_NS.AddressValidationReply AddressValidationReply;
        
        public addressValidationResponse()
        {
        }
        
        public addressValidationResponse(GitHub2715_DecimalFormat_wsdl_NS.AddressValidationReply AddressValidationReply)
        {
            this.AddressValidationReply = AddressValidationReply;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public interface AddressValidationPortTypeChannel : GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public partial class AddressValidationPortTypeClient : System.ServiceModel.ClientBase<GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType>, GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AddressValidationPortTypeClient() : 
                base(AddressValidationPortTypeClient.GetDefaultBinding(), AddressValidationPortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.AddressValidationServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AddressValidationPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(AddressValidationPortTypeClient.GetBindingForEndpoint(endpointConfiguration), AddressValidationPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AddressValidationPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AddressValidationPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AddressValidationPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AddressValidationPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AddressValidationPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GitHub2715_DecimalFormat_wsdl_NS.addressValidationResponse> GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType.addressValidationAsync(GitHub2715_DecimalFormat_wsdl_NS.addressValidationRequest1 request)
        {
            return base.Channel.addressValidationAsync(request);
        }
        
        public System.Threading.Tasks.Task<GitHub2715_DecimalFormat_wsdl_NS.addressValidationResponse> addressValidationAsync(GitHub2715_DecimalFormat_wsdl_NS.AddressValidationRequest AddressValidationRequest)
        {
            GitHub2715_DecimalFormat_wsdl_NS.addressValidationRequest1 inValue = new GitHub2715_DecimalFormat_wsdl_NS.addressValidationRequest1();
            inValue.AddressValidationRequest = AddressValidationRequest;
            return ((GitHub2715_DecimalFormat_wsdl_NS.AddressValidationPortType)(this)).addressValidationAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AddressValidationServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AddressValidationServicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://ws.fedex.com/web-services/addressvalidation");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AddressValidationPortTypeClient.GetBindingForEndpoint(EndpointConfiguration.AddressValidationServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AddressValidationPortTypeClient.GetEndpointAddress(EndpointConfiguration.AddressValidationServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            AddressValidationServicePort,
        }
    }
}