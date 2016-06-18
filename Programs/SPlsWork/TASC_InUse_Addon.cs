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

namespace UserModule_TASC_INUSE_ADDON
{
    public class UserModuleClass_TASC_INUSE_ADDON : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.StringInput SOURCE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_9__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_10__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_11__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_12__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_13__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_14__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_15__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_16__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_17__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_18__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_19__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_20__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_21__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_22__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_23__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SOURCE_24__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_1_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_2_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_3_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_4_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_5_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_6_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_7_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_8_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_9_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_10_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_11_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_12_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_13_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_14_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_15_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_16_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_17_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_18_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_19_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_20_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_21_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_22_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_23_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_24_TX__DOLLAR__;
        object SOURCE_1__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 117;
                MakeString ( SOURCE_1_TX__DOLLAR__ , "{0} In-Use", SOURCE_1__DOLLAR__ ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SOURCE_2__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 123;
            MakeString ( SOURCE_2_TX__DOLLAR__ , "{0} In-Use", SOURCE_2__DOLLAR__ ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SOURCE_3__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        MakeString ( SOURCE_3_TX__DOLLAR__ , "{0} In-Use", SOURCE_3__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_4__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        MakeString ( SOURCE_4_TX__DOLLAR__ , "{0} In-Use", SOURCE_4__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_5__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        MakeString ( SOURCE_5_TX__DOLLAR__ , "{0} In-Use", SOURCE_5__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_6__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        MakeString ( SOURCE_6_TX__DOLLAR__ , "{0} In-Use", SOURCE_6__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_7__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        MakeString ( SOURCE_7_TX__DOLLAR__ , "{0} In-Use", SOURCE_7__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_8__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 159;
        MakeString ( SOURCE_8_TX__DOLLAR__ , "{0} In-Use", SOURCE_8__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_9__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        MakeString ( SOURCE_9_TX__DOLLAR__ , "{0} In-Use", SOURCE_9__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_10__DOLLAR___OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 171;
        MakeString ( SOURCE_10_TX__DOLLAR__ , "{0} In-Use", SOURCE_10__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_11__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        MakeString ( SOURCE_11_TX__DOLLAR__ , "{0} In-Use", SOURCE_11__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_12__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        MakeString ( SOURCE_12_TX__DOLLAR__ , "{0} In-Use", SOURCE_12__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_13__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 189;
        MakeString ( SOURCE_13_TX__DOLLAR__ , "{0} In-Use", SOURCE_13__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_14__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 195;
        MakeString ( SOURCE_14_TX__DOLLAR__ , "{0} In-Use", SOURCE_14__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_15__DOLLAR___OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 201;
        MakeString ( SOURCE_15_TX__DOLLAR__ , "{0} In-Use", SOURCE_15__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_16__DOLLAR___OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 207;
        MakeString ( SOURCE_16_TX__DOLLAR__ , "{0} In-Use", SOURCE_16__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_17__DOLLAR___OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 213;
        MakeString ( SOURCE_17_TX__DOLLAR__ , "{0} In-Use", SOURCE_17__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_18__DOLLAR___OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 219;
        MakeString ( SOURCE_18_TX__DOLLAR__ , "{0} In-Use", SOURCE_18__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_19__DOLLAR___OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 225;
        MakeString ( SOURCE_19_TX__DOLLAR__ , "{0} In-Use", SOURCE_19__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_20__DOLLAR___OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 231;
        MakeString ( SOURCE_20_TX__DOLLAR__ , "{0} In-Use", SOURCE_20__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_21__DOLLAR___OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 237;
        MakeString ( SOURCE_21_TX__DOLLAR__ , "{0} In-Use", SOURCE_21__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_22__DOLLAR___OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 243;
        MakeString ( SOURCE_22_TX__DOLLAR__ , "{0} In-Use", SOURCE_22__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_23__DOLLAR___OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 249;
        MakeString ( SOURCE_23_TX__DOLLAR__ , "{0} In-Use", SOURCE_23__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_24__DOLLAR___OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 255;
        MakeString ( SOURCE_24_TX__DOLLAR__ , "{0} In-Use", SOURCE_24__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SOURCE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_1__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_1__DOLLAR____AnalogSerialInput__, SOURCE_1__DOLLAR__ );
    
    SOURCE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_2__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_2__DOLLAR____AnalogSerialInput__, SOURCE_2__DOLLAR__ );
    
    SOURCE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_3__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_3__DOLLAR____AnalogSerialInput__, SOURCE_3__DOLLAR__ );
    
    SOURCE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_4__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_4__DOLLAR____AnalogSerialInput__, SOURCE_4__DOLLAR__ );
    
    SOURCE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_5__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_5__DOLLAR____AnalogSerialInput__, SOURCE_5__DOLLAR__ );
    
    SOURCE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_6__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_6__DOLLAR____AnalogSerialInput__, SOURCE_6__DOLLAR__ );
    
    SOURCE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_7__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_7__DOLLAR____AnalogSerialInput__, SOURCE_7__DOLLAR__ );
    
    SOURCE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_8__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_8__DOLLAR____AnalogSerialInput__, SOURCE_8__DOLLAR__ );
    
    SOURCE_9__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_9__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_9__DOLLAR____AnalogSerialInput__, SOURCE_9__DOLLAR__ );
    
    SOURCE_10__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_10__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_10__DOLLAR____AnalogSerialInput__, SOURCE_10__DOLLAR__ );
    
    SOURCE_11__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_11__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_11__DOLLAR____AnalogSerialInput__, SOURCE_11__DOLLAR__ );
    
    SOURCE_12__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_12__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_12__DOLLAR____AnalogSerialInput__, SOURCE_12__DOLLAR__ );
    
    SOURCE_13__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_13__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_13__DOLLAR____AnalogSerialInput__, SOURCE_13__DOLLAR__ );
    
    SOURCE_14__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_14__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_14__DOLLAR____AnalogSerialInput__, SOURCE_14__DOLLAR__ );
    
    SOURCE_15__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_15__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_15__DOLLAR____AnalogSerialInput__, SOURCE_15__DOLLAR__ );
    
    SOURCE_16__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_16__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_16__DOLLAR____AnalogSerialInput__, SOURCE_16__DOLLAR__ );
    
    SOURCE_17__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_17__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_17__DOLLAR____AnalogSerialInput__, SOURCE_17__DOLLAR__ );
    
    SOURCE_18__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_18__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_18__DOLLAR____AnalogSerialInput__, SOURCE_18__DOLLAR__ );
    
    SOURCE_19__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_19__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_19__DOLLAR____AnalogSerialInput__, SOURCE_19__DOLLAR__ );
    
    SOURCE_20__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_20__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_20__DOLLAR____AnalogSerialInput__, SOURCE_20__DOLLAR__ );
    
    SOURCE_21__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_21__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_21__DOLLAR____AnalogSerialInput__, SOURCE_21__DOLLAR__ );
    
    SOURCE_22__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_22__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_22__DOLLAR____AnalogSerialInput__, SOURCE_22__DOLLAR__ );
    
    SOURCE_23__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_23__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_23__DOLLAR____AnalogSerialInput__, SOURCE_23__DOLLAR__ );
    
    SOURCE_24__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SOURCE_24__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SOURCE_24__DOLLAR____AnalogSerialInput__, SOURCE_24__DOLLAR__ );
    
    SOURCE_1_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_1_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_1_TX__DOLLAR____AnalogSerialOutput__, SOURCE_1_TX__DOLLAR__ );
    
    SOURCE_2_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_2_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_2_TX__DOLLAR____AnalogSerialOutput__, SOURCE_2_TX__DOLLAR__ );
    
    SOURCE_3_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_3_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_3_TX__DOLLAR____AnalogSerialOutput__, SOURCE_3_TX__DOLLAR__ );
    
    SOURCE_4_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_4_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_4_TX__DOLLAR____AnalogSerialOutput__, SOURCE_4_TX__DOLLAR__ );
    
    SOURCE_5_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_5_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_5_TX__DOLLAR____AnalogSerialOutput__, SOURCE_5_TX__DOLLAR__ );
    
    SOURCE_6_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_6_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_6_TX__DOLLAR____AnalogSerialOutput__, SOURCE_6_TX__DOLLAR__ );
    
    SOURCE_7_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_7_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_7_TX__DOLLAR____AnalogSerialOutput__, SOURCE_7_TX__DOLLAR__ );
    
    SOURCE_8_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_8_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_8_TX__DOLLAR____AnalogSerialOutput__, SOURCE_8_TX__DOLLAR__ );
    
    SOURCE_9_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_9_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_9_TX__DOLLAR____AnalogSerialOutput__, SOURCE_9_TX__DOLLAR__ );
    
    SOURCE_10_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_10_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_10_TX__DOLLAR____AnalogSerialOutput__, SOURCE_10_TX__DOLLAR__ );
    
    SOURCE_11_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_11_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_11_TX__DOLLAR____AnalogSerialOutput__, SOURCE_11_TX__DOLLAR__ );
    
    SOURCE_12_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_12_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_12_TX__DOLLAR____AnalogSerialOutput__, SOURCE_12_TX__DOLLAR__ );
    
    SOURCE_13_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_13_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_13_TX__DOLLAR____AnalogSerialOutput__, SOURCE_13_TX__DOLLAR__ );
    
    SOURCE_14_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_14_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_14_TX__DOLLAR____AnalogSerialOutput__, SOURCE_14_TX__DOLLAR__ );
    
    SOURCE_15_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_15_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_15_TX__DOLLAR____AnalogSerialOutput__, SOURCE_15_TX__DOLLAR__ );
    
    SOURCE_16_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_16_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_16_TX__DOLLAR____AnalogSerialOutput__, SOURCE_16_TX__DOLLAR__ );
    
    SOURCE_17_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_17_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_17_TX__DOLLAR____AnalogSerialOutput__, SOURCE_17_TX__DOLLAR__ );
    
    SOURCE_18_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_18_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_18_TX__DOLLAR____AnalogSerialOutput__, SOURCE_18_TX__DOLLAR__ );
    
    SOURCE_19_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_19_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_19_TX__DOLLAR____AnalogSerialOutput__, SOURCE_19_TX__DOLLAR__ );
    
    SOURCE_20_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_20_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_20_TX__DOLLAR____AnalogSerialOutput__, SOURCE_20_TX__DOLLAR__ );
    
    SOURCE_21_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_21_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_21_TX__DOLLAR____AnalogSerialOutput__, SOURCE_21_TX__DOLLAR__ );
    
    SOURCE_22_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_22_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_22_TX__DOLLAR____AnalogSerialOutput__, SOURCE_22_TX__DOLLAR__ );
    
    SOURCE_23_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_23_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_23_TX__DOLLAR____AnalogSerialOutput__, SOURCE_23_TX__DOLLAR__ );
    
    SOURCE_24_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_24_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_24_TX__DOLLAR____AnalogSerialOutput__, SOURCE_24_TX__DOLLAR__ );
    
    
    SOURCE_1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_1__DOLLAR___OnChange_0, false ) );
    SOURCE_2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_2__DOLLAR___OnChange_1, false ) );
    SOURCE_3__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_3__DOLLAR___OnChange_2, false ) );
    SOURCE_4__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_4__DOLLAR___OnChange_3, false ) );
    SOURCE_5__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_5__DOLLAR___OnChange_4, false ) );
    SOURCE_6__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_6__DOLLAR___OnChange_5, false ) );
    SOURCE_7__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_7__DOLLAR___OnChange_6, false ) );
    SOURCE_8__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_8__DOLLAR___OnChange_7, false ) );
    SOURCE_9__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_9__DOLLAR___OnChange_8, false ) );
    SOURCE_10__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_10__DOLLAR___OnChange_9, false ) );
    SOURCE_11__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_11__DOLLAR___OnChange_10, false ) );
    SOURCE_12__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_12__DOLLAR___OnChange_11, false ) );
    SOURCE_13__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_13__DOLLAR___OnChange_12, false ) );
    SOURCE_14__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_14__DOLLAR___OnChange_13, false ) );
    SOURCE_15__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_15__DOLLAR___OnChange_14, false ) );
    SOURCE_16__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_16__DOLLAR___OnChange_15, false ) );
    SOURCE_17__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_17__DOLLAR___OnChange_16, false ) );
    SOURCE_18__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_18__DOLLAR___OnChange_17, false ) );
    SOURCE_19__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_19__DOLLAR___OnChange_18, false ) );
    SOURCE_20__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_20__DOLLAR___OnChange_19, false ) );
    SOURCE_21__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_21__DOLLAR___OnChange_20, false ) );
    SOURCE_22__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_22__DOLLAR___OnChange_21, false ) );
    SOURCE_23__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_23__DOLLAR___OnChange_22, false ) );
    SOURCE_24__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SOURCE_24__DOLLAR___OnChange_23, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TASC_INUSE_ADDON ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SOURCE_1__DOLLAR____AnalogSerialInput__ = 0;
const uint SOURCE_2__DOLLAR____AnalogSerialInput__ = 1;
const uint SOURCE_3__DOLLAR____AnalogSerialInput__ = 2;
const uint SOURCE_4__DOLLAR____AnalogSerialInput__ = 3;
const uint SOURCE_5__DOLLAR____AnalogSerialInput__ = 4;
const uint SOURCE_6__DOLLAR____AnalogSerialInput__ = 5;
const uint SOURCE_7__DOLLAR____AnalogSerialInput__ = 6;
const uint SOURCE_8__DOLLAR____AnalogSerialInput__ = 7;
const uint SOURCE_9__DOLLAR____AnalogSerialInput__ = 8;
const uint SOURCE_10__DOLLAR____AnalogSerialInput__ = 9;
const uint SOURCE_11__DOLLAR____AnalogSerialInput__ = 10;
const uint SOURCE_12__DOLLAR____AnalogSerialInput__ = 11;
const uint SOURCE_13__DOLLAR____AnalogSerialInput__ = 12;
const uint SOURCE_14__DOLLAR____AnalogSerialInput__ = 13;
const uint SOURCE_15__DOLLAR____AnalogSerialInput__ = 14;
const uint SOURCE_16__DOLLAR____AnalogSerialInput__ = 15;
const uint SOURCE_17__DOLLAR____AnalogSerialInput__ = 16;
const uint SOURCE_18__DOLLAR____AnalogSerialInput__ = 17;
const uint SOURCE_19__DOLLAR____AnalogSerialInput__ = 18;
const uint SOURCE_20__DOLLAR____AnalogSerialInput__ = 19;
const uint SOURCE_21__DOLLAR____AnalogSerialInput__ = 20;
const uint SOURCE_22__DOLLAR____AnalogSerialInput__ = 21;
const uint SOURCE_23__DOLLAR____AnalogSerialInput__ = 22;
const uint SOURCE_24__DOLLAR____AnalogSerialInput__ = 23;
const uint SOURCE_1_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint SOURCE_2_TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint SOURCE_3_TX__DOLLAR____AnalogSerialOutput__ = 2;
const uint SOURCE_4_TX__DOLLAR____AnalogSerialOutput__ = 3;
const uint SOURCE_5_TX__DOLLAR____AnalogSerialOutput__ = 4;
const uint SOURCE_6_TX__DOLLAR____AnalogSerialOutput__ = 5;
const uint SOURCE_7_TX__DOLLAR____AnalogSerialOutput__ = 6;
const uint SOURCE_8_TX__DOLLAR____AnalogSerialOutput__ = 7;
const uint SOURCE_9_TX__DOLLAR____AnalogSerialOutput__ = 8;
const uint SOURCE_10_TX__DOLLAR____AnalogSerialOutput__ = 9;
const uint SOURCE_11_TX__DOLLAR____AnalogSerialOutput__ = 10;
const uint SOURCE_12_TX__DOLLAR____AnalogSerialOutput__ = 11;
const uint SOURCE_13_TX__DOLLAR____AnalogSerialOutput__ = 12;
const uint SOURCE_14_TX__DOLLAR____AnalogSerialOutput__ = 13;
const uint SOURCE_15_TX__DOLLAR____AnalogSerialOutput__ = 14;
const uint SOURCE_16_TX__DOLLAR____AnalogSerialOutput__ = 15;
const uint SOURCE_17_TX__DOLLAR____AnalogSerialOutput__ = 16;
const uint SOURCE_18_TX__DOLLAR____AnalogSerialOutput__ = 17;
const uint SOURCE_19_TX__DOLLAR____AnalogSerialOutput__ = 18;
const uint SOURCE_20_TX__DOLLAR____AnalogSerialOutput__ = 19;
const uint SOURCE_21_TX__DOLLAR____AnalogSerialOutput__ = 20;
const uint SOURCE_22_TX__DOLLAR____AnalogSerialOutput__ = 21;
const uint SOURCE_23_TX__DOLLAR____AnalogSerialOutput__ = 22;
const uint SOURCE_24_TX__DOLLAR____AnalogSerialOutput__ = 23;

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
