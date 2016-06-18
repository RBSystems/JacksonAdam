namespace Crestron.Seawolf.CRPC.v2.Messages.Exceptions;
        // class declarations
         class CrpcClientNotRegisteredException;
         class CrpcClientRequestTimedoutException;
         class CrpcClientConnectionClosedException;
     class CrpcClientNotRegisteredException 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Message[];
        STRING StackTrace[];
        STRING HelpLink[];
        STRING Source[];
    };

     class CrpcClientConnectionClosedException 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Message[];
        STRING StackTrace[];
        STRING HelpLink[];
        STRING Source[];
    };

namespace Crestron.Seawolf.CRPC;
        // class declarations
         class XLock;
         class CrpcCommandExecuteMethod;
         class CrpcCommandDeregisterEvent;
         class ParameterCasterBase;
         class ParameterCasterDateTime;
         class JSONRPCMethod;
         class JSONRPCEvent;
         class JSONRPCEventParams;
         class JSONRPCError;
         class CrpcJsonException;
         class CrpcUtility;
         class CrpcEventInfo;
         class CrpcDirectory;
         class ParameterCastCollection;
         class ClientTransportLayer;
         class CrpcEvents;
         class CrpcClientService;
         class CrpcCommandFactory;
         class ClientToServerRegistration;
         class ParameterCasterInt32;
         class CrpcCommandSetProperty;
         class ParameterCasterSingle;
         class ParameterCasterByte;
         class ServerTransportLayer;
         class CrpcCommandRegisterCrpcEvent;
         class CrpcCommandRegister;
         class JSONRPCRegisterResult;
         class ParameterCasterUInt16;
         class CrpcService;
         class CrpcCommandRegisterEvent;
         class CrpcCommandGetMembers;
         class JSONRPCResponseMembers;
         class JSONRPCResponseMembersMethodArray;
         class JSONRPCResponseMembersPropertyArray;
         class JSONRPCResponseMembersEventArray;
         class ClientToServerGetObjects;
         class serverObject;
         class CrpcServiceObject;
         class CrpcObject;
         class CrpcDescriptor;
         class CrpcConstants;
         class CrpcServiceConstants;
         class JsonRpc2Errors;
         class JSONRPC;
         class CrpcRegisterEvent;
         class CrpcDeregisterEvent;
         class CrpcEvent;
         class Register;
         class Method;
         class Property;
         class GetObjects;
         class GetMembers;
         class CrpcCommandGetProperty;
         class XLockObject;
         class ConnectionInfo;
         class ParameterCasterUInt32;
         class ParameterCasterUInt64;
         class ParameterCasterSByte;
         class ParameterCasterInt16;
         class CrpcCommandGetObjects;
         class JSONRPCResponseObjects;
         class JSONRPCResponseObjectArray;
         class CrpcCommandDeregisterCrpcEvent;
    static class CrpcUtility 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION RemoveQuotes ( STRING paramInputString );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrpcEventInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING EventName[];
        STRING Handle[];
    };

     class CrpcDirectory 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Unregister ( STRING name );
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        SIGNED_LONG_INTEGER ObjectCount;
    };

     class ParameterCastCollection 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrpcEvents 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrpcClientService 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Unregister ( STRING name );
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        SIGNED_LONG_INTEGER ObjectCount;
    };

     class CrpcCommandFactory 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ServerTransportLayer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        FUNCTION Initialize ( STRING Type );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Name[];
    };

     class CrpcService 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( STRING name );
        FUNCTION Unregister ( STRING name );
        FUNCTION Dispose ();
        static FUNCTION ValidateRequest ( JSONRPCMethod request );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrpcService Instance;
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        SIGNED_LONG_INTEGER ObjectCount;
    };

     class serverObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING name[];
        STRING instanceName[];

        // class properties
    };

     class CrpcServiceObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrpcObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING TypeName[];
        STRING TypeVersion[];
        STRING Name[];
        STRING Version[];
    };

    static class CrpcConstants 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class CrpcServiceConstants 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static SIGNED_LONG_INTEGER MAX_PACKET_SIZE;
        static STRING CRPC_VERSION[];
        static STRING CRPC_RESERVED_OBJECT_NAME[];
        static STRING CRPC_FORMAT_JSON[];
        static STRING CRPC_FORMAT_BSON[];
        static STRING CRPC_EVENT_OBJECTDIRCHANGED[];
        static STRING CRPC_EVENT_OBJECTS_ADDED[];
        static STRING CRPC_EVENT_OBJECTS_REMOVED[];
        static STRING CRPC_SERVICE_OBJECT_NAME[];

        // class properties
    };

    static class JsonRpc2Errors 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static SIGNED_LONG_INTEGER PARSE_ERROR;
        static SIGNED_LONG_INTEGER INVALID_REQUEST;
        static SIGNED_LONG_INTEGER METHOD_NOT_FOUND;
        static SIGNED_LONG_INTEGER INVALID_PARAMS;
        static SIGNED_LONG_INTEGER INTERNAL_ERROR;
        static SIGNED_LONG_INTEGER IMPL_SERVER_ERROR_START;
        static SIGNED_LONG_INTEGER IMPL_SERVER_PROPERTY_NOT_AVAILABLE;
        static SIGNED_LONG_INTEGER IMPL_SERVER_OBJECT_NOT_FOUND;
        static SIGNED_LONG_INTEGER IMPL_SERVER_CLIENT_NOT_REGISTERED;
        static SIGNED_LONG_INTEGER IMPL_SERVER_FORMATS_NOT_SUPPORTED;
        static SIGNED_LONG_INTEGER IMPL_SERVER_ENCODINGS_NOT_SUPPORTED;
        static SIGNED_LONG_INTEGER IMPL_SERVER_EVENT_NOT_SUPPORTED;
        static SIGNED_LONG_INTEGER IMPL_SERVER_ERROR_END;

        // class properties
    };

    static class JSONRPC 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_VERSION[];
        static STRING JSONRPC_ID[];
        static STRING JSONRPC_RESULT[];
        static STRING JSONRPC_ERROR[];
        static STRING JSONRPC_PARAMS[];
        static STRING JSONRPC_PARAMETERS[];

        // class properties
    };

    static class CrpcRegisterEvent 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_REGISTEREVENT[];
        static STRING JSONRPC_REGISTEREVENT_PARAM_EVENT[];
        static STRING JSONRPC_REGISTEREVENT_PARAM_HANDLE[];
        static STRING JSONRPC_EVENT_PARAMS[];

        // class properties
    };

    static class CrpcDeregisterEvent 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_DEREGISTEREVENT[];
        static STRING JSONRPC_DEREGISTEREVENT_PARAM_EVENT[];
        static STRING JSONRPC_DEREGISTEREVENT_PARAM_HANDLE[];
        static STRING JSONRPC_EVENT_PARAMS[];

        // class properties
    };

    static class CrpcEvent 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_EVENT[];
        static STRING JSONRPC_EVENT_PARAM_EVENT[];
        static STRING JSONRPC_EVENT_PARAM_HANDLE[];
        static STRING JSONRPC_EVENT_PARAMS[];
        static STRING JSONRPC_EVENT_PARAMETERS[];

        // class properties
    };

    static class Register 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_REGISTER[];
        static STRING JSONRPC_REGISTER_VER[];
        static STRING JSONRPC_REGISTER_NAME[];
        static STRING JSONRPC_REGISTER_UUID[];
        static STRING JSONRPC_REGISTER_CONNECTIONS[];
        static STRING JSONRPC_REGISTER_MAXPACKETSIZE[];
        static STRING JSONRPC_REGISTER_ENCODING[];
        static STRING JSONRPC_REGISTER_FORMAT[];
        static STRING JSONRPC_REGISTER_SUPPORTED_ENCODINGS[];
        static STRING JSONRPC_REGISTER_SUPPORTED_FORMATS[];

        // class properties
    };

    static class Method 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_METHOD[];

        // class properties
    };

    static class Property 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_PROPERTY_GET[];
        static STRING JSONRPC_PROPERTY_SET[];
        static STRING JSONRPC_PROPERTY_NAME[];
        static STRING JSONRPC_PROPERTY_VALUE[];

        // class properties
    };

    static class GetObjects 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_GETOBJECTS[];
        static STRING JSONRPC_GETOBJECTS_OBJECTS[];
        static STRING JSONRPC_GETOBJECTS_CATEGORY[];
        static STRING JSONRPC_GETOBJECTS_INSTANCENAME[];
        static STRING JSONRPC_GETOBJECTS_INTERFACES[];
        static STRING JSONRPC_GETOBJECTS_UUID[];
        static STRING JSONRPC_GETOBJECTS_NAME[];

        // class properties
    };

    static class GetMembers 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING JSONRPC_GETMEMBERS[];
        static STRING JSONRPC_GETMEMBERS_OBJECT[];
        static STRING JSONRPC_GETMEMBERS_ACCESS[];

        // class properties
    };

     class XLockObject 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Unlock ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ConnectionInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

namespace Crestron.Seawolf.CRPC.v2.Objects;
        // class declarations
         class CrpcRemoteObjectBase;
         class CrpcRemoteObjectProxy;
     class CrpcRemoteObjectBase 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrpcRemoteObjectProxy Proxy;
        STRING Name[];
        STRING Instance[];
        STRING Categories[][];
        STRING Interfaces[][];
        STRING TypeName[];
        STRING TypeVersion[];
    };

namespace Crestron.Seawolf.CRPC.v2.Formats;
        // class declarations
         class BsonFormat;
         class FormatsManager;
         class XmlFormat;
         class Util;
         class JsonFormat;
     class BsonFormat 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Name[];
    };

     class FormatsManager 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DefaultFormatName[];
        STRING DefaultEncoderName[];
    };

     class XmlFormat 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Name[];
    };

    static class Util 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class JsonFormat 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Name[];
    };

namespace Crestron.Seawolf.CRPC.v2.Messages;
        // class declarations
         class CrpcResponseException;
         class CrpcMessage;
     class CrpcMessage 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING JsonRpc[];
        STRING Method[];
        SIGNED_LONG_INTEGER Id;
    };

namespace Crestron.Seawolf.CRPC.v2.Service;
        // class declarations
         class EventRegisterEntry;
         class CrpcClientService;
         class ServiceState;
         class ConnectionState;
         class RegistrationState;
     class CrpcClientService 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        STRING Encoding[];
        STRING Format[];
        STRING Hostname[];
        SIGNED_LONG_INTEGER ObjectCount;
    };

    static class ServiceState // enum
    {
        static SIGNED_LONG_INTEGER Stopped;
        static SIGNED_LONG_INTEGER Starting;
        static SIGNED_LONG_INTEGER Running;
        static SIGNED_LONG_INTEGER Stopping;
    };

    static class ConnectionState // enum
    {
        static SIGNED_LONG_INTEGER Closed;
        static SIGNED_LONG_INTEGER Connecting;
        static SIGNED_LONG_INTEGER Connected;
        static SIGNED_LONG_INTEGER Closing;
    };

    static class RegistrationState // enum
    {
        static SIGNED_LONG_INTEGER Unregistered;
        static SIGNED_LONG_INTEGER Registering;
        static SIGNED_LONG_INTEGER Registered;
        static SIGNED_LONG_INTEGER Unregistering;
    };

namespace Crestron.Seawolf.CRPC.v2.Encodings;
        // class declarations
         class Utf8Encoder;
         class EncoderManager;
     class Utf8Encoder 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Name[];
    };

     class EncoderManager 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DefaultName[];
    };

namespace Crestron.Seawolf.CRPC.CrpcGenericClient;
        // class declarations
         class CrpcClient;
         class GenericClientFunctions;
         class SceneStatusEnum;
         class ModuleType;
         class ClientMessageTypes;
     class CrpcClient 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        Crestron.Seawolf.CRPC.ClientToServerGetObjects ClientObjectGetObjects;
        Crestron.Seawolf.CRPC.ClientToServerRegistration ClientObjectRegister;
        Crestron.Seawolf.CRPC.CrpcGenericClient.GenericClientFunctions GeneralFunctions;

        // class properties
        SIGNED_LONG_INTEGER GetMessageId;
    };

    static class SceneStatusEnum // enum
    {
        static SIGNED_LONG_INTEGER NotFound;
        static SIGNED_LONG_INTEGER Active;
        static SIGNED_LONG_INTEGER NotActive;
    };

    static class ModuleType // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER ClientDriven;
        static SIGNED_LONG_INTEGER ServerDriven;
    };

    static class ClientMessageTypes // enum
    {
        static SIGNED_LONG_INTEGER Register;
        static SIGNED_LONG_INTEGER GetObjects;
        static SIGNED_LONG_INTEGER GetSceneNames;
        static SIGNED_LONG_INTEGER GetSceneId;
        static SIGNED_LONG_INTEGER GetChangedScenes;
        static SIGNED_LONG_INTEGER GetSceneStatus;
        static SIGNED_LONG_INTEGER RegisterForSceneChanges;
    };

namespace Crestron.Seawolf.CRPC.v2.Interfaces;
        // class declarations

