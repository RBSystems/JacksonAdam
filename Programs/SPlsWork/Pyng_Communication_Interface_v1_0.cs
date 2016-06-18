using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using AffinityClientConnection.Client.Serial_Client_Interface;
using AffinityClientConnectionModule.Client;
using AffinityClientConnection.Logging;
using AffinityClientConnection;
using AffinityClientConnection.Configuration;
using AffinityClientConnection.Client.Serial_Client_Interface.CRPC_Calls;
using Crestron.Seawolf.CRPC.v2.Messages.Exceptions;
using Crestron.Seawolf.CRPC;
using Crestron.Seawolf.CRPC.v2.Objects;
using Crestron.Seawolf.CRPC.v2.Formats;
using Crestron.Seawolf.CRPC.v2.Messages;
using Crestron.Seawolf.CRPC.v2.Service;
using Crestron.Seawolf.CRPC.v2.Encodings;
using Crestron.Seawolf.CRPC.CrpcGenericClient;
using Crestron.Seawolf.CRPC.v2.Interfaces;
using Crestron.Seawolf.CRPC.CIPDirectTransport;
using Crestron.Seawolf.CRPC.Common;
using Crestron.Seawolf.CRPC.Common.v2.Messages.Objects;
using Crestron.Seawolf.CRPC.Common.v2.Utilities;
using Crestron.Seawolf.CRPC.Common.Extensions;
using Crestron.Seawolf.CRPC.Common.v2.Interfaces;

namespace CrestronModule_PYNG_COMMUNICATION_INTERFACE_V1_0
{
    public class CrestronModuleClass_PYNG_COMMUNICATION_INTERFACE_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SETSIGNAL;
        Crestron.Logos.SplusObjects.StringInput MODULENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIGNALNAME;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SIGNALCONFIGURED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SIGNALACTIVE;
        Crestron.Logos.SplusObjects.AnalogOutput CONNECTED;
        UShortParameter MODULE_CONTROL_MODE;
        AffinityClientConnectionModule.Client.ClientConnectionForSimplPlus AFFINITYCONTROL;
        public void SIGNALFBUPDATESPLUS ( ushort [] SCENEFBARRAY ) 
            { 
            ushort I = 0;
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 89;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)20; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 91;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 93;
                        Print( "S+: Scene Fb Array Index {0:d} = {1:d}\r\n", (short)I, (short)SCENEFBARRAY[ (I - 1) ]) ; 
                        } 
                    
                    __context__.SourceCodeLine = 95;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_1__ = ((int)SCENEFBARRAY[ (I - 1) ]);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 99;
                                SIGNALACTIVE [ I]  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 100;
                                SIGNALCONFIGURED [ I]  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 104;
                                SIGNALACTIVE [ I]  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 105;
                                SIGNALCONFIGURED [ I]  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 110;
                                SIGNALACTIVE [ I]  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 111;
                                SIGNALCONFIGURED [ I]  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 115;
                                SIGNALACTIVE [ I]  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 116;
                                SIGNALCONFIGURED [ I]  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 89;
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void CONNECTIONFBUPDATESPLUS ( ushort CONNECTIONSTATUS ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 129;
                CONNECTED  .Value = (ushort) ( CONNECTIONSTATUS ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        private void TRYTOCONNECT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 135;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 137;
                Print( "S+:Request new Connection sent to C# function\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 139;
            AFFINITYCONTROL . EnableConnection ( ) ; 
            
            }
            
        object DEBUG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 158;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 160;
                    AFFINITYCONTROL . Debug ( (ushort)( 1 )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 164;
                    AFFINITYCONTROL . Debug ( (ushort)( 0 )) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    private void PROCESSSIGNALNAMES (  SplusExecutionContext __context__ ) 
        { 
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 172;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)20; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 174;
            AFFINITYCONTROL . SetSignalNameFromSymbolList ( (ushort)( X ), SIGNALNAME[ X ] .ToString()) ; 
            __context__.SourceCodeLine = 175;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 177;
                Print( "S+:Scene Index Send to C# = {0:d}, Name = {1}\r\n", (short)X, SIGNALNAME [ X ] ) ; 
                } 
            
            __context__.SourceCodeLine = 172;
            } 
        
        
        }
        
    object SETSIGNAL_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort JOINCHANGEINDEX = 0;
            
            
            __context__.SourceCodeLine = 185;
            JOINCHANGEINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 187;
            AFFINITYCONTROL . SetDigitalJoinValue ( SIGNALNAME[ JOINCHANGEINDEX ] .ToString(), (ushort)( SETSIGNAL[ JOINCHANGEINDEX ] .Value )) ; 
            __context__.SourceCodeLine = 188;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 190;
                Print( "S+:Digital Join Sent to C# Value = {0:d}, Name = {1}\r\n", (short)SETSIGNAL[ JOINCHANGEINDEX ] .Value, SIGNALNAME [ JOINCHANGEINDEX ] ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 203;
        // RegisterDelegate( AFFINITYCONTROL , SIGNALFBSTATUSARRAY , SIGNALFBUPDATESPLUS ) 
        AFFINITYCONTROL .SignalFbStatusArray  = SIGNALFBUPDATESPLUS; ; 
        __context__.SourceCodeLine = 206;
        // RegisterDelegate( AFFINITYCONTROL , CONNECTIONSTATUS , CONNECTIONFBUPDATESPLUS ) 
        AFFINITYCONTROL .ConnectionStatus  = CONNECTIONFBUPDATESPLUS; ; 
        __context__.SourceCodeLine = 208;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 211;
        AFFINITYCONTROL . Initialize ( (ushort)( MODULE_CONTROL_MODE  .Value ), MODULENAME .ToString()) ; 
        __context__.SourceCodeLine = 212;
        PROCESSSIGNALNAMES (  __context__  ) ; 
        __context__.SourceCodeLine = 213;
        TRYTOCONNECT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    SETSIGNAL = new InOutArray<DigitalInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        SETSIGNAL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SETSIGNAL__DigitalInput__ + i, SETSIGNAL__DigitalInput__, this );
        m_DigitalInputList.Add( SETSIGNAL__DigitalInput__ + i, SETSIGNAL[i+1] );
    }
    
    SIGNALCONFIGURED = new InOutArray<DigitalOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        SIGNALCONFIGURED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SIGNALCONFIGURED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SIGNALCONFIGURED__DigitalOutput__ + i, SIGNALCONFIGURED[i+1] );
    }
    
    SIGNALACTIVE = new InOutArray<DigitalOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        SIGNALACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SIGNALACTIVE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SIGNALACTIVE__DigitalOutput__ + i, SIGNALACTIVE[i+1] );
    }
    
    CONNECTED = new Crestron.Logos.SplusObjects.AnalogOutput( CONNECTED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONNECTED__AnalogSerialOutput__, CONNECTED );
    
    MODULENAME = new Crestron.Logos.SplusObjects.StringInput( MODULENAME__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( MODULENAME__AnalogSerialInput__, MODULENAME );
    
    SIGNALNAME = new InOutArray<StringInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        SIGNALNAME[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIGNALNAME__AnalogSerialInput__ + i, SIGNALNAME__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( SIGNALNAME__AnalogSerialInput__ + i, SIGNALNAME[i+1] );
    }
    
    MODULE_CONTROL_MODE = new UShortParameter( MODULE_CONTROL_MODE__Parameter__, this );
    m_ParameterList.Add( MODULE_CONTROL_MODE__Parameter__, MODULE_CONTROL_MODE );
    
    
    DEBUG.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_OnPush_0, false ) );
    for( uint i = 0; i < 20; i++ )
        SETSIGNAL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( SETSIGNAL_OnChange_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    AFFINITYCONTROL  = new AffinityClientConnectionModule.Client.ClientConnectionForSimplPlus();
    
    
}

public CrestronModuleClass_PYNG_COMMUNICATION_INTERFACE_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint SETSIGNAL__DigitalInput__ = 1;
const uint MODULENAME__AnalogSerialInput__ = 0;
const uint SIGNALNAME__AnalogSerialInput__ = 1;
const uint SIGNALCONFIGURED__DigitalOutput__ = 0;
const uint SIGNALACTIVE__DigitalOutput__ = 20;
const uint CONNECTED__AnalogSerialOutput__ = 0;
const uint MODULE_CONTROL_MODE__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
