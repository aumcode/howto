# NFX Big Memory Pile

 Big Memory is a a technique of using large volumes of local RAM for the purpose of storage/processing
 of hundreds of millions (billions on 128 Gb machines) of native CLR object instances.
 
 The tecnology is oriented on business-payload, that is - it supports complex object graphs, and 
 CLR serialization nuances such as: ISerializable, IDeserializationCallback, [OnSer/Derser..] family of
 attributes.
 
 ## Pile Architecture
 
 Serializer, Manager, PilePointer, Cache and Higher level data structures
 
 ## Pile Use Cases / Industries
 
 * Social Netwrok Graph
 * High Frequency Trading (HFT)
 * Internet of Things / IoT - 
 * Stream processing 

 