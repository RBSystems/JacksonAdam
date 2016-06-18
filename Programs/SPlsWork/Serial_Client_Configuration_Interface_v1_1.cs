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

namespace CrestronModule_SERIAL_CLIENT_CONFIGURATION_INTERFACE_V1_1
{
    public class CrestronModuleClass_SERIAL_CLIENT_CONFIGURATION_INTERFACE_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput SERVERPORT;
        Crestron.Logos.SplusObjects.StringInput SERVERADDRESS;
        Crestron.Logos.SplusObjects.StringInput CONSOLECMD;
        object SERVERPORT_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 EthernetSettings.SetServerPort( (ushort)( SERVERPORT  .UshortValue ) )  ;  
 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SERVERADDRESS_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
             EthernetSettings.SetServerIPAddressorHostName(  SERVERADDRESS .ToString() )  ;  
 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONSOLECMD_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         ProxyServer.ConsoleDebug(  CONSOLECMD .ToString() )  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
     EthernetSettings.Initialize()  ;  
 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SERVERPORT = new Crestron.Logos.SplusObjects.AnalogInput( SERVERPORT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SERVERPORT__AnalogSerialInput__, SERVERPORT );
    
    SERVERADDRESS = new Crestron.Logos.SplusObjects.StringInput( SERVERADDRESS__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( SERVERADDRESS__AnalogSerialInput__, SERVERADDRESS );
    
    CONSOLECMD = new Crestron.Logos.SplusObjects.StringInput( CONSOLECMD__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( CONSOLECMD__AnalogSerialInput__, CONSOLECMD );
    
    
    SERVERPORT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SERVERPORT_OnChange_0, false ) );
    SERVERADDRESS.OnSerialChange.Add( new InputChangeHandlerWrapper( SERVERADDRESS_OnChange_1, false ) );
    CONSOLECMD.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLECMD_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SERIAL_CLIENT_CONFIGURATION_INTERFACE_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SERVERPORT__AnalogSerialInput__ = 0;
const uint SERVERADDRESS__AnalogSerialInput__ = 1;
const uint CONSOLECMD__AnalogSerialInput__ = 2;

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
