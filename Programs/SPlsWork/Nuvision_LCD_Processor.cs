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

namespace CrestronModule_NUVISION_LCD_PROCESSOR
{
    public class CrestronModuleClass_NUVISION_LCD_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_UP;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_UP;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SATURATION_UP;
        Crestron.Logos.SplusObjects.DigitalInput SATURATION_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput TINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput TINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput RAMPING;
        Crestron.Logos.SplusObjects.DigitalInput RAMP_DONE;
        Crestron.Logos.SplusObjects.AnalogInput POLL_SENT;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput POWER_IN;
        Crestron.Logos.SplusObjects.AnalogOutput INPUT_IN;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_MUTE_IN;
        Crestron.Logos.SplusObjects.AnalogOutput CONTRAST_IN;
        Crestron.Logos.SplusObjects.AnalogOutput BRIGHTNESS_IN;
        Crestron.Logos.SplusObjects.AnalogOutput SATURATION_IN;
        Crestron.Logos.SplusObjects.AnalogOutput TINT_IN;
        Crestron.Logos.SplusObjects.AnalogOutput AUTO_COLOR_CONTROL_IN;
        Crestron.Logos.SplusObjects.AnalogOutput COLOR_TEMPERATURE_IN;
        Crestron.Logos.SplusObjects.AnalogOutput CHANNEL_IN;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IPOLLSENT = 0;
        ushort IVOLUME = 0;
        ushort ICON = 0;
        ushort IBRIGHT = 0;
        ushort ISAT = 0;
        ushort ITINT = 0;
        ushort IFLAG1 = 0;
        ushort ICOUNT = 0;
        ushort ITEMP = 0;
        CrestronString STEMP;
        object VOLUME_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME < 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 88;
                        IVOLUME = (ushort) ( (IVOLUME + 5) ) ; 
                        __context__.SourceCodeLine = 89;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME > 100 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 91;
                            IVOLUME = (ushort) ( 100 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 96;
                        IVOLUME = (ushort) ( (IVOLUME + 1) ) ; 
                        __context__.SourceCodeLine = 97;
                        ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 99;
                    VOLUME_IN  .Value = (ushort) ( IVOLUME ) ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( TO_DEVICE__DOLLAR__ , "\u0002VOL:{0:d3}\u0003", (short)IVOLUME) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_DOWN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 106;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME >= (0 + 5) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 112;
                        IVOLUME = (ushort) ( (IVOLUME - 5) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 116;
                        IVOLUME = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 121;
                    IVOLUME = (ushort) ( (IVOLUME - 1) ) ; 
                    __context__.SourceCodeLine = 122;
                    ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 124;
                VOLUME_IN  .Value = (ushort) ( IVOLUME ) ; 
                __context__.SourceCodeLine = 125;
                MakeString ( TO_DEVICE__DOLLAR__ , "\u0002VOL:{0:d3}\u0003", (short)IVOLUME) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONTRAST_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 131;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICON < 100 ))  ) ) 
            { 
            __context__.SourceCodeLine = 133;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 135;
                ICON = (ushort) ( (ICON + 3) ) ; 
                __context__.SourceCodeLine = 136;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICON > 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 138;
                    ICON = (ushort) ( 100 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 143;
                ICON = (ushort) ( (ICON + 1) ) ; 
                __context__.SourceCodeLine = 144;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 146;
            CONTRAST_IN  .Value = (ushort) ( ICON ) ; 
            __context__.SourceCodeLine = 147;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002CON:{0:d3}\u0003", (short)ICON) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTRAST_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICON > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 155;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 157;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICON >= (0 + 3) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 159;
                    ICON = (ushort) ( (ICON - 3) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 163;
                    ICON = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 168;
                ICON = (ushort) ( (ICON - 1) ) ; 
                __context__.SourceCodeLine = 169;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 171;
            CONTRAST_IN  .Value = (ushort) ( ICON ) ; 
            __context__.SourceCodeLine = 172;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002CON:{0:d3}\u0003", (short)ICON) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRIGHTNESS_UP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 178;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBRIGHT < 100 ))  ) ) 
            { 
            __context__.SourceCodeLine = 180;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 182;
                IBRIGHT = (ushort) ( (IBRIGHT + 3) ) ; 
                __context__.SourceCodeLine = 183;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBRIGHT > 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 185;
                    IBRIGHT = (ushort) ( 100 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 190;
                IBRIGHT = (ushort) ( (IBRIGHT + 1) ) ; 
                __context__.SourceCodeLine = 191;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 193;
            BRIGHTNESS_IN  .Value = (ushort) ( IBRIGHT ) ; 
            __context__.SourceCodeLine = 194;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002BRT:{0:d3}\u0003", (short)IBRIGHT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRIGHTNESS_DOWN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 200;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBRIGHT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 202;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 204;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBRIGHT >= (0 + 3) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 206;
                    IBRIGHT = (ushort) ( (IBRIGHT - 3) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 210;
                    IBRIGHT = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 215;
                IBRIGHT = (ushort) ( (IBRIGHT - 1) ) ; 
                __context__.SourceCodeLine = 216;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 218;
            BRIGHTNESS_IN  .Value = (ushort) ( IBRIGHT ) ; 
            __context__.SourceCodeLine = 219;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002BRT:{0:d3}\u0003", (short)IBRIGHT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SATURATION_UP_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 225;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISAT < 100 ))  ) ) 
            { 
            __context__.SourceCodeLine = 227;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 229;
                ISAT = (ushort) ( (ISAT + 3) ) ; 
                __context__.SourceCodeLine = 230;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISAT > 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 232;
                    ISAT = (ushort) ( 100 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 237;
                ISAT = (ushort) ( (ISAT + 1) ) ; 
                __context__.SourceCodeLine = 238;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 240;
            SATURATION_IN  .Value = (ushort) ( ISAT ) ; 
            __context__.SourceCodeLine = 241;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002SAT:{0:d3}\u0003", (short)ISAT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SATURATION_DOWN_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 247;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISAT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 249;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 251;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISAT >= (0 + 3) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 253;
                    ISAT = (ushort) ( (ISAT - 3) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 257;
                    ISAT = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 262;
                ISAT = (ushort) ( (ISAT - 1) ) ; 
                __context__.SourceCodeLine = 263;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 265;
            SATURATION_IN  .Value = (ushort) ( ISAT ) ; 
            __context__.SourceCodeLine = 266;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002SAT:{0:d3}\u0003", (short)ISAT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TINT_UP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 272;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITINT < 50 ))  ) ) 
            { 
            __context__.SourceCodeLine = 274;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 276;
                ITINT = (ushort) ( (ITINT + 3) ) ; 
                __context__.SourceCodeLine = 277;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITINT > 50 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 279;
                    ITINT = (ushort) ( 50 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 284;
                ITINT = (ushort) ( (ITINT + 1) ) ; 
                __context__.SourceCodeLine = 285;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 287;
            TINT_IN  .Value = (ushort) ( ITINT ) ; 
            __context__.SourceCodeLine = 288;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002TIN:{0:d3}\u0003", (short)ITINT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TINT_DOWN_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 294;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITINT > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 296;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOUNT >= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 298;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITINT >= (0 + 3) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 300;
                    ITINT = (ushort) ( (ITINT - 3) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 304;
                    ITINT = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 309;
                ITINT = (ushort) ( (ITINT - 1) ) ; 
                __context__.SourceCodeLine = 310;
                ICOUNT = (ushort) ( (ICOUNT + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 312;
            TINT_IN  .Value = (ushort) ( ITINT ) ; 
            __context__.SourceCodeLine = 313;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0002TIN:{0:d3}\u0003", (short)ITINT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RAMP_DONE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 319;
        ICOUNT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_SENT_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 324;
        IPOLLSENT = (ushort) ( POLL_SENT  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 329;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 331;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 332;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 334;
                STEMP  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 335;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "OK" , STEMP ) > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "ER" , STEMP ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 337;
                    STEMP  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 339;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RAMPING  .Value == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 341;
                        
                            {
                            int __SPLS_TMPVAR__SWTCH_1__ = ((int)IPOLLSENT);
                            
                                { 
                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 345;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 346;
                                    POWER_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 350;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 351;
                                    INPUT_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 355;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 356;
                                    VOLUME_MUTE_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 360;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 361;
                                    AUTO_COLOR_CONTROL_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 365;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 366;
                                    CHANNEL_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 370;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 371;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOLUME))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 373;
                                        IVOLUME = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 374;
                                        VOLUME_IN  .Value = (ushort) ( IVOLUME ) ; 
                                        } 
                                    
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 379;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 380;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IBRIGHT))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 382;
                                        IBRIGHT = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 383;
                                        BRIGHTNESS_IN  .Value = (ushort) ( IBRIGHT ) ; 
                                        } 
                                    
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 388;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 389;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ICON))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 391;
                                        ICON = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 392;
                                        CONTRAST_IN  .Value = (ushort) ( ICON ) ; 
                                        } 
                                    
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 397;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 398;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ISAT))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 400;
                                        ISAT = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 401;
                                        SATURATION_IN  .Value = (ushort) ( ISAT ) ; 
                                        } 
                                    
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 406;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 407;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ITINT))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 409;
                                        ITINT = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 410;
                                        TINT_IN  .Value = (ushort) ( ITINT ) ; 
                                        } 
                                    
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 415;
                                    ITEMP = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                    __context__.SourceCodeLine = 416;
                                    COLOR_TEMPERATURE_IN  .Value = (ushort) ( ITEMP ) ; 
                                    } 
                                
                                } 
                                
                            }
                            
                        
                        __context__.SourceCodeLine = 419;
                        STEMP  .UpdateValue ( ""  ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 332;
                } 
            
            __context__.SourceCodeLine = 422;
            IFLAG1 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 432;
        ICOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 433;
        IVOLUME = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 434;
        ICON = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 435;
        IBRIGHT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 436;
        ISAT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 437;
        ITINT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 438;
        IFLAG1 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    CONTRAST_UP = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_UP__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_UP__DigitalInput__, CONTRAST_UP );
    
    CONTRAST_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_DOWN__DigitalInput__, CONTRAST_DOWN );
    
    BRIGHTNESS_UP = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_UP__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_UP__DigitalInput__, BRIGHTNESS_UP );
    
    BRIGHTNESS_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_DOWN__DigitalInput__, BRIGHTNESS_DOWN );
    
    SATURATION_UP = new Crestron.Logos.SplusObjects.DigitalInput( SATURATION_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SATURATION_UP__DigitalInput__, SATURATION_UP );
    
    SATURATION_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SATURATION_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SATURATION_DOWN__DigitalInput__, SATURATION_DOWN );
    
    TINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( TINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( TINT_UP__DigitalInput__, TINT_UP );
    
    TINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( TINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( TINT_DOWN__DigitalInput__, TINT_DOWN );
    
    RAMPING = new Crestron.Logos.SplusObjects.DigitalInput( RAMPING__DigitalInput__, this );
    m_DigitalInputList.Add( RAMPING__DigitalInput__, RAMPING );
    
    RAMP_DONE = new Crestron.Logos.SplusObjects.DigitalInput( RAMP_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( RAMP_DONE__DigitalInput__, RAMP_DONE );
    
    POLL_SENT = new Crestron.Logos.SplusObjects.AnalogInput( POLL_SENT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( POLL_SENT__AnalogSerialInput__, POLL_SENT );
    
    POWER_IN = new Crestron.Logos.SplusObjects.AnalogOutput( POWER_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( POWER_IN__AnalogSerialOutput__, POWER_IN );
    
    INPUT_IN = new Crestron.Logos.SplusObjects.AnalogOutput( INPUT_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( INPUT_IN__AnalogSerialOutput__, INPUT_IN );
    
    VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_IN__AnalogSerialOutput__, VOLUME_IN );
    
    VOLUME_MUTE_IN = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_MUTE_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_MUTE_IN__AnalogSerialOutput__, VOLUME_MUTE_IN );
    
    CONTRAST_IN = new Crestron.Logos.SplusObjects.AnalogOutput( CONTRAST_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONTRAST_IN__AnalogSerialOutput__, CONTRAST_IN );
    
    BRIGHTNESS_IN = new Crestron.Logos.SplusObjects.AnalogOutput( BRIGHTNESS_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BRIGHTNESS_IN__AnalogSerialOutput__, BRIGHTNESS_IN );
    
    SATURATION_IN = new Crestron.Logos.SplusObjects.AnalogOutput( SATURATION_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SATURATION_IN__AnalogSerialOutput__, SATURATION_IN );
    
    TINT_IN = new Crestron.Logos.SplusObjects.AnalogOutput( TINT_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TINT_IN__AnalogSerialOutput__, TINT_IN );
    
    AUTO_COLOR_CONTROL_IN = new Crestron.Logos.SplusObjects.AnalogOutput( AUTO_COLOR_CONTROL_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUTO_COLOR_CONTROL_IN__AnalogSerialOutput__, AUTO_COLOR_CONTROL_IN );
    
    COLOR_TEMPERATURE_IN = new Crestron.Logos.SplusObjects.AnalogOutput( COLOR_TEMPERATURE_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COLOR_TEMPERATURE_IN__AnalogSerialOutput__, COLOR_TEMPERATURE_IN );
    
    CHANNEL_IN = new Crestron.Logos.SplusObjects.AnalogOutput( CHANNEL_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHANNEL_IN__AnalogSerialOutput__, CHANNEL_IN );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_0, false ) );
    VOLUME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DOWN_OnPush_1, false ) );
    CONTRAST_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTRAST_UP_OnPush_2, false ) );
    CONTRAST_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTRAST_DOWN_OnPush_3, false ) );
    BRIGHTNESS_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BRIGHTNESS_UP_OnPush_4, false ) );
    BRIGHTNESS_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BRIGHTNESS_DOWN_OnPush_5, false ) );
    SATURATION_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SATURATION_UP_OnPush_6, false ) );
    SATURATION_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SATURATION_DOWN_OnPush_7, false ) );
    TINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( TINT_UP_OnPush_8, false ) );
    TINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( TINT_DOWN_OnPush_9, false ) );
    RAMP_DONE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RAMP_DONE_OnPush_10, false ) );
    POLL_SENT.OnAnalogChange.Add( new InputChangeHandlerWrapper( POLL_SENT_OnChange_11, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_12, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_NUVISION_LCD_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DOWN__DigitalInput__ = 1;
const uint CONTRAST_UP__DigitalInput__ = 2;
const uint CONTRAST_DOWN__DigitalInput__ = 3;
const uint BRIGHTNESS_UP__DigitalInput__ = 4;
const uint BRIGHTNESS_DOWN__DigitalInput__ = 5;
const uint SATURATION_UP__DigitalInput__ = 6;
const uint SATURATION_DOWN__DigitalInput__ = 7;
const uint TINT_UP__DigitalInput__ = 8;
const uint TINT_DOWN__DigitalInput__ = 9;
const uint RAMPING__DigitalInput__ = 10;
const uint RAMP_DONE__DigitalInput__ = 11;
const uint POLL_SENT__AnalogSerialInput__ = 0;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 1;
const uint POWER_IN__AnalogSerialOutput__ = 0;
const uint INPUT_IN__AnalogSerialOutput__ = 1;
const uint VOLUME_IN__AnalogSerialOutput__ = 2;
const uint VOLUME_MUTE_IN__AnalogSerialOutput__ = 3;
const uint CONTRAST_IN__AnalogSerialOutput__ = 4;
const uint BRIGHTNESS_IN__AnalogSerialOutput__ = 5;
const uint SATURATION_IN__AnalogSerialOutput__ = 6;
const uint TINT_IN__AnalogSerialOutput__ = 7;
const uint AUTO_COLOR_CONTROL_IN__AnalogSerialOutput__ = 8;
const uint COLOR_TEMPERATURE_IN__AnalogSerialOutput__ = 9;
const uint CHANNEL_IN__AnalogSerialOutput__ = 10;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 11;

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
