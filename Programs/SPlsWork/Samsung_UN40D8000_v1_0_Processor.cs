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

namespace CrestronModule_SAMSUNG_UN40D8000_V1_0_PROCESSOR
{
    public class CrestronModuleClass_SAMSUNG_UN40D8000_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_SET_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput THREED_VIEW_POINT_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput THREED_DEPTH_VALUE;
        Crestron.Logos.SplusObjects.DigitalInput ATV;
        Crestron.Logos.SplusObjects.DigitalInput DTV;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KP;
        Crestron.Logos.SplusObjects.StringInput STRING_TO_SEND;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        private CrestronString SENDSTRING (  SplusExecutionContext __context__, CrestronString STRINGSEND ) 
            { 
            ushort A = 0;
            ushort ICS = 0;
            
            CrestronString SSTRINGFINAL;
            SSTRINGFINAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 136;
            ICS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 137;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STRINGSEND ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 139;
                ICS = (ushort) ( (ICS + Byte( STRINGSEND , (int)( A ) )) ) ; 
                __context__.SourceCodeLine = 137;
                } 
            
            __context__.SourceCodeLine = 141;
            ICS = (ushort) ( (256 - ICS) ) ; 
            __context__.SourceCodeLine = 142;
            SSTRINGFINAL  .UpdateValue ( STRINGSEND + Functions.Chr (  (int) ( ICS ) )  ) ; 
            __context__.SourceCodeLine = 143;
            return ( SSTRINGFINAL ) ; 
            
            }
            
        object STRING_TO_SEND_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 153;
                _SplusNVRAM.ICS = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 154;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ISEMAPHORE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 156;
                    _SplusNVRAM.ISEMAPHORE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 157;
                    _SplusNVRAM.STEMP  .UpdateValue ( STRING_TO_SEND  ) ; 
                    __context__.SourceCodeLine = 158;
                    TO_DEVICE  .UpdateValue ( SENDSTRING (  __context__ , _SplusNVRAM.STEMP)  ) ; 
                    __context__.SourceCodeLine = 159;
                    _SplusNVRAM.ISEMAPHORE = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_SET_VALUE_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 164;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IENABLECHANGE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 166;
                MakeString ( _SplusNVRAM.SVOLUMETEMP , "\u0008\u0022\u0001\u0000\u0000{0}", Functions.Chr (  (int) ( VOLUME_SET_VALUE  .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 167;
                TO_DEVICE  .UpdateValue ( SENDSTRING (  __context__ , _SplusNVRAM.SVOLUMETEMP)  ) ; 
                __context__.SourceCodeLine = 168;
                MakeString ( VOLUME_TEXT , "{0}", Functions.ItoA (  (int) ( VOLUME_SET_VALUE  .UshortValue ) ) ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object THREED_VIEW_POINT_VALUE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IENABLECHANGE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 176;
            MakeString ( _SplusNVRAM.STHREEDVIEWPOINTTEMP , "\u0008\u0022\u000B\u000C\u0002{0}", Functions.Chr (  (int) ( THREED_VIEW_POINT_VALUE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 177;
            TO_DEVICE  .UpdateValue ( SENDSTRING (  __context__ , _SplusNVRAM.STHREEDVIEWPOINTTEMP)  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THREED_DEPTH_VALUE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IENABLECHANGE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 185;
            MakeString ( _SplusNVRAM.STHREEDDEPTHTEMP , "\u0008\u0022\u000B\u000C\u0003{0}", Functions.Chr (  (int) ( THREED_DEPTH_VALUE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 186;
            TO_DEVICE  .UpdateValue ( SENDSTRING (  __context__ , _SplusNVRAM.STHREEDDEPTHTEMP)  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ));
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    {
                    __context__.SourceCodeLine = 195;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}0", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    {
                    __context__.SourceCodeLine = 197;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}1", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                    {
                    __context__.SourceCodeLine = 199;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}2", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                    {
                    __context__.SourceCodeLine = 201;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}3", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                    {
                    __context__.SourceCodeLine = 203;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}4", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                    {
                    __context__.SourceCodeLine = 205;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}5", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                    {
                    __context__.SourceCodeLine = 207;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}6", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                    {
                    __context__.SourceCodeLine = 209;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}7", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                    {
                    __context__.SourceCodeLine = 211;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}8", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                    {
                    __context__.SourceCodeLine = 213;
                    MakeString ( _SplusNVRAM.SNUMBER , "{0}9", _SplusNVRAM.SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 216;
                    _SplusNVRAM.ILOC = (ushort) ( Functions.Find( "-" , _SplusNVRAM.SNUMBER ) ) ; 
                    __context__.SourceCodeLine = 217;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.ILOC == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.SNUMBER ) > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 219;
                        MakeString ( _SplusNVRAM.SNUMBER , "{0}-", _SplusNVRAM.SNUMBER ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 224;
                    Functions.ClearBuffer ( _SplusNVRAM.SNUMBER ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 13) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 228;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.SNUMBER ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 230;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "-" , _SplusNVRAM.SNUMBER ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 232;
                            _SplusNVRAM.IMAINCHANNEL = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.SNUMBER , (int)( (Functions.Find( "-" , _SplusNVRAM.SNUMBER ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 233;
                            _SplusNVRAM.ISUBCHANNEL = (ushort) ( Functions.Atoi( Functions.Right( _SplusNVRAM.SNUMBER , (int)( (Functions.Length( _SplusNVRAM.SNUMBER ) - Functions.Find( "-" , _SplusNVRAM.SNUMBER )) ) ) ) ) ; 
                            __context__.SourceCodeLine = 234;
                            if ( Functions.TestForTrue  ( ( ATV  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 235;
                                MakeString ( _SplusNVRAM.SCHANNELCOMMAND , "\u0008\u0022\u0004\u0000\u0000{0}", Functions.Chr (  (int) ( _SplusNVRAM.IMAINCHANNEL ) ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 236;
                            if ( Functions.TestForTrue  ( ( DTV  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 237;
                                MakeString ( _SplusNVRAM.SCHANNELCOMMAND , "\u0008\u0022\u0004\u0080{0}{1}", Functions.Chr (  (int) ( (_SplusNVRAM.IMAINCHANNEL * 4) ) ) , Functions.Chr (  (int) ( _SplusNVRAM.ISUBCHANNEL ) ) ) ; 
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 241;
                            _SplusNVRAM.IMAINCHANNEL = (ushort) ( Functions.Atoi( _SplusNVRAM.SNUMBER ) ) ; 
                            __context__.SourceCodeLine = 243;
                            if ( Functions.TestForTrue  ( ( ATV  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 244;
                                MakeString ( _SplusNVRAM.SCHANNELCOMMAND , "\u0008\u0022\u0004\u0000\u0000{0}", Functions.Chr (  (int) ( _SplusNVRAM.IMAINCHANNEL ) ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 245;
                            if ( Functions.TestForTrue  ( ( DTV  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 246;
                                MakeString ( _SplusNVRAM.SCHANNELCOMMAND , "\u0008\u0022\u0004\u0080{0}\u0000", Functions.Chr (  (int) ( (_SplusNVRAM.IMAINCHANNEL * 4) ) ) ) ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 248;
                        TO_DEVICE  .UpdateValue ( SENDSTRING (  __context__ , _SplusNVRAM.SCHANNELCOMMAND)  ) ; 
                        __context__.SourceCodeLine = 249;
                        Functions.ClearBuffer ( _SplusNVRAM.SNUMBER ) ; 
                        } 
                    
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 253;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.SNUMBER ) > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 254;
            MakeString ( CHANNEL_TEXT , "{0}", _SplusNVRAM.SNUMBER ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 256;
            MakeString ( CHANNEL_TEXT , "\u0020") ; 
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
        
        __context__.SourceCodeLine = 269;
        _SplusNVRAM.IENABLECHANGE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 270;
        _SplusNVRAM.ISEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 271;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_4__" , 100 , __SPLS_TMPVAR__WAITLABEL_4___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    
public void __SPLS_TMPVAR__WAITLABEL_4___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 273;
            _SplusNVRAM.IENABLECHANGE = (ushort) ( 1 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _SplusNVRAM.SVOLUMETEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _SplusNVRAM.STHREEDVIEWPOINTTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _SplusNVRAM.STHREEDDEPTHTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _SplusNVRAM.SCHANNELTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _SplusNVRAM.SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    _SplusNVRAM.SCHANNELCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 13, this );
    
    ATV = new Crestron.Logos.SplusObjects.DigitalInput( ATV__DigitalInput__, this );
    m_DigitalInputList.Add( ATV__DigitalInput__, ATV );
    
    DTV = new Crestron.Logos.SplusObjects.DigitalInput( DTV__DigitalInput__, this );
    m_DigitalInputList.Add( DTV__DigitalInput__, DTV );
    
    KP = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        KP[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KP__DigitalInput__ + i, KP__DigitalInput__, this );
        m_DigitalInputList.Add( KP__DigitalInput__ + i, KP[i+1] );
    }
    
    VOLUME_SET_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_SET_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_SET_VALUE__AnalogSerialInput__, VOLUME_SET_VALUE );
    
    THREED_VIEW_POINT_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( THREED_VIEW_POINT_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( THREED_VIEW_POINT_VALUE__AnalogSerialInput__, THREED_VIEW_POINT_VALUE );
    
    THREED_DEPTH_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( THREED_DEPTH_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( THREED_DEPTH_VALUE__AnalogSerialInput__, THREED_DEPTH_VALUE );
    
    STRING_TO_SEND = new Crestron.Logos.SplusObjects.StringInput( STRING_TO_SEND__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( STRING_TO_SEND__AnalogSerialInput__, STRING_TO_SEND );
    
    CHANNEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHANNEL_TEXT__AnalogSerialOutput__, CHANNEL_TEXT );
    
    VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( VOLUME_TEXT__AnalogSerialOutput__, VOLUME_TEXT );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    __SPLS_TMPVAR__WAITLABEL_4___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_4___CallbackFn );
    
    STRING_TO_SEND.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING_TO_SEND_OnChange_0, false ) );
    VOLUME_SET_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_SET_VALUE_OnChange_1, false ) );
    THREED_VIEW_POINT_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( THREED_VIEW_POINT_VALUE_OnChange_2, false ) );
    THREED_DEPTH_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( THREED_DEPTH_VALUE_OnChange_3, false ) );
    for( uint i = 0; i < 13; i++ )
        KP[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_OnPush_4, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SAMSUNG_UN40D8000_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_4___Callback;


const uint VOLUME_SET_VALUE__AnalogSerialInput__ = 0;
const uint THREED_VIEW_POINT_VALUE__AnalogSerialInput__ = 1;
const uint THREED_DEPTH_VALUE__AnalogSerialInput__ = 2;
const uint ATV__DigitalInput__ = 0;
const uint DTV__DigitalInput__ = 1;
const uint KP__DigitalInput__ = 2;
const uint STRING_TO_SEND__AnalogSerialInput__ = 3;
const uint CHANNEL_TEXT__AnalogSerialOutput__ = 0;
const uint VOLUME_TEXT__AnalogSerialOutput__ = 1;
const uint TO_DEVICE__AnalogSerialOutput__ = 2;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort ISEMAPHORE = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort A = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort ICS = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort IENABLECHANGE = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort ILOC = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort IMAINCHANNEL = 0;
            [SplusStructAttribute(6, false, true)]
            public ushort ISUBCHANNEL = 0;
            [SplusStructAttribute(7, false, true)]
            public CrestronString STEMP;
            [SplusStructAttribute(8, false, true)]
            public CrestronString SVOLUMETEMP;
            [SplusStructAttribute(9, false, true)]
            public CrestronString STHREEDVIEWPOINTTEMP;
            [SplusStructAttribute(10, false, true)]
            public CrestronString STHREEDDEPTHTEMP;
            [SplusStructAttribute(11, false, true)]
            public CrestronString SCHANNELTEMP;
            [SplusStructAttribute(12, false, true)]
            public CrestronString SNUMBER;
            [SplusStructAttribute(13, false, true)]
            public CrestronString SCHANNELCOMMAND;
            
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
