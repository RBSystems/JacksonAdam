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

namespace UserModule_TASC_6_STRING_COMPARE_V2
{
    public class UserModuleClass_TASC_6_STRING_COMPARE_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.StringInput TO_MATCH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE6__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_1;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_2;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_3;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_4;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_5;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_6;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_1_INUSE;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_2_INUSE;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_3_INUSE;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_4_INUSE;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_5_INUSE;
        Crestron.Logos.SplusObjects.DigitalOutput LINE_6_INUSE;
        object TO_MATCH__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 114;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE1__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 116;
                    LINE_1  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 117;
                    LINE_2  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 118;
                    LINE_3  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 119;
                    LINE_4  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 120;
                    LINE_5  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 121;
                    LINE_6  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 123;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE2__DOLLAR__))  ) ) 
                        { 
                        __context__.SourceCodeLine = 125;
                        LINE_1  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 126;
                        LINE_2  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 127;
                        LINE_3  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 128;
                        LINE_4  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 129;
                        LINE_5  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 130;
                        LINE_6  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 132;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE3__DOLLAR__))  ) ) 
                            { 
                            __context__.SourceCodeLine = 134;
                            LINE_1  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 135;
                            LINE_2  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 136;
                            LINE_3  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 137;
                            LINE_4  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 138;
                            LINE_5  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 139;
                            LINE_6  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 141;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE4__DOLLAR__))  ) ) 
                                { 
                                __context__.SourceCodeLine = 143;
                                LINE_1  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 144;
                                LINE_2  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 145;
                                LINE_3  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 146;
                                LINE_4  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 147;
                                LINE_5  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 148;
                                LINE_6  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 150;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE5__DOLLAR__))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 152;
                                    LINE_1  .Value = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 153;
                                    LINE_2  .Value = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 154;
                                    LINE_3  .Value = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 155;
                                    LINE_4  .Value = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 156;
                                    LINE_5  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 157;
                                    LINE_6  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 159;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == LINE6__DOLLAR__))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 161;
                                        LINE_1  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 162;
                                        LINE_2  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 163;
                                        LINE_3  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 164;
                                        LINE_4  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 165;
                                        LINE_5  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 166;
                                        LINE_6  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 168;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_MATCH__DOLLAR__ == "Off"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 170;
                                            LINE_1  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 171;
                                            LINE_2  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 172;
                                            LINE_3  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 173;
                                            LINE_4  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 174;
                                            LINE_5  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 175;
                                            LINE_6  .Value = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 179;
                                            LINE_1  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 180;
                                            LINE_2  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 181;
                                            LINE_3  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 182;
                                            LINE_4  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 183;
                                            LINE_5  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 184;
                                            LINE_6  .Value = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LINE1__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort LINE1TEMP = 0;
            
            
            __context__.SourceCodeLine = 192;
            LINE1TEMP = (ushort) ( Functions.Find( "In-Use" , LINE1__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 194;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE1TEMP >= 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 196;
                LINE_1_INUSE  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 200;
                LINE_1_INUSE  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object LINE2__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LINE2TEMP = 0;
        
        
        __context__.SourceCodeLine = 208;
        LINE2TEMP = (ushort) ( Functions.Find( "In-Use" , LINE2__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 210;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE2TEMP >= 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 212;
            LINE_2_INUSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 216;
            LINE_2_INUSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINE3__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LINE3TEMP = 0;
        
        
        __context__.SourceCodeLine = 224;
        LINE3TEMP = (ushort) ( Functions.Find( "In-Use" , LINE3__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 226;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE3TEMP >= 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 228;
            LINE_3_INUSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 232;
            LINE_3_INUSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINE4__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LINE4TEMP = 0;
        
        
        __context__.SourceCodeLine = 240;
        LINE4TEMP = (ushort) ( Functions.Find( "In-Use" , LINE4__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 242;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE4TEMP >= 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 244;
            LINE_4_INUSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 248;
            LINE_4_INUSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINE5__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LINE5TEMP = 0;
        
        
        __context__.SourceCodeLine = 256;
        LINE5TEMP = (ushort) ( Functions.Find( "In-Use" , LINE5__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 258;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE5TEMP >= 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 260;
            LINE_5_INUSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 264;
            LINE_5_INUSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINE6__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LINE6TEMP = 0;
        
        
        __context__.SourceCodeLine = 272;
        LINE6TEMP = (ushort) ( Functions.Find( "In-Use" , LINE6__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 274;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LINE6TEMP == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 276;
            LINE_6_INUSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 280;
            LINE_6_INUSE  .Value = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 324;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 325;
        LINE_1  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 326;
        LINE_2  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 327;
        LINE_3  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 328;
        LINE_4  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 329;
        LINE_5  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 330;
        LINE_6  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    LINE_1 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_1__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_1__DigitalOutput__, LINE_1 );
    
    LINE_2 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_2__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_2__DigitalOutput__, LINE_2 );
    
    LINE_3 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_3__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_3__DigitalOutput__, LINE_3 );
    
    LINE_4 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_4__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_4__DigitalOutput__, LINE_4 );
    
    LINE_5 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_5__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_5__DigitalOutput__, LINE_5 );
    
    LINE_6 = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_6__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_6__DigitalOutput__, LINE_6 );
    
    LINE_1_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_1_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_1_INUSE__DigitalOutput__, LINE_1_INUSE );
    
    LINE_2_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_2_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_2_INUSE__DigitalOutput__, LINE_2_INUSE );
    
    LINE_3_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_3_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_3_INUSE__DigitalOutput__, LINE_3_INUSE );
    
    LINE_4_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_4_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_4_INUSE__DigitalOutput__, LINE_4_INUSE );
    
    LINE_5_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_5_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_5_INUSE__DigitalOutput__, LINE_5_INUSE );
    
    LINE_6_INUSE = new Crestron.Logos.SplusObjects.DigitalOutput( LINE_6_INUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINE_6_INUSE__DigitalOutput__, LINE_6_INUSE );
    
    TO_MATCH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TO_MATCH__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( TO_MATCH__DOLLAR____AnalogSerialInput__, TO_MATCH__DOLLAR__ );
    
    LINE1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE1__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE1__DOLLAR____AnalogSerialInput__, LINE1__DOLLAR__ );
    
    LINE2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE2__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE2__DOLLAR____AnalogSerialInput__, LINE2__DOLLAR__ );
    
    LINE3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE3__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE3__DOLLAR____AnalogSerialInput__, LINE3__DOLLAR__ );
    
    LINE4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE4__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE4__DOLLAR____AnalogSerialInput__, LINE4__DOLLAR__ );
    
    LINE5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE5__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE5__DOLLAR____AnalogSerialInput__, LINE5__DOLLAR__ );
    
    LINE6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE6__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LINE6__DOLLAR____AnalogSerialInput__, LINE6__DOLLAR__ );
    
    
    TO_MATCH__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE3__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE4__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE5__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE6__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_MATCH__DOLLAR___OnChange_0, false ) );
    LINE1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE1__DOLLAR___OnChange_1, false ) );
    LINE2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE2__DOLLAR___OnChange_2, false ) );
    LINE3__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE3__DOLLAR___OnChange_3, false ) );
    LINE4__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE4__DOLLAR___OnChange_4, false ) );
    LINE5__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE5__DOLLAR___OnChange_5, false ) );
    LINE6__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE6__DOLLAR___OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TASC_6_STRING_COMPARE_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TO_MATCH__DOLLAR____AnalogSerialInput__ = 0;
const uint LINE1__DOLLAR____AnalogSerialInput__ = 1;
const uint LINE2__DOLLAR____AnalogSerialInput__ = 2;
const uint LINE3__DOLLAR____AnalogSerialInput__ = 3;
const uint LINE4__DOLLAR____AnalogSerialInput__ = 4;
const uint LINE5__DOLLAR____AnalogSerialInput__ = 5;
const uint LINE6__DOLLAR____AnalogSerialInput__ = 6;
const uint LINE_1__DigitalOutput__ = 0;
const uint LINE_2__DigitalOutput__ = 1;
const uint LINE_3__DigitalOutput__ = 2;
const uint LINE_4__DigitalOutput__ = 3;
const uint LINE_5__DigitalOutput__ = 4;
const uint LINE_6__DigitalOutput__ = 5;
const uint LINE_1_INUSE__DigitalOutput__ = 6;
const uint LINE_2_INUSE__DigitalOutput__ = 7;
const uint LINE_3_INUSE__DigitalOutput__ = 8;
const uint LINE_4_INUSE__DigitalOutput__ = 9;
const uint LINE_5_INUSE__DigitalOutput__ = 10;
const uint LINE_6_INUSE__DigitalOutput__ = 11;

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
