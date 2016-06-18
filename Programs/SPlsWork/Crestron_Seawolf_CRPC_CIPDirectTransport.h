namespace Crestron.Seawolf.CRPC.CIPDirectTransport;
        // class declarations
         class CIPTransportBase;
         class CIPServerTransport;
         class CIPPacketType;
         class CIPSerializer;
         class CIPCommon;
         class CIPHeartbeatRequest;
         class CIPHeartbeatResponse;
         class CIPConnectRequest;
         class CIPConnectResponse;
         class CIPData;
         class BEBinaryWriter;
         class BEBinaryReader;
         class CIPClientTransport;
         class CIPConnectionTransport;
     class CIPTransportBase 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        SIGNED_LONG_INTEGER_FUNCTION GenerateMessageId ();
        FUNCTION Close ();
        STRING_FUNCTION ToString ();
        FUNCTION set_Type ( STRING value );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

     class CIPServerTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        FUNCTION Stop ( SIGNED_LONG_INTEGER msToWait );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

    static class CIPPacketType 
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

    static class CIPSerializer 
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

     class CIPCommon 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class CIPHeartbeatRequest 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_INTEGER Handler;
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class CIPHeartbeatResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_INTEGER Handler;
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class CIPConnectRequest 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER DestinationCID;
        INTEGER PortNumber;
        INTEGER Timeout;
        INTEGER Type;
        STRING Name[];
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class CIPConnectResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_INTEGER Handler;
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class CIPData 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static SIGNED_LONG_INTEGER PAYLOAD_LENGTH;
        static INTEGER _maxPacket;
        INTEGER PacketLength;
        static SIGNED_LONG_INTEGER HeaderSize;

        // class properties
    };

     class BEBinaryWriter 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Write ( SIGNED_INTEGER value );
        FUNCTION Close ();
        FUNCTION Flush ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CIPClientTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Close ();
        STRING_FUNCTION ToString ();
        FUNCTION Dispose ();
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        SIGNED_LONG_INTEGER_FUNCTION GenerateMessageId ();
        FUNCTION set_Type ( STRING value );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

