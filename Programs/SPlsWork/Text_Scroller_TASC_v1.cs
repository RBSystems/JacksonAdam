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

namespace UserModule_TEXT_SCROLLER_TASC_V1
{
    public class UserModuleClass_TEXT_SCROLLER_TASC_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DISCROLLUP;
        Crestron.Logos.SplusObjects.DigitalInput DISCROLLDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DIPAGEUP;
        Crestron.Logos.SplusObjects.DigitalInput DIPAGEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DITOPOFLIST;
        Crestron.Logos.SplusObjects.DigitalInput DIBOTTOMOFLIST;
        Crestron.Logos.SplusObjects.DigitalInput DIRESETSELECTED;
        Crestron.Logos.SplusObjects.DigitalInput DISELECTHIGHLIGHTEDITEM;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DISELECTITEMINWINDOW;
        Crestron.Logos.SplusObjects.AnalogInput AIPAGESIZE;
        Crestron.Logos.SplusObjects.AnalogInput AISCROLLBAR;
        Crestron.Logos.SplusObjects.AnalogInput NUM_ITEMS;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> AIITEMDATA;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMTEXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMIMAGE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOACTUALITEMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOHIGHLIGHTBAR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOLINESELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput AOSCROLLBARF;
        Crestron.Logos.SplusObjects.AnalogOutput AOSELECTEDITEMDATA;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOITEMTEXTWINDOW__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOITEMIMAGEWINDOW__DOLLAR__;
        ushort G_INUMBERITEMS = 0;
        ushort G_IACTUALITEMHIGHLIGHTEDNUM = 0;
        ushort G_IBARPOSITIONINWINDOW = 0;
        ushort G_IITEMNUMBERATTOPOFWINDOW = 0;
        ushort G_IPAGESIZE = 0;
        private ushort MOVEHIGHLIGHTBARTO (  SplusExecutionContext __context__, ushort POSITION ) 
            { 
            
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((G_IITEMNUMBERATTOPOFWINDOW + POSITION) - 1) > G_INUMBERITEMS ))  ) ) 
                {
                __context__.SourceCodeLine = 57;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 59;
            DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 60;
            G_IBARPOSITIONINWINDOW = (ushort) ( POSITION ) ; 
            __context__.SourceCodeLine = 61;
            DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 63;
            return (ushort)( 1) ; 
            
            }
            
        private void UPDATESCROLLBARFB (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 69;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 70;
                AOSCROLLBARF  .Value = (ushort) ( 65535 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 72;
                AOSCROLLBARF  .Value = (ushort) ( (65535 - Functions.MulDiv( (ushort)( (G_IACTUALITEMHIGHLIGHTEDNUM - 1) ) , (ushort)( 65535 ) , (ushort)( (G_INUMBERITEMS - 1) ) )) ) ; 
                }
            
            
            }
            
        private void GOTOTOP (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 79;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 80;
            UPDATESCROLLBARFB (  __context__  ) ; 
            __context__.SourceCodeLine = 83;
            MOVEHIGHLIGHTBARTO (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 86;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
            
            }
            
        private void RESENDTEXT (  SplusExecutionContext __context__, ushort LASTMODIFIED , ushort TEXTORIMAGE ) 
            { 
            ushort UPPERBOUND = 0;
            
            
            __context__.SourceCodeLine = 93;
            UPPERBOUND = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) - 1) ) ; 
            __context__.SourceCodeLine = 94;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( UPPERBOUND > 50 ))  ) ) 
                { 
                __context__.SourceCodeLine = 96;
                UPPERBOUND = (ushort) ( 50 ) ; 
                } 
            
            __context__.SourceCodeLine = 99;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LASTMODIFIED >= G_IITEMNUMBERATTOPOFWINDOW ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LASTMODIFIED <= UPPERBOUND ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 101;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXTORIMAGE == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 102;
                    SOITEMTEXTWINDOW__DOLLAR__ [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMTEXT__DOLLAR__ [ LASTMODIFIED ]  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 103;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXTORIMAGE == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 104;
                        SOITEMIMAGEWINDOW__DOLLAR__ [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMIMAGE__DOLLAR__ [ LASTMODIFIED ]  ) ; 
                        }
                    
                    }
                
                } 
            
            
            }
            
        private void REDRAWWINDOW (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort UPPERBOUND = 0;
            
            
            __context__.SourceCodeLine = 114;
            UPPERBOUND = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) - 1) ) ; 
            __context__.SourceCodeLine = 116;
            
            __context__.SourceCodeLine = 119;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( UPPERBOUND > 50 ))  ) ) 
                { 
                __context__.SourceCodeLine = 121;
                UPPERBOUND = (ushort) ( 50 ) ; 
                } 
            
            __context__.SourceCodeLine = 124;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( G_IITEMNUMBERATTOPOFWINDOW ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)UPPERBOUND; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 126;
                SOITEMTEXTWINDOW__DOLLAR__ [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMTEXT__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 127;
                SOITEMIMAGEWINDOW__DOLLAR__ [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMIMAGE__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 124;
                } 
            
            
            }
            
        object DISELECTITEMINWINDOW_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 135;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 138;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 139;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 142;
                Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
                __context__.SourceCodeLine = 143;
                DOACTUALITEMSELECTED [ G_IACTUALITEMHIGHLIGHTEDNUM]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 146;
                AOSELECTEDITEMDATA  .Value = (ushort) ( AIITEMDATA[ G_IACTUALITEMHIGHLIGHTEDNUM ] .UshortValue ) ; 
                __context__.SourceCodeLine = 149;
                Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
                __context__.SourceCodeLine = 150;
                DOLINESELECTED [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DISELECTHIGHLIGHTEDITEM_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 156;
            Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
            __context__.SourceCodeLine = 157;
            DOACTUALITEMSELECTED [ G_IACTUALITEMHIGHLIGHTEDNUM]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 160;
            AOSELECTEDITEMDATA  .Value = (ushort) ( AIITEMDATA[ G_IACTUALITEMHIGHLIGHTEDNUM ] .UshortValue ) ; 
            __context__.SourceCodeLine = 163;
            Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
            __context__.SourceCodeLine = 164;
            DOLINESELECTED [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SIITEMIMAGE__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 169;
        RESENDTEXT (  __context__ , (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SIITEMTEXT__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEM = 0;
        
        ushort FOUND = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 178;
        ITEM = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 179;
        G_INUMBERITEMS = (ushort) ( NUM_ITEMS  .UshortValue ) ; 
        __context__.SourceCodeLine = 210;
        RESENDTEXT (  __context__ , (ushort)( ITEM ), (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 211;
        UPDATESCROLLBARFB (  __context__  ) ; 
        __context__.SourceCodeLine = 213;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS > 50 ))  ) ) 
            {
            __context__.SourceCodeLine = 214;
            GenerateUserError ( "Number of items to scroll list ({0:d}) exceeds maximum of {1:d}!", (ushort)G_INUMBERITEMS, (ushort)50) ; 
            }
        
        __context__.SourceCodeLine = 216;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRESETSELECTED_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 223;
        Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 224;
        Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 225;
        AOSELECTEDITEMDATA  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 226;
        GOTOTOP (  __context__  ) ; 
        __context__.SourceCodeLine = 227;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCROLLUP_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IPREVIOUSACTUALITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 234;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBARPOSITIONINWINDOW > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 237;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( (G_IBARPOSITIONINWINDOW - 1) ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 238;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 241;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
            __context__.SourceCodeLine = 242;
            UPDATESCROLLBARFB (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 244;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IITEMNUMBERATTOPOFWINDOW > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 248;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW - 1) ) ; 
                __context__.SourceCodeLine = 249;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 250;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 251;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 254;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCROLLDOWN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 261;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBARPOSITIONINWINDOW < G_IPAGESIZE ))  ) ) 
            { 
            __context__.SourceCodeLine = 264;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( (G_IBARPOSITIONINWINDOW + 1) ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 265;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 268;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
            __context__.SourceCodeLine = 269;
            UPDATESCROLLBARFB (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 271;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) <= G_INUMBERITEMS ))  ) ) 
                { 
                __context__.SourceCodeLine = 275;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW + 1) ) ; 
                __context__.SourceCodeLine = 276;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 277;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 278;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 281;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIPAGEUP_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort CURRENTITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 290;
        CURRENTITEMHIGHLIGHTED = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 294;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IITEMNUMBERATTOPOFWINDOW > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 297;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (CURRENTITEMHIGHLIGHTED - G_IPAGESIZE) > (G_IBARPOSITIONINWINDOW - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 299;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW - G_IPAGESIZE) ) ; 
                __context__.SourceCodeLine = 300;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 301;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 302;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 309;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 310;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 311;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 312;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 315;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTITEMHIGHLIGHTED > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 319;
                MOVEHIGHLIGHTBARTO (  __context__ , (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 322;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 323;
                UPDATESCROLLBARFB (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 326;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIPAGEDOWN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort CURRENTITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 334;
        CURRENTITEMHIGHLIGHTED = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 338;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) <= G_INUMBERITEMS ))  ) ) 
            { 
            __context__.SourceCodeLine = 341;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_INUMBERITEMS - (CURRENTITEMHIGHLIGHTED + G_IPAGESIZE)) >= (G_IPAGESIZE - G_IBARPOSITIONINWINDOW) ))  ) ) 
                { 
                __context__.SourceCodeLine = 343;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) ) ; 
                __context__.SourceCodeLine = 344;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 345;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 346;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 353;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
                __context__.SourceCodeLine = 354;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 355;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 356;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 359;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTITEMHIGHLIGHTED < G_INUMBERITEMS ))  ) ) 
                { 
                __context__.SourceCodeLine = 363;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.Min( G_INUMBERITEMS , G_IPAGESIZE ) ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 364;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 367;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 368;
                UPDATESCROLLBARFB (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 371;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DITOPOFLIST_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 378;
        GOTOTOP (  __context__  ) ; 
        __context__.SourceCodeLine = 379;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIBOTTOMOFLIST_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 384;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.Min( G_INUMBERITEMS , G_IPAGESIZE ) ) ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 385;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 387;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS < G_IPAGESIZE ))  ) ) 
            {
            __context__.SourceCodeLine = 388;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 390;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 392;
        G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 393;
        UPDATESCROLLBARFB (  __context__  ) ; 
        __context__.SourceCodeLine = 394;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AISCROLLBAR_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort OUTVAL = 0;
        
        short NUMITEMSNEEDEDABOVE = 0;
        short NUMITEMSNEEDEDBELOW = 0;
        
        short NUMITEMSAVAILABOVE = 0;
        short NUMITEMSAVAILBELOW = 0;
        
        
        __context__.SourceCodeLine = 404;
        OUTVAL = (ushort) ( (1 + Functions.MulDiv( (ushort)( (65535 - AISCROLLBAR  .UshortValue) ) , (ushort)( (G_INUMBERITEMS - 1) ) , (ushort)( 65535 ) )) ) ; 
        __context__.SourceCodeLine = 405;
        NUMITEMSAVAILABOVE = (short) ( (OUTVAL - 1) ) ; 
        __context__.SourceCodeLine = 406;
        NUMITEMSNEEDEDABOVE = (short) ( (G_IBARPOSITIONINWINDOW - 1) ) ; 
        __context__.SourceCodeLine = 407;
        NUMITEMSAVAILBELOW = (short) ( (G_INUMBERITEMS - OUTVAL) ) ; 
        __context__.SourceCodeLine = 408;
        NUMITEMSNEEDEDBELOW = (short) ( (G_IPAGESIZE - G_IBARPOSITIONINWINDOW) ) ; 
        __context__.SourceCodeLine = 410;
        
        __context__.SourceCodeLine = 415;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NUMITEMSAVAILABOVE >= NUMITEMSNEEDEDABOVE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NUMITEMSAVAILBELOW >= NUMITEMSNEEDEDBELOW ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 418;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((OUTVAL - G_IBARPOSITIONINWINDOW) + 1) ) ; 
            __context__.SourceCodeLine = 419;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
            __context__.SourceCodeLine = 420;
            UPDATESCROLLBARFB (  __context__  ) ; 
            __context__.SourceCodeLine = 421;
            REDRAWWINDOW (  __context__  ) ; 
            __context__.SourceCodeLine = 422;
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 426;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMITEMSAVAILABOVE < NUMITEMSNEEDEDABOVE ))  ) ) 
                { 
                __context__.SourceCodeLine = 428;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( OUTVAL ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 429;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 431;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 432;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
                __context__.SourceCodeLine = 433;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 434;
                REDRAWWINDOW (  __context__  ) ; 
                __context__.SourceCodeLine = 435;
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 439;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMITEMSAVAILBELOW < NUMITEMSNEEDEDBELOW ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 441;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( ((OUTVAL - G_INUMBERITEMS) + G_IPAGESIZE) ) ) == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 442;
                        return  this ; 
                        }
                    
                    __context__.SourceCodeLine = 444;
                    G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
                    __context__.SourceCodeLine = 445;
                    G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
                    __context__.SourceCodeLine = 446;
                    UPDATESCROLLBARFB (  __context__  ) ; 
                    __context__.SourceCodeLine = 447;
                    REDRAWWINDOW (  __context__  ) ; 
                    __context__.SourceCodeLine = 448;
                    
                    } 
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AIPAGESIZE_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 457;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( AIPAGESIZE  .UshortValue > 15 ))  ) ) 
            { 
            __context__.SourceCodeLine = 459;
            GenerateUserError ( "Page size of {0:d} exceeds maximum page size of {1:d}, Clipping to 1.", (ushort)AIPAGESIZE  .UshortValue, (ushort)15) ; 
            __context__.SourceCodeLine = 460;
            G_IPAGESIZE = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 464;
            G_IPAGESIZE = (ushort) ( AIPAGESIZE  .UshortValue ) ; 
            __context__.SourceCodeLine = 465;
            REDRAWWINDOW (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 471;
        G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 472;
        G_INUMBERITEMS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 473;
        G_IPAGESIZE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 474;
        Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 475;
        G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 476;
        Functions.SetArray ( DOHIGHLIGHTBAR , (ushort)0) ; 
        __context__.SourceCodeLine = 477;
        G_IBARPOSITIONINWINDOW = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 478;
        DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 479;
        Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 481;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 483;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DISCROLLUP = new Crestron.Logos.SplusObjects.DigitalInput( DISCROLLUP__DigitalInput__, this );
    m_DigitalInputList.Add( DISCROLLUP__DigitalInput__, DISCROLLUP );
    
    DISCROLLDOWN = new Crestron.Logos.SplusObjects.DigitalInput( DISCROLLDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( DISCROLLDOWN__DigitalInput__, DISCROLLDOWN );
    
    DIPAGEUP = new Crestron.Logos.SplusObjects.DigitalInput( DIPAGEUP__DigitalInput__, this );
    m_DigitalInputList.Add( DIPAGEUP__DigitalInput__, DIPAGEUP );
    
    DIPAGEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( DIPAGEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( DIPAGEDOWN__DigitalInput__, DIPAGEDOWN );
    
    DITOPOFLIST = new Crestron.Logos.SplusObjects.DigitalInput( DITOPOFLIST__DigitalInput__, this );
    m_DigitalInputList.Add( DITOPOFLIST__DigitalInput__, DITOPOFLIST );
    
    DIBOTTOMOFLIST = new Crestron.Logos.SplusObjects.DigitalInput( DIBOTTOMOFLIST__DigitalInput__, this );
    m_DigitalInputList.Add( DIBOTTOMOFLIST__DigitalInput__, DIBOTTOMOFLIST );
    
    DIRESETSELECTED = new Crestron.Logos.SplusObjects.DigitalInput( DIRESETSELECTED__DigitalInput__, this );
    m_DigitalInputList.Add( DIRESETSELECTED__DigitalInput__, DIRESETSELECTED );
    
    DISELECTHIGHLIGHTEDITEM = new Crestron.Logos.SplusObjects.DigitalInput( DISELECTHIGHLIGHTEDITEM__DigitalInput__, this );
    m_DigitalInputList.Add( DISELECTHIGHLIGHTEDITEM__DigitalInput__, DISELECTHIGHLIGHTEDITEM );
    
    DISELECTITEMINWINDOW = new InOutArray<DigitalInput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DISELECTITEMINWINDOW[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DISELECTITEMINWINDOW__DigitalInput__ + i, DISELECTITEMINWINDOW__DigitalInput__, this );
        m_DigitalInputList.Add( DISELECTITEMINWINDOW__DigitalInput__ + i, DISELECTITEMINWINDOW[i+1] );
    }
    
    DOACTUALITEMSELECTED = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        DOACTUALITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOACTUALITEMSELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOACTUALITEMSELECTED__DigitalOutput__ + i, DOACTUALITEMSELECTED[i+1] );
    }
    
    DOHIGHLIGHTBAR = new InOutArray<DigitalOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DOHIGHLIGHTBAR[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOHIGHLIGHTBAR__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOHIGHLIGHTBAR__DigitalOutput__ + i, DOHIGHLIGHTBAR[i+1] );
    }
    
    DOLINESELECTED = new InOutArray<DigitalOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DOLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOLINESELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOLINESELECTED__DigitalOutput__ + i, DOLINESELECTED[i+1] );
    }
    
    AIPAGESIZE = new Crestron.Logos.SplusObjects.AnalogInput( AIPAGESIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AIPAGESIZE__AnalogSerialInput__, AIPAGESIZE );
    
    AISCROLLBAR = new Crestron.Logos.SplusObjects.AnalogInput( AISCROLLBAR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AISCROLLBAR__AnalogSerialInput__, AISCROLLBAR );
    
    NUM_ITEMS = new Crestron.Logos.SplusObjects.AnalogInput( NUM_ITEMS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NUM_ITEMS__AnalogSerialInput__, NUM_ITEMS );
    
    AIITEMDATA = new InOutArray<AnalogInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        AIITEMDATA[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( AIITEMDATA__AnalogSerialInput__ + i, AIITEMDATA__AnalogSerialInput__, this );
        m_AnalogInputList.Add( AIITEMDATA__AnalogSerialInput__ + i, AIITEMDATA[i+1] );
    }
    
    AOSCROLLBARF = new Crestron.Logos.SplusObjects.AnalogOutput( AOSCROLLBARF__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOSCROLLBARF__AnalogSerialOutput__, AOSCROLLBARF );
    
    AOSELECTEDITEMDATA = new Crestron.Logos.SplusObjects.AnalogOutput( AOSELECTEDITEMDATA__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOSELECTEDITEMDATA__AnalogSerialOutput__, AOSELECTEDITEMDATA );
    
    SIITEMTEXT__DOLLAR__ = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SIITEMTEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR__[i+1] );
    }
    
    SIITEMIMAGE__DOLLAR__ = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SIITEMIMAGE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMIMAGE__DOLLAR____AnalogSerialInput__ + i, SIITEMIMAGE__DOLLAR____AnalogSerialInput__, 160, this );
        m_StringInputList.Add( SIITEMIMAGE__DOLLAR____AnalogSerialInput__ + i, SIITEMIMAGE__DOLLAR__[i+1] );
    }
    
    SOITEMTEXTWINDOW__DOLLAR__ = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SOITEMTEXTWINDOW__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ + i, SOITEMTEXTWINDOW__DOLLAR__[i+1] );
    }
    
    SOITEMIMAGEWINDOW__DOLLAR__ = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SOITEMIMAGEWINDOW__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOITEMIMAGEWINDOW__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOITEMIMAGEWINDOW__DOLLAR____AnalogSerialOutput__ + i, SOITEMIMAGEWINDOW__DOLLAR__[i+1] );
    }
    
    
    for( uint i = 0; i < 15; i++ )
        DISELECTITEMINWINDOW[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DISELECTITEMINWINDOW_OnPush_0, false ) );
        
    DISELECTHIGHLIGHTEDITEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISELECTHIGHLIGHTEDITEM_OnPush_1, false ) );
    for( uint i = 0; i < 50; i++ )
        SIITEMIMAGE__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIITEMIMAGE__DOLLAR___OnChange_2, false ) );
        
    for( uint i = 0; i < 50; i++ )
        SIITEMTEXT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIITEMTEXT__DOLLAR___OnChange_3, false ) );
        
    DIRESETSELECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRESETSELECTED_OnPush_4, false ) );
    DISCROLLUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCROLLUP_OnPush_5, false ) );
    DISCROLLDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCROLLDOWN_OnPush_6, false ) );
    DIPAGEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIPAGEUP_OnPush_7, false ) );
    DIPAGEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIPAGEDOWN_OnPush_8, false ) );
    DITOPOFLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( DITOPOFLIST_OnPush_9, false ) );
    DIBOTTOMOFLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIBOTTOMOFLIST_OnPush_10, false ) );
    AISCROLLBAR.OnAnalogChange.Add( new InputChangeHandlerWrapper( AISCROLLBAR_OnChange_11, false ) );
    AIPAGESIZE.OnAnalogChange.Add( new InputChangeHandlerWrapper( AIPAGESIZE_OnChange_12, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TEXT_SCROLLER_TASC_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DISCROLLUP__DigitalInput__ = 0;
const uint DISCROLLDOWN__DigitalInput__ = 1;
const uint DIPAGEUP__DigitalInput__ = 2;
const uint DIPAGEDOWN__DigitalInput__ = 3;
const uint DITOPOFLIST__DigitalInput__ = 4;
const uint DIBOTTOMOFLIST__DigitalInput__ = 5;
const uint DIRESETSELECTED__DigitalInput__ = 6;
const uint DISELECTHIGHLIGHTEDITEM__DigitalInput__ = 7;
const uint DISELECTITEMINWINDOW__DigitalInput__ = 8;
const uint AIPAGESIZE__AnalogSerialInput__ = 0;
const uint AISCROLLBAR__AnalogSerialInput__ = 1;
const uint NUM_ITEMS__AnalogSerialInput__ = 2;
const uint AIITEMDATA__AnalogSerialInput__ = 3;
const uint SIITEMTEXT__DOLLAR____AnalogSerialInput__ = 53;
const uint SIITEMIMAGE__DOLLAR____AnalogSerialInput__ = 103;
const uint DOACTUALITEMSELECTED__DigitalOutput__ = 0;
const uint DOHIGHLIGHTBAR__DigitalOutput__ = 50;
const uint DOLINESELECTED__DigitalOutput__ = 65;
const uint AOSCROLLBARF__AnalogSerialOutput__ = 0;
const uint AOSELECTEDITEMDATA__AnalogSerialOutput__ = 1;
const uint SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ = 2;
const uint SOITEMIMAGEWINDOW__DOLLAR____AnalogSerialOutput__ = 17;

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
