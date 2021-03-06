namespace iControl {
	using System.Xml.Serialization;
	using System.Web.Services;
	using System.ComponentModel;
	using System.Web.Services.Protocols;
	using System;
	using System.Diagnostics;

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionRemoteInterfaceV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingUuid_128))]
	public partial class NetworkingiSessionRemoteInterfaceV2 : iControlInterface {
		public NetworkingiSessionRemoteInterfaceV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void create(
		string [] peers,
		string [] addresses,
		CommonEnabledState [] enabled,
		string [] names,
		string [] serverssl
	) {
		this.Invoke("create", new object [] {
				peers,
				addresses,
				enabled,
				names,
				serverssl});

	}
	public System.IAsyncResult Begincreate(string [] peers,string [] addresses,CommonEnabledState [] enabled,string [] names,string [] serverssl, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			peers,
			addresses,
			enabled,
			names,
			serverssl}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_peers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void delete_all_peers(

	) {
		this.Invoke("delete_all_peers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_peers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_peers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_peers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void delete_peer(
		string [] peers
	) {
		this.Invoke("delete_peer", new object [] {
				peers});

	}
	public System.IAsyncResult Begindelete_peer(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_peer", new object[] {
			peers}, callback, asyncState);
	}
	public void Enddelete_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_UUID
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingUuid_128 [] get_UUID(
		string [] peers
	) {
		object [] results = this.Invoke("get_UUID", new object [] {
				peers});
		return ((NetworkingUuid_128 [])(results[0]));
	}
	public System.IAsyncResult Beginget_UUID(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_UUID", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingUuid_128 [] Endget_UUID(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingUuid_128 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] peers
	) {
		object [] results = this.Invoke("get_address", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_behind_nat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_behind_nat_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_behind_nat_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_behind_nat_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_behind_nat_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_behind_nat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dedup_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_dedup_cache(
		string [] peers
	) {
		object [] results = this.Invoke("get_dedup_cache", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_dedup_cache(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dedup_cache", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_dedup_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] peers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_internal_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionRemoteInterfaceV2InternalForwarding [] get_internal_forwarding(
		string [] peers
	) {
		object [] results = this.Invoke("get_internal_forwarding", new object [] {
				peers});
		return ((NetworkingiSessionRemoteInterfaceV2InternalForwarding [])(results[0]));
	}
	public System.IAsyncResult Beginget_internal_forwarding(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_internal_forwarding", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingiSessionRemoteInterfaceV2InternalForwarding [] Endget_internal_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionRemoteInterfaceV2InternalForwarding [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public string [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_address(
		string [] peers
	) {
		object [] results = this.Invoke("get_management_address", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_address(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_address", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nat_config_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_nat_config_status(
		string [] peers
	) {
		object [] results = this.Invoke("get_nat_config_status", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat_config_status(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat_config_status", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_nat_config_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nat_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionRemoteInterfaceV2NatSourceAddress [] get_nat_source_address(
		string [] peers
	) {
		object [] results = this.Invoke("get_nat_source_address", new object [] {
				peers});
		return ((NetworkingiSessionRemoteInterfaceV2NatSourceAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat_source_address(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat_source_address", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingiSessionRemoteInterfaceV2NatSourceAddress [] Endget_nat_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionRemoteInterfaceV2NatSourceAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_origin
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionRemoteInterfaceV2OriginState [] get_origin(
		string [] peers
	) {
		object [] results = this.Invoke("get_origin", new object [] {
				peers});
		return ((NetworkingiSessionRemoteInterfaceV2OriginState [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingiSessionRemoteInterfaceV2OriginState [] Endget_origin(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionRemoteInterfaceV2OriginState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_peer_enabled_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_enabled_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_enabled_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_enabled_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_ip_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_peer_ip_list(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_ip_list", new object [] {
				peers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_ip_list(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_ip_list", new object[] {
			peers}, callback, asyncState);
	}
	public string [] [] Endget_peer_ip_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_peer_name(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_name", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_name(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_name", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_peer_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_routing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_peer_routing_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_routing_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_routing_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_routing_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_peer_routing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile_serverssl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_profile_serverssl(
		string [] peers
	) {
		object [] results = this.Invoke("get_profile_serverssl", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile_serverssl(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile_serverssl", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_profile_serverssl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tunnel_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_tunnel_port(
		string [] peers
	) {
		object [] results = this.Invoke("get_tunnel_port", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_tunnel_port(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tunnel_port", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_tunnel_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_version(

	) {
		object [] results = this.Invoke("get_version", new object [] {
});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_version", new object[] {
}, callback, asyncState);
	}
	public string Endget_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_behind_nat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_behind_nat_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_behind_nat_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_behind_nat_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_behind_nat_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_behind_nat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_description(
		string [] peers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				peers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] peers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			peers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_internal_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_internal_forwarding(
		string [] peers,
		NetworkingiSessionRemoteInterfaceV2InternalForwarding [] values
	) {
		this.Invoke("set_internal_forwarding", new object [] {
				peers,
				values});

	}
	public System.IAsyncResult Beginset_internal_forwarding(string [] peers,NetworkingiSessionRemoteInterfaceV2InternalForwarding [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_internal_forwarding", new object[] {
			peers,
			values}, callback, asyncState);
	}
	public void Endset_internal_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_management_address(
		string [] peers,
		string [] ips
	) {
		this.Invoke("set_management_address", new object [] {
				peers,
				ips});

	}
	public System.IAsyncResult Beginset_management_address(string [] peers,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_address", new object[] {
			peers,
			ips}, callback, asyncState);
	}
	public void Endset_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat_config_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_nat_config_status(
		string [] peers,
		string [] nat_configs
	) {
		this.Invoke("set_nat_config_status", new object [] {
				peers,
				nat_configs});

	}
	public System.IAsyncResult Beginset_nat_config_status(string [] peers,string [] nat_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat_config_status", new object[] {
			peers,
			nat_configs}, callback, asyncState);
	}
	public void Endset_nat_config_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_nat_source_address(
		string [] peers,
		NetworkingiSessionRemoteInterfaceV2NatSourceAddress [] nat_states
	) {
		this.Invoke("set_nat_source_address", new object [] {
				peers,
				nat_states});

	}
	public System.IAsyncResult Beginset_nat_source_address(string [] peers,NetworkingiSessionRemoteInterfaceV2NatSourceAddress [] nat_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat_source_address", new object[] {
			peers,
			nat_states}, callback, asyncState);
	}
	public void Endset_nat_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_origin(
		string [] peers,
		NetworkingiSessionRemoteInterfaceV2OriginState [] origins
	) {
		this.Invoke("set_origin", new object [] {
				peers,
				origins});

	}
	public System.IAsyncResult Beginset_origin(string [] peers,NetworkingiSessionRemoteInterfaceV2OriginState [] origins, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin", new object[] {
			peers,
			origins}, callback, asyncState);
	}
	public void Endset_origin(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_peer_enabled_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_peer_enabled_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_peer_enabled_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_enabled_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_routing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_peer_routing_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_peer_routing_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_peer_routing_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_routing_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_peer_routing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_profile_serverssl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_profile_serverssl(
		string [] peers,
		string [] serverssl
	) {
		this.Invoke("set_profile_serverssl", new object [] {
				peers,
				serverssl});

	}
	public System.IAsyncResult Beginset_profile_serverssl(string [] peers,string [] serverssl, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_profile_serverssl", new object[] {
			peers,
			serverssl}, callback, asyncState);
	}
	public void Endset_profile_serverssl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tunnel_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionRemoteInterfaceV2", 
		RequestNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2", ResponseNamespace="urn:iControl:Networking/iSessionRemoteInterfaceV2")]
	public void set_tunnel_port(
		string [] peers,
		long [] tunnel_ports
	) {
		this.Invoke("set_tunnel_port", new object [] {
				peers,
				tunnel_ports});

	}
	public System.IAsyncResult Beginset_tunnel_port(string [] peers,long [] tunnel_ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tunnel_port", new object[] {
			peers,
			tunnel_ports}, callback, asyncState);
	}
	public void Endset_tunnel_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionRemoteInterfaceV2.InternalForwarding", Namespace = "urn:iControl")]
	public enum NetworkingiSessionRemoteInterfaceV2InternalForwarding
	{
		WOC_INTERNAL_FORWARDING_UNKNOWN,
		WOC_INTERNAL_FORWARDING_DEFAULT,
		WOC_INTERNAL_FORWARDING_ENABLED,
		WOC_INTERNAL_FORWARDING_DISABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionRemoteInterfaceV2.NatSourceAddress", Namespace = "urn:iControl")]
	public enum NetworkingiSessionRemoteInterfaceV2NatSourceAddress
	{
		WOC_NAT_SOURCE_ADDRESS_NONE,
		WOC_NAT_SOURCE_ADDRESS_CLIENT,
		WOC_NAT_SOURCE_ADDRESS_WOM,
		WOC_NAT_SOURCE_ADDRESS_TUNNEL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionRemoteInterfaceV2.OriginState", Namespace = "urn:iControl")]
	public enum NetworkingiSessionRemoteInterfaceV2OriginState
	{
		MCP_ORIGIN_DISCOVERED,
		MCP_ORIGIN_CONFIGURED,
		MCP_ORIGIN_PERSISTABLE,
		MCP_ORIGIN_MANUALLY_SAVED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
