namespace Crestron.Seawolf.CRPC;
        // class declarations
         class JoinTransportClientBase;
         class JoinTransportServerBase;
     class JoinTransportServerBase 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        FUNCTION CloseClientTransports ();
        FUNCTION CloseClientTransport ( STRING tag );
        FUNCTION OnJoinData ( STRING pkt );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static SIGNED_LONG_INTEGER ENCODING;

        // class properties
        STRING Type[];
    };

