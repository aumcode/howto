# NFX.Glue

 Glue is a distributed/remote progamming framework used to connect/"glue togeathr" classes which implement operation contract interfaces. 

 Glue is an object-oriented RPC technology based on contracts, optional instances, and methods (verbs/procedures). Conceptually 
 it is akin to WCF, however Glue is purposely built only for tight distributed systems written in NFX. 
 
 A few use-cases where Glue is used:

 * Database cluster - Glue is used for internal node replication and inter-node communication
 * Distributed consensus - Glue is used for consensus protocol in Agni OS (Raft protocol)
 * Distributed workload coordination - used in Agni OS for workset work chunk partitioning
 * HFT strategy cluster - Glue is used (along with Big Memory Pile) to feed stock exchange data into real-time trading strategies engine
 * Telemetry - glue is used in Agni Cluster OS for acquisition of high-volume logging and instrumentation data
 * Message bus + Actor farm - Glue is used in a eCommerce system to process messages containing user transactions via hierarchical actor model
 * Remote login - Glue is used in Agni OS for remote logins/console
 

 WCF users: notice no `[OperationContract]`, `[DataContract]` attributes.
 The payload serialization is polymorphic and automatic as Glue is not purposed for "one size fits all" tasks such as SOAP, REST etc. 
 (which it does not support on purpose), consequently Glue is much simpler and faster than WCF.

 In NFX, the corresponding service layers are built using the following technologies:
 * Glue - interprocess, cluster, private services with maximum flexibility, security and performance. Not interoperable with Web/other languages.
 * WAVE/web - REST, Web RPC - used for typical web-enabled public facing services
 * .NET WCF - used for SOAP support

 NFX does not implement SOAP support and there are ** no plans ** in future for supporting SOAP, WSDL and all surrounding ecosystem.


