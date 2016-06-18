namespace nestInterface;
        // class declarations
         class nest;
         class nestErrorResponse;
         class nestAllResponse;
         class Devices;
         class nestResponse;
         class nestMainResponse;
         class Structures;
         class nestStructuresResponse;
         class ThermostatObject;
         class SmokeAlarmObject;
         class StructuresObject;
     class nest 
    {
        // class delegates
        delegate FUNCTION delegateGetAccessToken ( INTEGER iIndex , SIMPLSHARPSTRING sID , SIMPLSHARPSTRING sName );
        delegate FUNCTION delegateIndicator ( INTEGER iIndicator );

        // class events

        // class functions
        FUNCTION Get_Access_Token ( STRING code );
        FUNCTION Get_All_Status ();
        static FUNCTION SaveSettings ();
        FUNCTION LoadSettings ();
        FUNCTION Send_Command ( STRING folder , STRING id , STRING command , STRING value );
        FUNCTION Redirect ( STRING url , STRING folder , STRING id , STRING command , STRING value );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER numberOfThermostats[];
        SIGNED_LONG_INTEGER numberOfStructures;
        STRING sS1ThermostatKey[][];
        STRING sS1Locale[][];
        STRING sS1TemperatureScale[][];
        STRING sS1SoftwareVersion[][];
        STRING sS1DeviceId[][];
        STRING sS1Name[][];
        STRING sS1HvacMode[][];
        STRING sS1TargetTemperatureC[][];
        STRING sS1TargetTemperatureF[][];
        STRING sS1TargetTemperatureHighC[][];
        STRING sS1TargetTemperatureHighF[][];
        STRING sS1TargetTemperatureLowC[][];
        STRING sS1TargetTemperatureLowF[][];
        STRING sS1AmbientTemperatureC[][];
        STRING sS1AmbientTemperatureF[][];
        STRING sS1AwayTemperatureHighC[][];
        STRING sS1AwayTemperatureHighF[][];
        STRING sS1AwayTemperatureLowC[][];
        STRING sS1AwayTemperatureLowF[][];
        STRING sS1StatStructureId[][];
        STRING sS2ThermostatKey[][];
        STRING sS2Locale[][];
        STRING sS2TemperatureScale[][];
        STRING sS2SoftwareVersion[][];
        STRING sS2DeviceId[][];
        STRING sS2Name[][];
        STRING sS2HvacMode[][];
        STRING sS2TargetTemperatureC[][];
        STRING sS2TargetTemperatureF[][];
        STRING sS2TargetTemperatureHighC[][];
        STRING sS2TargetTemperatureHighF[][];
        STRING sS2TargetTemperatureLowC[][];
        STRING sS2TargetTemperatureLowF[][];
        STRING sS2AmbientTemperatureC[][];
        STRING sS2AmbientTemperatureF[][];
        STRING sS2AwayTemperatureHighC[][];
        STRING sS2AwayTemperatureHighF[][];
        STRING sS2AwayTemperatureLowC[][];
        STRING sS2AwayTemperatureLowF[][];
        STRING sS2StatStructureId[][];
        STRING sS2NameLong[][];
        STRING sS2LastConnection[][];
        STRING sS2FanTimerTimeout[][];
        STRING sS1NameLong[][];
        STRING sS1LastConnection[][];
        STRING sS1FanTimerTimeout[][];
        STRING sStructureName[][];
        STRING sStructureAway[][];
        STRING sStructureId[][];
        INTEGER simplS1BIsUsingEmergencyHeat[];
        INTEGER simplS1BHasFan[];
        INTEGER simplS1BHasLeaf[];
        INTEGER simplS1BCanHeat[];
        INTEGER simplS1BCanCool[];
        INTEGER simplS1BIsOnline[];
        INTEGER simplS1BFanTimerActive[];
        INTEGER simplS1BLastConnection[];
        INTEGER simplS2BIsUsingEmergencyHeat[];
        INTEGER simplS2BHasFan[];
        INTEGER simplS2BHasLeaf[];
        INTEGER simplS2BCanHeat[];
        INTEGER simplS2BCanCool[];
        INTEGER simplS2BIsOnline[];
        INTEGER simplS2BFanTimerActive[];
        INTEGER simplS2BLastConnection[];
        STRING sTryAgain[];

        // class properties
        DelegateProperty delegateGetAccessToken SendGetAccessToken;
        DelegateProperty delegateIndicator SendIndicator;
    };

     class nestErrorResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING error[];
    };

     class nestAllResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        Devices Devices;
    };

     class Devices 
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

     class nestResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING access_token[];
        LONG_INTEGER expires_in;
    };

     class nestMainResponse 
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

     class Structures 
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

     class nestStructuresResponse 
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

     class ThermostatObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING locale[];
        STRING temperature_scale[];
        STRING software_version[];
        STRING device_id[];
        STRING name[];
        STRING hvac_mode[];
        SIGNED_LONG_INTEGER target_temperature_f;
        SIGNED_LONG_INTEGER target_temperature_high_f;
        SIGNED_LONG_INTEGER target_temperature_low_f;
        SIGNED_LONG_INTEGER ambient_temperature_f;
        SIGNED_LONG_INTEGER away_temperature_high_f;
        SIGNED_LONG_INTEGER away_temperature_low_f;
        STRING structure_id[];
        STRING name_long[];
        STRING last_connection[];
        STRING fan_timer_timeout[];
    };

     class SmokeAlarmObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING device_id[];
        STRING locale[];
        STRING software_version[];
        STRING structure_id[];
        STRING name[];
        STRING name_long[];
        STRING last_connection[];
        STRING battery_health[];
        STRING co_alarm_state[];
        STRING smoke_alarm_state[];
        STRING ui_color_state[];
    };

     class StructuresObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING name[];
        STRING country_code[];
        STRING time_zone[];
        STRING away[];
        STRING structure_id[];
    };

