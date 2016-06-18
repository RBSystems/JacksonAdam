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

namespace UserModule_TASC_CORE3_LIGHTING_ROOM
{
    public class UserModuleClass_TASC_CORE3_LIGHTING_ROOM : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ROOM_ON;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ROOM;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> OUTPUT;
        UShortParameter FONTSIZE;
        StringParameter ON_COLOR;
        StringParameter OFF_COLOR;
        object ROOM_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString TEMP;
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 77;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 78;
                MakeString ( TEMP , "<P align=\u0022center\u0022><FONT size=\u0022{0:d}\u0022 face=\u0022Arial\u0022 color=\u0022{1}\u0022>{2}</FONT></P>", (short)FONTSIZE  .Value, ON_COLOR , ROOM [ I ] ) ; 
                __context__.SourceCodeLine = 79;
                OUTPUT [ I]  .UpdateValue ( TEMP  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ROOM_ON_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString TEMP;
            TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 86;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 87;
            MakeString ( TEMP , "<P align=\u0022center\u0022><FONT size=\u0022{0:d}\u0022 face=\u0022Arial\u0022 color=\u0022{1}\u0022>{2}</FONT></P>", (short)FONTSIZE  .Value, OFF_COLOR , ROOM [ I ] ) ; 
            __context__.SourceCodeLine = 88;
            OUTPUT [ I]  .UpdateValue ( TEMP  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ROOM_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 95;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 97;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOM_ON[ I ] .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 99;
            MakeString ( TEMP , "<P align=\u0022center\u0022><FONT size=\u0022{0:d}\u0022 face=\u0022Arial\u0022 color=\u0022{1}\u0022>{2}</FONT></P>", (short)FONTSIZE  .Value, ON_COLOR , ROOM [ I ] ) ; 
            __context__.SourceCodeLine = 100;
            OUTPUT [ I]  .UpdateValue ( TEMP  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 104;
            MakeString ( TEMP , "<P align=\u0022center\u0022><FONT size=\u0022{0:d}\u0022 face=\u0022Arial\u0022 color=\u0022{1}\u0022>{2}</FONT></P>", (short)FONTSIZE  .Value, OFF_COLOR , ROOM [ I ] ) ; 
            __context__.SourceCodeLine = 105;
            OUTPUT [ I]  .UpdateValue ( TEMP  ) ; 
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
        
        __context__.SourceCodeLine = 141;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ROOM_ON = new InOutArray<DigitalInput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        ROOM_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_ON__DigitalInput__ + i, ROOM_ON__DigitalInput__, this );
        m_DigitalInputList.Add( ROOM_ON__DigitalInput__ + i, ROOM_ON[i+1] );
    }
    
    ROOM = new InOutArray<StringInput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        ROOM[i+1] = new Crestron.Logos.SplusObjects.StringInput( ROOM__AnalogSerialInput__ + i, ROOM__AnalogSerialInput__, 100, this );
        m_StringInputList.Add( ROOM__AnalogSerialInput__ + i, ROOM[i+1] );
    }
    
    OUTPUT = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        OUTPUT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( OUTPUT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( OUTPUT__AnalogSerialOutput__ + i, OUTPUT[i+1] );
    }
    
    FONTSIZE = new UShortParameter( FONTSIZE__Parameter__, this );
    m_ParameterList.Add( FONTSIZE__Parameter__, FONTSIZE );
    
    ON_COLOR = new StringParameter( ON_COLOR__Parameter__, this );
    m_ParameterList.Add( ON_COLOR__Parameter__, ON_COLOR );
    
    OFF_COLOR = new StringParameter( OFF_COLOR__Parameter__, this );
    m_ParameterList.Add( OFF_COLOR__Parameter__, OFF_COLOR );
    
    
    for( uint i = 0; i < 25; i++ )
        ROOM_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_ON_OnPush_0, false ) );
        
    for( uint i = 0; i < 25; i++ )
        ROOM_ON[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOM_ON_OnRelease_1, false ) );
        
    for( uint i = 0; i < 25; i++ )
        ROOM[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ROOM_OnChange_2, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TASC_CORE3_LIGHTING_ROOM ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOM_ON__DigitalInput__ = 0;
const uint ROOM__AnalogSerialInput__ = 0;
const uint OUTPUT__AnalogSerialOutput__ = 0;
const uint FONTSIZE__Parameter__ = 10;
const uint ON_COLOR__Parameter__ = 11;
const uint OFF_COLOR__Parameter__ = 12;

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
