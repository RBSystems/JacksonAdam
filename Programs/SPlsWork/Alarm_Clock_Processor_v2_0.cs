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

namespace CrestronModule_ALARM_CLOCK_PROCESSOR_V2_0
{
    public class CrestronModuleClass_ALARM_CLOCK_PROCESSOR_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput OSC_CHANGE;
        Crestron.Logos.SplusObjects.StringInput FILE_NAME;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput MIN_PLUS_SLOW;
        Crestron.Logos.SplusObjects.DigitalInput MIN_PLUS_FAST;
        Crestron.Logos.SplusObjects.DigitalInput MIN_MINUS_SLOW;
        Crestron.Logos.SplusObjects.DigitalInput MIN_MINUS_FAST;
        Crestron.Logos.SplusObjects.DigitalInput SNOOZE_PLUS;
        Crestron.Logos.SplusObjects.DigitalInput SNOOZE_MINUS;
        Crestron.Logos.SplusObjects.DigitalInput SNOOZE_ALARM;
        Crestron.Logos.SplusObjects.DigitalInput DISMISS_ALARM;
        Crestron.Logos.SplusObjects.DigitalInput ALARM_1_TOGGLE_ON_OFF;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT_12_HOUR;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT_24_HOUR;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_SETTINGS;
        Crestron.Logos.SplusObjects.DigitalInput TIME_FORMAT_TOGGLE;
        Crestron.Logos.SplusObjects.AnalogInput ALARM_DURATION;
        Crestron.Logos.SplusObjects.AnalogInput ALARM_HOUR_IN;
        Crestron.Logos.SplusObjects.AnalogInput ALARM_MIN_IN;
        Crestron.Logos.SplusObjects.AnalogInput MAX_SNOOZE_DURATION;
        Crestron.Logos.SplusObjects.AnalogInput MIN_SNOOZE_DURATION;
        Crestron.Logos.SplusObjects.StringInput INSTANCE_ID;
        Crestron.Logos.SplusObjects.StringInput FILE_LOCATION;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DAYS;
        Crestron.Logos.SplusObjects.StringOutput CUR_TIME_OUT;
        Crestron.Logos.SplusObjects.StringOutput CUR_ALARM_TIME;
        Crestron.Logos.SplusObjects.DigitalOutput CUR_ALARM_AM_FB;
        Crestron.Logos.SplusObjects.DigitalOutput CUR_ALARM_PM_FB;
        Crestron.Logos.SplusObjects.StringOutput NEXT_ALARM_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput ALARM_HOUR;
        Crestron.Logos.SplusObjects.AnalogOutput ALARM_MIN;
        Crestron.Logos.SplusObjects.AnalogOutput SNOOZE_MIN;
        Crestron.Logos.SplusObjects.StringOutput SNOOZE_TIME;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_SNOOZE_PAGE;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_DISMISS_ALARM_PAGE;
        Crestron.Logos.SplusObjects.DigitalOutput TIME_FORMAT_12_HOUR_FB;
        Crestron.Logos.SplusObjects.DigitalOutput TIME_FORMAT_24_HOUR_FB;
        Crestron.Logos.SplusObjects.StringOutput ALARM_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput ALARM_LIGHTS;
        Crestron.Logos.SplusObjects.DigitalOutput ALARM_SOUNDING;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZATION_COMPLETE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DAYS_FB;
        STTIME CUR_TIME;
        STALARM ALARMS;
        STSETTINGS SETTINGS;
        CrestronString ALARM_1_TIME;
        private void LOADSETTINGS (  SplusExecutionContext __context__ ) 
            { 
            ushort NFILE = 0;
            
            CrestronString SDATA;
            SDATA  = new CrestronString( InheritedStringEncoding, 100, this );
            
            CrestronString SDEFAULT;
            SDEFAULT  = new CrestronString( InheritedStringEncoding, 100, this );
            
            ushort ILOC = 0;
            
            ushort ILEN = 0;
            
            ushort I = 0;
            
            CrestronString STEXT;
            STEXT  = new CrestronString( InheritedStringEncoding, 5, this );
            
            CrestronString [] SPARSEDDATA;
            SPARSEDDATA  = new CrestronString[ 27 ];
            for( uint i = 0; i < 27; i++ )
                SPARSEDDATA [i] = new CrestronString( InheritedStringEncoding, 5, this );
            
            CrestronString SFILE;
            SFILE  = new CrestronString( InheritedStringEncoding, 100, this );
            
            FILE_INFO FINFO;
            FINFO  = new FILE_INFO();
            FINFO .PopulateDefaults();
            
            
            __context__.SourceCodeLine = 160;
            
            __context__.SourceCodeLine = 168;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 169;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 171;
                SFILE  .UpdateValue ( FILE_LOCATION + "\\" + FILE_NAME + "[" + INSTANCE_ID + "]"  ) ; 
                __context__.SourceCodeLine = 172;
                
                __context__.SourceCodeLine = 176;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( SFILE , ref FINFO ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 177;
                    
                    __context__.SourceCodeLine = 180;
                    NFILE = (ushort) ( FileOpen( SFILE ,(ushort) (((2 | 256) | 512) | 16384) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 182;
                    
                    __context__.SourceCodeLine = 185;
                    NFILE = (ushort) ( FileOpen( SFILE ,(ushort) (2 | 16384) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 188;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 189;
                    
                    __context__.SourceCodeLine = 194;
                    FileRead (  (short) ( NFILE ) , SDATA ,  (ushort) ( (((2 | 256) | 512) | 16384) ) ) ; 
                    __context__.SourceCodeLine = 196;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDATA == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 197;
                        SDEFAULT  .UpdateValue ( "1|12|00|0|5|0|0|0|0|0|0|0|0|"  ) ; 
                        __context__.SourceCodeLine = 198;
                        SDATA  .UpdateValue ( SDEFAULT  ) ; 
                        __context__.SourceCodeLine = 199;
                        FileWrite (  (short) ( NFILE ) , SDEFAULT ,  (ushort) ( Functions.Length( SDEFAULT ) ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 202;
                    
                    __context__.SourceCodeLine = 207;
                    I = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 208;
                    ILOC = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 209;
                    ILEN = (ushort) ( Functions.Find( "|" , SDATA , ILOC ) ) ; 
                    __context__.SourceCodeLine = 210;
                    do 
                        { 
                        __context__.SourceCodeLine = 211;
                        STEXT  .UpdateValue ( Functions.Mid ( SDATA ,  (int) ( ILOC ) ,  (int) ( (ILEN - ILOC) ) )  ) ; 
                        __context__.SourceCodeLine = 212;
                        SPARSEDDATA [ I ]  .UpdateValue ( STEXT  ) ; 
                        __context__.SourceCodeLine = 213;
                        I = (ushort) ( (I + 1) ) ; 
                        __context__.SourceCodeLine = 215;
                        ILOC = (ushort) ( (ILEN + 1) ) ; 
                        __context__.SourceCodeLine = 216;
                        ILEN = (ushort) ( Functions.Find( "|" , SDATA , ILOC ) ) ; 
                        } 
                    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (ILEN == 0)) )); 
                    __context__.SourceCodeLine = 219;
                    ALARMS . _HOUR = (ushort) ( Functions.Atoi( SPARSEDDATA[ 2 ] ) ) ; 
                    __context__.SourceCodeLine = 220;
                    ALARMS . _MIN = (ushort) ( Functions.Atoi( SPARSEDDATA[ 3 ] ) ) ; 
                    __context__.SourceCodeLine = 221;
                    ALARMS . _ENABLE = (ushort) ( Functions.Atoi( SPARSEDDATA[ 4 ] ) ) ; 
                    __context__.SourceCodeLine = 222;
                    ALARMS . _SNOOZE_TIME = (ushort) ( Functions.Atoi( SPARSEDDATA[ 5 ] ) ) ; 
                    __context__.SourceCodeLine = 223;
                    ALARMS . _DAYS [ 1] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 6 ] ) ) ; 
                    __context__.SourceCodeLine = 224;
                    ALARMS . _DAYS [ 2] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 7 ] ) ) ; 
                    __context__.SourceCodeLine = 225;
                    ALARMS . _DAYS [ 3] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 8 ] ) ) ; 
                    __context__.SourceCodeLine = 226;
                    ALARMS . _DAYS [ 4] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 9 ] ) ) ; 
                    __context__.SourceCodeLine = 227;
                    ALARMS . _DAYS [ 5] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 10 ] ) ) ; 
                    __context__.SourceCodeLine = 228;
                    ALARMS . _DAYS [ 6] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 11 ] ) ) ; 
                    __context__.SourceCodeLine = 229;
                    ALARMS . _DAYS [ 7] = (ushort) ( Functions.Atoi( SPARSEDDATA[ 12 ] ) ) ; 
                    __context__.SourceCodeLine = 230;
                    SETTINGS . _24_HOUR_MODE = (ushort) ( Functions.Atoi( SPARSEDDATA[ 13 ] ) ) ; 
                    __context__.SourceCodeLine = 231;
                    SETTINGS . _12_HOUR_MODE = (ushort) ( Functions.Not( SETTINGS._24_HOUR_MODE ) ) ; 
                    __context__.SourceCodeLine = 233;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SETTINGS._12_HOUR_MODE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 235;
                        TIME_FORMAT_12_HOUR_FB  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 236;
                        TIME_FORMAT_24_HOUR_FB  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 240;
                        TIME_FORMAT_12_HOUR_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 241;
                        TIME_FORMAT_24_HOUR_FB  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 248;
            FileClose (  (short) ( NFILE ) ) ; 
            __context__.SourceCodeLine = 249;
            EndFileOperations ( ) ; 
            
            }
            
        private void SAVESETTINGS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SWRITE;
            SWRITE  = new CrestronString( InheritedStringEncoding, 100, this );
            
            CrestronString SFILE;
            SFILE  = new CrestronString( InheritedStringEncoding, 100, this );
            
            ushort NFILE = 0;
            
            
            __context__.SourceCodeLine = 258;
            
            __context__.SourceCodeLine = 266;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 267;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 269;
                SFILE  .UpdateValue ( FILE_LOCATION + "\\" + FILE_NAME + "[" + INSTANCE_ID + "]"  ) ; 
                __context__.SourceCodeLine = 270;
                
                __context__.SourceCodeLine = 274;
                NFILE = (ushort) ( FileOpen( SFILE ,(ushort) (((1 | 256) | 512) | 16384) ) ) ; 
                __context__.SourceCodeLine = 276;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 277;
                    
                    __context__.SourceCodeLine = 282;
                    SWRITE  .UpdateValue ( "1|" + Functions.ItoA (  (int) ( ALARMS._HOUR ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._MIN ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._ENABLE ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._SNOOZE_TIME ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 1 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 2 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 3 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 4 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 5 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 6 ] ) ) + "|" + Functions.ItoA (  (int) ( ALARMS._DAYS[ 7 ] ) ) + "|" + Functions.ItoA (  (int) ( SETTINGS._24_HOUR_MODE ) ) + "|"  ) ; 
                    __context__.SourceCodeLine = 287;
                    
                    __context__.SourceCodeLine = 292;
                    FileWrite (  (short) ( NFILE ) , SWRITE ,  (ushort) ( Functions.Length( SWRITE ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 297;
            FileClose (  (short) ( NFILE ) ) ; 
            __context__.SourceCodeLine = 298;
            EndFileOperations ( ) ; 
            
            }
            
        private void UPDATETIME (  SplusExecutionContext __context__ ) 
            { 
            CrestronString TEMP_HOUR;
            CrestronString TEMP_MIN;
            CrestronString TEMP_AMPM;
            TEMP_HOUR  = new CrestronString( InheritedStringEncoding, 2, this );
            TEMP_MIN  = new CrestronString( InheritedStringEncoding, 2, this );
            TEMP_AMPM  = new CrestronString( InheritedStringEncoding, 2, this );
            
            
            __context__.SourceCodeLine = 305;
            CUR_TIME . _HOUR = (ushort) ( Functions.GetHourNum() ) ; 
            __context__.SourceCodeLine = 306;
            CUR_TIME . _MIN = (ushort) ( Functions.GetMinutesNum() ) ; 
            __context__.SourceCodeLine = 307;
            CUR_TIME . _DATE = (ushort) ( Functions.GetDateNum() ) ; 
            __context__.SourceCodeLine = 310;
            TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( CUR_TIME._HOUR ) )  ) ; 
            __context__.SourceCodeLine = 311;
            TEMP_MIN  .UpdateValue ( Functions.ItoA (  (int) ( CUR_TIME._MIN ) )  ) ; 
            __context__.SourceCodeLine = 311;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMP_MIN ) == 1))  ) ) 
                {
                __context__.SourceCodeLine = 311;
                TEMP_MIN  .UpdateValue ( "0" + TEMP_MIN  ) ; 
                }
            
            __context__.SourceCodeLine = 314;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SETTINGS._12_HOUR_MODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 316;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CUR_TIME._HOUR > 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 317;
                    TEMP_AMPM  .UpdateValue ( "PM"  ) ; 
                    __context__.SourceCodeLine = 318;
                    TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( (CUR_TIME._HOUR - 12) ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 319;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CUR_TIME._HOUR == 12))  ) ) 
                        { 
                        __context__.SourceCodeLine = 320;
                        TEMP_AMPM  .UpdateValue ( "PM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 321;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CUR_TIME._HOUR == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 322;
                            TEMP_HOUR  .UpdateValue ( "12"  ) ; 
                            __context__.SourceCodeLine = 323;
                            TEMP_AMPM  .UpdateValue ( "AM"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 325;
                            TEMP_AMPM  .UpdateValue ( "AM"  ) ; 
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 329;
                CUR_TIME_OUT  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN + " " + TEMP_AMPM  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 332;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMP_HOUR ) == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 333;
                    TEMP_HOUR  .UpdateValue ( "0" + TEMP_HOUR  ) ; 
                    }
                
                __context__.SourceCodeLine = 335;
                CUR_TIME_OUT  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN  ) ; 
                } 
            
            
            }
            
        private void NEXTALARM (  SplusExecutionContext __context__ ) 
            { 
            ushort DAYOFWEEK = 0;
            ushort CLOSEST_ACTIVE_DAY = 0;
            ushort COUNT = 0;
            ushort FOUND = 0;
            
            CrestronString [] DAY_OF_WEEK_STRING;
            DAY_OF_WEEK_STRING  = new CrestronString[ 8 ];
            for( uint i = 0; i < 8; i++ )
                DAY_OF_WEEK_STRING [i] = new CrestronString( InheritedStringEncoding, 10, this );
            
            
            __context__.SourceCodeLine = 346;
            DAYOFWEEK = (ushort) ( (Functions.GetDayOfWeekNum() + 1) ) ; 
            __context__.SourceCodeLine = 347;
            CLOSEST_ACTIVE_DAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 348;
            COUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 349;
            FOUND = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 352;
            DAY_OF_WEEK_STRING [ 1 ]  .UpdateValue ( "Sun"  ) ; 
            __context__.SourceCodeLine = 353;
            DAY_OF_WEEK_STRING [ 2 ]  .UpdateValue ( "Mon"  ) ; 
            __context__.SourceCodeLine = 354;
            DAY_OF_WEEK_STRING [ 3 ]  .UpdateValue ( "Tue"  ) ; 
            __context__.SourceCodeLine = 355;
            DAY_OF_WEEK_STRING [ 4 ]  .UpdateValue ( "Wed"  ) ; 
            __context__.SourceCodeLine = 356;
            DAY_OF_WEEK_STRING [ 5 ]  .UpdateValue ( "Thu"  ) ; 
            __context__.SourceCodeLine = 357;
            DAY_OF_WEEK_STRING [ 6 ]  .UpdateValue ( "Fri"  ) ; 
            __context__.SourceCodeLine = 358;
            DAY_OF_WEEK_STRING [ 7 ]  .UpdateValue ( "Sat"  ) ; 
            __context__.SourceCodeLine = 361;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ENABLE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 364;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._DAYS[ DAYOFWEEK ] == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 366;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ALARMS._HOUR < CUR_TIME._HOUR ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._HOUR == CUR_TIME._HOUR) ) && Functions.TestForTrue ( Functions.BoolToInt ( ALARMS._MIN <= CUR_TIME._MIN ) )) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 367;
                        DAYOFWEEK = (ushort) ( (Mod( DAYOFWEEK , 7 ) + 1) ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 371;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (FOUND == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( COUNT < 7 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 373;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._DAYS[ DAYOFWEEK ] == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 374;
                        FOUND = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 376;
                        DAYOFWEEK = (ushort) ( (Mod( DAYOFWEEK , 7 ) + 1) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 378;
                    COUNT = (ushort) ( (COUNT + 1) ) ; 
                    __context__.SourceCodeLine = 371;
                    } 
                
                __context__.SourceCodeLine = 382;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOUND == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 384;
                    NEXT_ALARM_TIME  .UpdateValue ( DAY_OF_WEEK_STRING [ DAYOFWEEK ] + " " + ALARM_1_TIME  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 387;
                    NEXT_ALARM_TIME  .UpdateValue ( "No Days"  ) ; 
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 391;
                NEXT_ALARM_TIME  .UpdateValue ( "Disabled"  ) ; 
                }
            
            
            }
            
        private void UPDATEALARM (  SplusExecutionContext __context__ ) 
            { 
            CrestronString TEMP_HOUR;
            CrestronString TEMP_MIN;
            CrestronString TEMP_AMPM;
            TEMP_HOUR  = new CrestronString( InheritedStringEncoding, 2, this );
            TEMP_MIN  = new CrestronString( InheritedStringEncoding, 2, this );
            TEMP_AMPM  = new CrestronString( InheritedStringEncoding, 2, this );
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 399;
            TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._HOUR ) )  ) ; 
            __context__.SourceCodeLine = 400;
            TEMP_MIN  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._MIN ) )  ) ; 
            __context__.SourceCodeLine = 402;
            ALARM_HOUR  .Value = (ushort) ( ALARMS._HOUR ) ; 
            __context__.SourceCodeLine = 403;
            ALARM_MIN  .Value = (ushort) ( ALARMS._MIN ) ; 
            __context__.SourceCodeLine = 404;
            SNOOZE_MIN  .Value = (ushort) ( ALARMS._SNOOZE_TIME ) ; 
            __context__.SourceCodeLine = 406;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMP_MIN ) == 1))  ) ) 
                {
                __context__.SourceCodeLine = 407;
                TEMP_MIN  .UpdateValue ( "0" + TEMP_MIN  ) ; 
                }
            
            __context__.SourceCodeLine = 410;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SETTINGS._12_HOUR_MODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 412;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._HOUR > 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 414;
                    ALARMS . _AM = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 415;
                    ALARMS . _PM = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 416;
                    TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( (ALARMS._HOUR - 12) ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 417;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._HOUR == 12))  ) ) 
                        { 
                        __context__.SourceCodeLine = 419;
                        ALARMS . _AM = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 420;
                        ALARMS . _PM = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 421;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._HOUR == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 422;
                            TEMP_HOUR  .UpdateValue ( "12"  ) ; 
                            __context__.SourceCodeLine = 424;
                            ALARMS . _AM = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 425;
                            ALARMS . _PM = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 428;
                            ALARMS . _AM = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 429;
                            ALARMS . _PM = (ushort) ( 0 ) ; 
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 433;
                CUR_ALARM_TIME  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN  ) ; 
                __context__.SourceCodeLine = 434;
                CUR_ALARM_AM_FB  .Value = (ushort) ( ALARMS._AM ) ; 
                __context__.SourceCodeLine = 435;
                CUR_ALARM_PM_FB  .Value = (ushort) ( ALARMS._PM ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 440;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMP_HOUR ) == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 441;
                    TEMP_HOUR  .UpdateValue ( "0" + TEMP_HOUR  ) ; 
                    }
                
                __context__.SourceCodeLine = 443;
                CUR_ALARM_TIME  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN  ) ; 
                __context__.SourceCodeLine = 444;
                CUR_ALARM_AM_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 445;
                CUR_ALARM_PM_FB  .Value = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 450;
            TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._HOUR ) )  ) ; 
            __context__.SourceCodeLine = 451;
            TEMP_MIN  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._MIN ) )  ) ; 
            __context__.SourceCodeLine = 451;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMP_MIN ) == 1))  ) ) 
                {
                __context__.SourceCodeLine = 451;
                TEMP_MIN  .UpdateValue ( "0" + TEMP_MIN  ) ; 
                }
            
            __context__.SourceCodeLine = 454;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SETTINGS._12_HOUR_MODE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 457;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._HOUR > 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 458;
                    TEMP_AMPM  .UpdateValue ( "PM"  ) ; 
                    __context__.SourceCodeLine = 459;
                    TEMP_HOUR  .UpdateValue ( Functions.ItoA (  (int) ( (ALARMS._HOUR - 12) ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 460;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._HOUR == 12))  ) ) 
                        { 
                        __context__.SourceCodeLine = 461;
                        TEMP_AMPM  .UpdateValue ( "PM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 462;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._HOUR == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 463;
                            TEMP_HOUR  .UpdateValue ( "12"  ) ; 
                            __context__.SourceCodeLine = 464;
                            TEMP_AMPM  .UpdateValue ( "AM"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 466;
                            TEMP_AMPM  .UpdateValue ( "AM"  ) ; 
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 468;
                ALARM_1_TIME  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN + " " + TEMP_AMPM  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 472;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._HOUR < 10 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 473;
                    ALARM_1_TIME  .UpdateValue ( "0" + TEMP_HOUR + ":" + TEMP_MIN  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 475;
                    ALARM_1_TIME  .UpdateValue ( TEMP_HOUR + ":" + TEMP_MIN  ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 480;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ENABLE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SNOOZING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SOUNDING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ACTIVE == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 482;
                ALARM_STATUS  .UpdateValue ( "ON"  ) ; 
                __context__.SourceCodeLine = 483;
                ALARM_LIGHTS  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 485;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ENABLE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ACTIVE == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SOUNDING == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 487;
                    ALARM_STATUS  .UpdateValue ( "SOUNDING"  ) ; 
                    __context__.SourceCodeLine = 488;
                    ALARM_LIGHTS  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 490;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ENABLE == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 492;
                        ALARM_STATUS  .UpdateValue ( "OFF"  ) ; 
                        __context__.SourceCodeLine = 493;
                        ALARM_LIGHTS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 494;
                        ALARMS . _SNOOZING = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 495;
                        ALARMS . _ACTIVE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 497;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._SNOOZING == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 499;
                            ALARM_STATUS  .UpdateValue ( "SNOOZING"  ) ; 
                            __context__.SourceCodeLine = 500;
                            ALARM_LIGHTS  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 504;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)7; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 505;
                DAYS_FB [ I]  .Value = (ushort) ( ALARMS._DAYS[ I ] ) ; 
                __context__.SourceCodeLine = 504;
                }
            
            __context__.SourceCodeLine = 508;
            SNOOZE_TIME  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._SNOOZE_TIME ) )  ) ; 
            __context__.SourceCodeLine = 511;
            NEXTALARM (  __context__  ) ; 
            
            }
            
        private void DISMISSALARM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 519;
            
            __context__.SourceCodeLine = 523;
            ALARMS . _ACTIVE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 524;
            ALARMS . _SOUNDING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 525;
            ALARM_SOUNDING  .Value = (ushort) ( ALARMS._SOUNDING ) ; 
            __context__.SourceCodeLine = 526;
            ALARMS . _SNOOZING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 529;
            SHOW_SNOOZE_PAGE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 530;
            SHOW_DISMISS_ALARM_PAGE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 533;
            UPDATEALARM (  __context__  ) ; 
            __context__.SourceCodeLine = 533;
            ; 
            
            }
            
        private void ADJUSTTIME (  SplusExecutionContext __context__, ushort HOURS , ushort MINS , ushort ADD ) 
            { 
            ushort MIN_UNDERFLOW_FLAG = 0;
            
            
            __context__.SourceCodeLine = 544;
            MIN_UNDERFLOW_FLAG = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 547;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MINS >= 60 ))  ) ) 
                { 
                __context__.SourceCodeLine = 548;
                HOURS = (ushort) ( (HOURS + ((MINS - Mod( MINS , 60 )) / 60)) ) ; 
                __context__.SourceCodeLine = 549;
                MINS = (ushort) ( Mod( MINS , 60 ) ) ; 
                __context__.SourceCodeLine = 550;
                HOURS = (ushort) ( Mod( HOURS , 24 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 554;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ADD == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 556;
                ALARMS . _HOUR = (ushort) ( (ALARMS._HOUR + HOURS) ) ; 
                __context__.SourceCodeLine = 557;
                ALARMS . _MIN = (ushort) ( (ALARMS._MIN + MINS) ) ; 
                __context__.SourceCodeLine = 558;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._MIN >= 60 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 560;
                    ALARMS . _HOUR = (ushort) ( (ALARMS._HOUR + 1) ) ; 
                    __context__.SourceCodeLine = 561;
                    ALARMS . _MIN = (ushort) ( (ALARMS._MIN - 60) ) ; 
                    } 
                
                __context__.SourceCodeLine = 563;
                ALARMS . _HOUR = (ushort) ( Mod( ALARMS._HOUR , 24 ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 565;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (ALARMS._MIN - MINS) < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (ALARMS._HOUR - HOURS) < 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 568;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ALARMS._MIN - MINS) < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 570;
                        MIN_UNDERFLOW_FLAG = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 571;
                        ALARMS . _MIN = (ushort) ( (60 - (MINS - ALARMS._MIN)) ) ; 
                        __context__.SourceCodeLine = 573;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ALARMS._HOUR - 1) < 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 574;
                            ALARMS . _HOUR = (ushort) ( 23 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 576;
                            ALARMS . _HOUR = (ushort) ( (ALARMS._HOUR - 1) ) ; 
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 580;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (ALARMS._HOUR - HOURS) < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 582;
                        ALARMS . _HOUR = (ushort) ( (24 - (HOURS - ALARMS._HOUR)) ) ; 
                        __context__.SourceCodeLine = 583;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MIN_UNDERFLOW_FLAG == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 584;
                            ALARMS . _MIN = (ushort) ( (ALARMS._MIN - MINS) ) ; 
                            }
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 589;
                    ALARMS . _HOUR = (ushort) ( (ALARMS._HOUR - HOURS) ) ; 
                    __context__.SourceCodeLine = 590;
                    ALARMS . _MIN = (ushort) ( (ALARMS._MIN - MINS) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 593;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ACTIVE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 594;
                DISMISSALARM (  __context__  ) ; 
                }
            
            __context__.SourceCodeLine = 597;
            UPDATEALARM (  __context__  ) ; 
            
            }
            
        private void ACTIVATEALARM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 604;
            
            __context__.SourceCodeLine = 608;
            SHOW_SNOOZE_PAGE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 609;
            SHOW_DISMISS_ALARM_PAGE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 612;
            ALARMS . _ACTIVE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 615;
            ALARMS . _SOUNDING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 616;
            ALARM_SOUNDING  .Value = (ushort) ( ALARMS._SOUNDING ) ; 
            __context__.SourceCodeLine = 619;
            ALARMS . _SNOOZING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 621;
            ALARM_STATUS  .UpdateValue ( "SOUNDING"  ) ; 
            __context__.SourceCodeLine = 624;
            NEXTALARM (  __context__  ) ; 
            __context__.SourceCodeLine = 627;
            
            
            }
            
        private void ALARMDURATIONCHECK (  SplusExecutionContext __context__ ) 
            { 
            ushort _MIN = 0;
            ushort _HOUR = 0;
            ushort _DATE = 0;
            
            ushort _DUR_MIN = 0;
            ushort _DUR_HOUR = 0;
            ushort _DUR_DATE = 0;
            
            
            __context__.SourceCodeLine = 639;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ACTIVE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 642;
                _HOUR = (ushort) ( CUR_TIME._HOUR ) ; 
                __context__.SourceCodeLine = 643;
                _MIN = (ushort) ( CUR_TIME._MIN ) ; 
                __context__.SourceCodeLine = 644;
                _DATE = (ushort) ( CUR_TIME._DATE ) ; 
                __context__.SourceCodeLine = 647;
                _DUR_MIN = (ushort) ( Mod( ALARM_DURATION  .UshortValue , 60 ) ) ; 
                __context__.SourceCodeLine = 648;
                _DUR_HOUR = (ushort) ( ((ALARM_DURATION  .UshortValue - _DUR_MIN) / 60) ) ; 
                __context__.SourceCodeLine = 649;
                _DUR_DATE = (ushort) ( _DATE ) ; 
                __context__.SourceCodeLine = 654;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._SNOOZING == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 656;
                    _DUR_HOUR = (ushort) ( (ALARMS._SNOOZE_HOUR + _DUR_HOUR) ) ; 
                    __context__.SourceCodeLine = 657;
                    _DUR_MIN = (ushort) ( (ALARMS._SNOOZE_MIN + _DUR_MIN) ) ; 
                    __context__.SourceCodeLine = 659;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _DUR_MIN >= 60 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 661;
                        _DUR_HOUR = (ushort) ( (_DUR_HOUR + 1) ) ; 
                        __context__.SourceCodeLine = 662;
                        _DUR_MIN = (ushort) ( (_DUR_MIN - 60) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 664;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _DUR_HOUR >= 24 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 666;
                        _DUR_HOUR = (ushort) ( (_DUR_HOUR - 24) ) ; 
                        __context__.SourceCodeLine = 667;
                        _DUR_DATE = (ushort) ( (_DUR_DATE + 1) ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 675;
                    _DUR_HOUR = (ushort) ( (ALARMS._HOUR + _DUR_HOUR) ) ; 
                    __context__.SourceCodeLine = 676;
                    _DUR_MIN = (ushort) ( (ALARMS._MIN + _DUR_MIN) ) ; 
                    __context__.SourceCodeLine = 679;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _DUR_MIN >= 60 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 681;
                        _DUR_HOUR = (ushort) ( (_DUR_HOUR + 1) ) ; 
                        __context__.SourceCodeLine = 682;
                        _DUR_MIN = (ushort) ( (_DUR_MIN - 60) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 684;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _DUR_HOUR >= 24 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 686;
                        _DUR_HOUR = (ushort) ( (_DUR_HOUR - 24) ) ; 
                        __context__.SourceCodeLine = 687;
                        _DUR_DATE = (ushort) ( (_DUR_DATE + 1) ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 692;
                
                __context__.SourceCodeLine = 696;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _DUR_DATE <= _DATE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _DUR_HOUR < _HOUR ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_DUR_HOUR == _HOUR) ) && Functions.TestForTrue ( Functions.BoolToInt ( _DUR_MIN <= _MIN ) )) ) )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 697;
                    DISMISSALARM (  __context__  ) ; 
                    } 
                
                } 
            
            
            }
            
        private void CHECKALARMS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort _MIN = 0;
            ushort _HOUR = 0;
            
            
            __context__.SourceCodeLine = 707;
            
            __context__.SourceCodeLine = 714;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._DAYS[ (Functions.GetDayOfWeekNum() + 1) ] == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ENABLE == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SNOOZING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ACTIVE == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._HOUR == CUR_TIME._HOUR) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._MIN == CUR_TIME._MIN) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 717;
                ACTIVATEALARM (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 720;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ACTIVE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SNOOZING == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ENABLE == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 723;
                    _MIN = (ushort) ( (ALARMS._SNOOZE_MIN + ALARMS._SNOOZE_TIME) ) ; 
                    __context__.SourceCodeLine = 724;
                    _HOUR = (ushort) ( ALARMS._SNOOZE_HOUR ) ; 
                    __context__.SourceCodeLine = 727;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _MIN >= 60 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 729;
                        _MIN = (ushort) ( (_MIN - 60) ) ; 
                        __context__.SourceCodeLine = 729;
                        _HOUR = (ushort) ( (_HOUR + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 731;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _HOUR >= 24 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 732;
                        _HOUR = (ushort) ( (_HOUR - 24) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 734;
                    
                    __context__.SourceCodeLine = 739;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CUR_TIME._HOUR == _HOUR) ) && Functions.TestForTrue ( Functions.BoolToInt (CUR_TIME._MIN == _MIN) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 741;
                        ACTIVATEALARM (  __context__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 745;
                        
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 752;
            ALARMDURATIONCHECK (  __context__  ) ; 
            
            }
            
        private void SNOOZEALARMS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 758;
            
            __context__.SourceCodeLine = 762;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SOUNDING == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ACTIVE == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SNOOZING == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 765;
                
                __context__.SourceCodeLine = 770;
                ALARMS . _SOUNDING = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 771;
                ALARM_SOUNDING  .Value = (ushort) ( ALARMS._SOUNDING ) ; 
                __context__.SourceCodeLine = 772;
                ALARMS . _SNOOZING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 775;
                ALARMS . _SNOOZE_HOUR = (ushort) ( CUR_TIME._HOUR ) ; 
                __context__.SourceCodeLine = 776;
                ALARMS . _SNOOZE_MIN = (ushort) ( CUR_TIME._MIN ) ; 
                __context__.SourceCodeLine = 779;
                SHOW_SNOOZE_PAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 782;
                UPDATEALARM (  __context__  ) ; 
                } 
            
            
            }
            
        object OSC_CHANGE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort CHECK_ALARM_FLAG = 0;
                
                
                __context__.SourceCodeLine = 803;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CUR_TIME._MIN != Functions.GetMinutesNum()))  ) ) 
                    { 
                    __context__.SourceCodeLine = 805;
                    UPDATETIME (  __context__  ) ; 
                    __context__.SourceCodeLine = 806;
                    CHECKALARMS (  __context__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TIME_FORMAT_12_HOUR_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 813;
            SETTINGS . _12_HOUR_MODE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 814;
            SETTINGS . _24_HOUR_MODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 816;
            TIME_FORMAT_12_HOUR_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 817;
            TIME_FORMAT_24_HOUR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 819;
            UPDATEALARM (  __context__  ) ; 
            __context__.SourceCodeLine = 820;
            UPDATETIME (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TIME_FORMAT_24_HOUR_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 825;
        SETTINGS . _12_HOUR_MODE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 826;
        SETTINGS . _24_HOUR_MODE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 828;
        TIME_FORMAT_12_HOUR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 829;
        TIME_FORMAT_24_HOUR_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 831;
        UPDATEALARM (  __context__  ) ; 
        __context__.SourceCodeLine = 832;
        UPDATETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_FORMAT_TOGGLE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 838;
        SETTINGS . _12_HOUR_MODE = (ushort) ( Functions.Not( SETTINGS._12_HOUR_MODE ) ) ; 
        __context__.SourceCodeLine = 839;
        SETTINGS . _24_HOUR_MODE = (ushort) ( Functions.Not( SETTINGS._24_HOUR_MODE ) ) ; 
        __context__.SourceCodeLine = 841;
        TIME_FORMAT_12_HOUR_FB  .Value = (ushort) ( Functions.Not( TIME_FORMAT_12_HOUR_FB  .Value ) ) ; 
        __context__.SourceCodeLine = 842;
        TIME_FORMAT_24_HOUR_FB  .Value = (ushort) ( Functions.Not( TIME_FORMAT_24_HOUR_FB  .Value ) ) ; 
        __context__.SourceCodeLine = 844;
        UPDATEALARM (  __context__  ) ; 
        __context__.SourceCodeLine = 845;
        UPDATETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALARM_HOUR_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 849;
        ALARMS . _HOUR = (ushort) ( ALARM_HOUR_IN  .UshortValue ) ; 
        __context__.SourceCodeLine = 850;
        ALARMS . _MIN = (ushort) ( ALARM_MIN_IN  .UshortValue ) ; 
        __context__.SourceCodeLine = 851;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ACTIVE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 852;
            DISMISSALARM (  __context__  ) ; 
            }
        
        __context__.SourceCodeLine = 853;
        UPDATEALARM (  __context__  ) ; 
        __context__.SourceCodeLine = 854;
        SAVESETTINGS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALARM_MIN_IN_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 857;
        ALARMS . _HOUR = (ushort) ( ALARM_HOUR_IN  .UshortValue ) ; 
        __context__.SourceCodeLine = 858;
        ALARMS . _MIN = (ushort) ( ALARM_MIN_IN  .UshortValue ) ; 
        __context__.SourceCodeLine = 860;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._ACTIVE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 861;
            DISMISSALARM (  __context__  ) ; 
            }
        
        __context__.SourceCodeLine = 863;
        UPDATEALARM (  __context__  ) ; 
        __context__.SourceCodeLine = 864;
        SAVESETTINGS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_PLUS_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 868;
        ADJUSTTIME (  __context__ , (ushort)( 1 ), (ushort)( 0 ), (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_MINUS_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 872;
        ADJUSTTIME (  __context__ , (ushort)( 1 ), (ushort)( 0 ), (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MIN_PLUS_SLOW_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 885;
        ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 1 ), (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MIN_PLUS_FAST_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 889;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( ALARMS._MIN , 10 ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 890;
            ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 10 ), (ushort)( 1 )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 892;
            ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 1 ), (ushort)( 1 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MIN_MINUS_SLOW_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 895;
        ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 1 ), (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MIN_MINUS_FAST_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 899;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( ALARMS._MIN , 10 ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 900;
            ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 10 ), (ushort)( 0 )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 902;
            ADJUSTTIME (  __context__ , (ushort)( 0 ), (ushort)( 1 ), (ushort)( 0 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SNOOZE_PLUS_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 907;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._SNOOZE_TIME < MAX_SNOOZE_DURATION  .UshortValue ))  ) ) 
            {
            __context__.SourceCodeLine = 908;
            ALARMS . _SNOOZE_TIME = (ushort) ( (ALARMS._SNOOZE_TIME + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 910;
        SNOOZE_TIME  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._SNOOZE_TIME ) )  ) ; 
        __context__.SourceCodeLine = 911;
        SNOOZE_MIN  .Value = (ushort) ( ALARMS._SNOOZE_TIME ) ; 
        __context__.SourceCodeLine = 912;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SNOOZE_MINUS_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort MINS_SINCE_SNOOZE = 0;
        
        
        __context__.SourceCodeLine = 921;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._SNOOZING == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 923;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._SNOOZE_HOUR < CUR_TIME._HOUR ))  ) ) 
                {
                __context__.SourceCodeLine = 924;
                MINS_SINCE_SNOOZE = (ushort) ( ((((CUR_TIME._HOUR - ALARMS._SNOOZE_HOUR) * 60) + CUR_TIME._MIN) - ALARMS._SNOOZE_MIN) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 926;
                MINS_SINCE_SNOOZE = (ushort) ( (CUR_TIME._MIN - ALARMS._SNOOZE_MIN) ) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 929;
            MINS_SINCE_SNOOZE = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 931;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALARMS._SNOOZE_TIME > (MINS_SINCE_SNOOZE + MIN_SNOOZE_DURATION  .UshortValue) ))  ) ) 
            { 
            __context__.SourceCodeLine = 933;
            ALARMS . _SNOOZE_TIME = (ushort) ( (ALARMS._SNOOZE_TIME - 1) ) ; 
            __context__.SourceCodeLine = 934;
            SNOOZE_TIME  .UpdateValue ( Functions.ItoA (  (int) ( ALARMS._SNOOZE_TIME ) )  ) ; 
            } 
        
        __context__.SourceCodeLine = 937;
        SNOOZE_MIN  .Value = (ushort) ( ALARMS._SNOOZE_TIME ) ; 
        __context__.SourceCodeLine = 939;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DAYS_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDAY = 0;
        
        
        __context__.SourceCodeLine = 947;
        IDAY = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 949;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALARMS._DAYS[ IDAY ] == 1))  ) ) 
            {
            __context__.SourceCodeLine = 950;
            ALARMS . _DAYS [ IDAY] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 952;
            ALARMS . _DAYS [ IDAY] = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 955;
        DAYS_FB [ IDAY]  .Value = (ushort) ( ALARMS._DAYS[ IDAY ] ) ; 
        __context__.SourceCodeLine = 957;
        UPDATEALARM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALARM_1_TOGGLE_ON_OFF_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 964;
        ALARMS . _ENABLE = (ushort) ( Functions.Not( ALARMS._ENABLE ) ) ; 
        __context__.SourceCodeLine = 966;
        
        __context__.SourceCodeLine = 970;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._ENABLE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SNOOZING == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (ALARMS._SOUNDING == 1) )) ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 971;
            DISMISSALARM (  __context__  ) ; 
            }
        
        __context__.SourceCodeLine = 974;
        UPDATEALARM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SNOOZE_ALARM_OnRelease_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 980;
        SNOOZEALARMS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISMISS_ALARM_OnRelease_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 985;
        DISMISSALARM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_SETTINGS_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 990;
        SAVESETTINGS (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 995;
        INITIALIZATION_COMPLETE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 997;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 999;
        LOADSETTINGS (  __context__  ) ; 
        __context__.SourceCodeLine = 1000;
        UPDATETIME (  __context__  ) ; 
        __context__.SourceCodeLine = 1001;
        UPDATEALARM (  __context__  ) ; 
        __context__.SourceCodeLine = 1003;
        INITIALIZATION_COMPLETE  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    ALARM_1_TIME  = new CrestronString( InheritedStringEncoding, 30, this );
    CUR_TIME  = new STTIME( this, true );
    CUR_TIME .PopulateCustomAttributeList( false );
    ALARMS  = new STALARM( this, true );
    ALARMS .PopulateCustomAttributeList( false );
    SETTINGS  = new STSETTINGS( this, true );
    SETTINGS .PopulateCustomAttributeList( false );
    
    OSC_CHANGE = new Crestron.Logos.SplusObjects.DigitalInput( OSC_CHANGE__DigitalInput__, this );
    m_DigitalInputList.Add( OSC_CHANGE__DigitalInput__, OSC_CHANGE );
    
    HOUR_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_PLUS__DigitalInput__, HOUR_PLUS );
    
    HOUR_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_MINUS__DigitalInput__, HOUR_MINUS );
    
    MIN_PLUS_SLOW = new Crestron.Logos.SplusObjects.DigitalInput( MIN_PLUS_SLOW__DigitalInput__, this );
    m_DigitalInputList.Add( MIN_PLUS_SLOW__DigitalInput__, MIN_PLUS_SLOW );
    
    MIN_PLUS_FAST = new Crestron.Logos.SplusObjects.DigitalInput( MIN_PLUS_FAST__DigitalInput__, this );
    m_DigitalInputList.Add( MIN_PLUS_FAST__DigitalInput__, MIN_PLUS_FAST );
    
    MIN_MINUS_SLOW = new Crestron.Logos.SplusObjects.DigitalInput( MIN_MINUS_SLOW__DigitalInput__, this );
    m_DigitalInputList.Add( MIN_MINUS_SLOW__DigitalInput__, MIN_MINUS_SLOW );
    
    MIN_MINUS_FAST = new Crestron.Logos.SplusObjects.DigitalInput( MIN_MINUS_FAST__DigitalInput__, this );
    m_DigitalInputList.Add( MIN_MINUS_FAST__DigitalInput__, MIN_MINUS_FAST );
    
    SNOOZE_PLUS = new Crestron.Logos.SplusObjects.DigitalInput( SNOOZE_PLUS__DigitalInput__, this );
    m_DigitalInputList.Add( SNOOZE_PLUS__DigitalInput__, SNOOZE_PLUS );
    
    SNOOZE_MINUS = new Crestron.Logos.SplusObjects.DigitalInput( SNOOZE_MINUS__DigitalInput__, this );
    m_DigitalInputList.Add( SNOOZE_MINUS__DigitalInput__, SNOOZE_MINUS );
    
    SNOOZE_ALARM = new Crestron.Logos.SplusObjects.DigitalInput( SNOOZE_ALARM__DigitalInput__, this );
    m_DigitalInputList.Add( SNOOZE_ALARM__DigitalInput__, SNOOZE_ALARM );
    
    DISMISS_ALARM = new Crestron.Logos.SplusObjects.DigitalInput( DISMISS_ALARM__DigitalInput__, this );
    m_DigitalInputList.Add( DISMISS_ALARM__DigitalInput__, DISMISS_ALARM );
    
    ALARM_1_TOGGLE_ON_OFF = new Crestron.Logos.SplusObjects.DigitalInput( ALARM_1_TOGGLE_ON_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( ALARM_1_TOGGLE_ON_OFF__DigitalInput__, ALARM_1_TOGGLE_ON_OFF );
    
    TIME_FORMAT_12_HOUR = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT_12_HOUR__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT_12_HOUR__DigitalInput__, TIME_FORMAT_12_HOUR );
    
    TIME_FORMAT_24_HOUR = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT_24_HOUR__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT_24_HOUR__DigitalInput__, TIME_FORMAT_24_HOUR );
    
    SAVE_SETTINGS = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_SETTINGS__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_SETTINGS__DigitalInput__, SAVE_SETTINGS );
    
    TIME_FORMAT_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( TIME_FORMAT_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_FORMAT_TOGGLE__DigitalInput__, TIME_FORMAT_TOGGLE );
    
    DAYS = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        DAYS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DAYS__DigitalInput__ + i, DAYS__DigitalInput__, this );
        m_DigitalInputList.Add( DAYS__DigitalInput__ + i, DAYS[i+1] );
    }
    
    CUR_ALARM_AM_FB = new Crestron.Logos.SplusObjects.DigitalOutput( CUR_ALARM_AM_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( CUR_ALARM_AM_FB__DigitalOutput__, CUR_ALARM_AM_FB );
    
    CUR_ALARM_PM_FB = new Crestron.Logos.SplusObjects.DigitalOutput( CUR_ALARM_PM_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( CUR_ALARM_PM_FB__DigitalOutput__, CUR_ALARM_PM_FB );
    
    SHOW_SNOOZE_PAGE = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_SNOOZE_PAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_SNOOZE_PAGE__DigitalOutput__, SHOW_SNOOZE_PAGE );
    
    SHOW_DISMISS_ALARM_PAGE = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_DISMISS_ALARM_PAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_DISMISS_ALARM_PAGE__DigitalOutput__, SHOW_DISMISS_ALARM_PAGE );
    
    TIME_FORMAT_12_HOUR_FB = new Crestron.Logos.SplusObjects.DigitalOutput( TIME_FORMAT_12_HOUR_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( TIME_FORMAT_12_HOUR_FB__DigitalOutput__, TIME_FORMAT_12_HOUR_FB );
    
    TIME_FORMAT_24_HOUR_FB = new Crestron.Logos.SplusObjects.DigitalOutput( TIME_FORMAT_24_HOUR_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( TIME_FORMAT_24_HOUR_FB__DigitalOutput__, TIME_FORMAT_24_HOUR_FB );
    
    ALARM_LIGHTS = new Crestron.Logos.SplusObjects.DigitalOutput( ALARM_LIGHTS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALARM_LIGHTS__DigitalOutput__, ALARM_LIGHTS );
    
    ALARM_SOUNDING = new Crestron.Logos.SplusObjects.DigitalOutput( ALARM_SOUNDING__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALARM_SOUNDING__DigitalOutput__, ALARM_SOUNDING );
    
    INITIALIZATION_COMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZATION_COMPLETE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZATION_COMPLETE__DigitalOutput__, INITIALIZATION_COMPLETE );
    
    DAYS_FB = new InOutArray<DigitalOutput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        DAYS_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DAYS_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DAYS_FB__DigitalOutput__ + i, DAYS_FB[i+1] );
    }
    
    ALARM_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( ALARM_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ALARM_DURATION__AnalogSerialInput__, ALARM_DURATION );
    
    ALARM_HOUR_IN = new Crestron.Logos.SplusObjects.AnalogInput( ALARM_HOUR_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ALARM_HOUR_IN__AnalogSerialInput__, ALARM_HOUR_IN );
    
    ALARM_MIN_IN = new Crestron.Logos.SplusObjects.AnalogInput( ALARM_MIN_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ALARM_MIN_IN__AnalogSerialInput__, ALARM_MIN_IN );
    
    MAX_SNOOZE_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( MAX_SNOOZE_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_SNOOZE_DURATION__AnalogSerialInput__, MAX_SNOOZE_DURATION );
    
    MIN_SNOOZE_DURATION = new Crestron.Logos.SplusObjects.AnalogInput( MIN_SNOOZE_DURATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MIN_SNOOZE_DURATION__AnalogSerialInput__, MIN_SNOOZE_DURATION );
    
    ALARM_HOUR = new Crestron.Logos.SplusObjects.AnalogOutput( ALARM_HOUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ALARM_HOUR__AnalogSerialOutput__, ALARM_HOUR );
    
    ALARM_MIN = new Crestron.Logos.SplusObjects.AnalogOutput( ALARM_MIN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ALARM_MIN__AnalogSerialOutput__, ALARM_MIN );
    
    SNOOZE_MIN = new Crestron.Logos.SplusObjects.AnalogOutput( SNOOZE_MIN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SNOOZE_MIN__AnalogSerialOutput__, SNOOZE_MIN );
    
    FILE_NAME = new Crestron.Logos.SplusObjects.StringInput( FILE_NAME__AnalogSerialInput__, 25, this );
    m_StringInputList.Add( FILE_NAME__AnalogSerialInput__, FILE_NAME );
    
    INSTANCE_ID = new Crestron.Logos.SplusObjects.StringInput( INSTANCE_ID__AnalogSerialInput__, 5, this );
    m_StringInputList.Add( INSTANCE_ID__AnalogSerialInput__, INSTANCE_ID );
    
    FILE_LOCATION = new Crestron.Logos.SplusObjects.StringInput( FILE_LOCATION__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FILE_LOCATION__AnalogSerialInput__, FILE_LOCATION );
    
    CUR_TIME_OUT = new Crestron.Logos.SplusObjects.StringOutput( CUR_TIME_OUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CUR_TIME_OUT__AnalogSerialOutput__, CUR_TIME_OUT );
    
    CUR_ALARM_TIME = new Crestron.Logos.SplusObjects.StringOutput( CUR_ALARM_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CUR_ALARM_TIME__AnalogSerialOutput__, CUR_ALARM_TIME );
    
    NEXT_ALARM_TIME = new Crestron.Logos.SplusObjects.StringOutput( NEXT_ALARM_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NEXT_ALARM_TIME__AnalogSerialOutput__, NEXT_ALARM_TIME );
    
    SNOOZE_TIME = new Crestron.Logos.SplusObjects.StringOutput( SNOOZE_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SNOOZE_TIME__AnalogSerialOutput__, SNOOZE_TIME );
    
    ALARM_STATUS = new Crestron.Logos.SplusObjects.StringOutput( ALARM_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ALARM_STATUS__AnalogSerialOutput__, ALARM_STATUS );
    
    
    OSC_CHANGE.OnDigitalChange.Add( new InputChangeHandlerWrapper( OSC_CHANGE_OnChange_0, false ) );
    TIME_FORMAT_12_HOUR.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_FORMAT_12_HOUR_OnPush_1, false ) );
    TIME_FORMAT_24_HOUR.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_FORMAT_24_HOUR_OnPush_2, false ) );
    TIME_FORMAT_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_FORMAT_TOGGLE_OnPush_3, false ) );
    ALARM_HOUR_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( ALARM_HOUR_IN_OnChange_4, false ) );
    ALARM_MIN_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( ALARM_MIN_IN_OnChange_5, false ) );
    HOUR_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_PLUS_OnPush_6, false ) );
    HOUR_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_MINUS_OnPush_7, false ) );
    MIN_PLUS_SLOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( MIN_PLUS_SLOW_OnPush_8, false ) );
    MIN_PLUS_FAST.OnDigitalPush.Add( new InputChangeHandlerWrapper( MIN_PLUS_FAST_OnPush_9, false ) );
    MIN_MINUS_SLOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( MIN_MINUS_SLOW_OnPush_10, false ) );
    MIN_MINUS_FAST.OnDigitalPush.Add( new InputChangeHandlerWrapper( MIN_MINUS_FAST_OnPush_11, false ) );
    SNOOZE_PLUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SNOOZE_PLUS_OnPush_12, false ) );
    SNOOZE_MINUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SNOOZE_MINUS_OnPush_13, false ) );
    for( uint i = 0; i < 7; i++ )
        DAYS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DAYS_OnPush_14, false ) );
        
    ALARM_1_TOGGLE_ON_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ALARM_1_TOGGLE_ON_OFF_OnPush_15, false ) );
    SNOOZE_ALARM.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SNOOZE_ALARM_OnRelease_16, false ) );
    DISMISS_ALARM.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DISMISS_ALARM_OnRelease_17, false ) );
    SAVE_SETTINGS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_SETTINGS_OnPush_18, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_ALARM_CLOCK_PROCESSOR_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint OSC_CHANGE__DigitalInput__ = 0;
const uint FILE_NAME__AnalogSerialInput__ = 0;
const uint HOUR_PLUS__DigitalInput__ = 1;
const uint HOUR_MINUS__DigitalInput__ = 2;
const uint MIN_PLUS_SLOW__DigitalInput__ = 3;
const uint MIN_PLUS_FAST__DigitalInput__ = 4;
const uint MIN_MINUS_SLOW__DigitalInput__ = 5;
const uint MIN_MINUS_FAST__DigitalInput__ = 6;
const uint SNOOZE_PLUS__DigitalInput__ = 7;
const uint SNOOZE_MINUS__DigitalInput__ = 8;
const uint SNOOZE_ALARM__DigitalInput__ = 9;
const uint DISMISS_ALARM__DigitalInput__ = 10;
const uint ALARM_1_TOGGLE_ON_OFF__DigitalInput__ = 11;
const uint TIME_FORMAT_12_HOUR__DigitalInput__ = 12;
const uint TIME_FORMAT_24_HOUR__DigitalInput__ = 13;
const uint SAVE_SETTINGS__DigitalInput__ = 14;
const uint TIME_FORMAT_TOGGLE__DigitalInput__ = 15;
const uint ALARM_DURATION__AnalogSerialInput__ = 1;
const uint ALARM_HOUR_IN__AnalogSerialInput__ = 2;
const uint ALARM_MIN_IN__AnalogSerialInput__ = 3;
const uint MAX_SNOOZE_DURATION__AnalogSerialInput__ = 4;
const uint MIN_SNOOZE_DURATION__AnalogSerialInput__ = 5;
const uint INSTANCE_ID__AnalogSerialInput__ = 6;
const uint FILE_LOCATION__AnalogSerialInput__ = 7;
const uint DAYS__DigitalInput__ = 16;
const uint CUR_TIME_OUT__AnalogSerialOutput__ = 0;
const uint CUR_ALARM_TIME__AnalogSerialOutput__ = 1;
const uint CUR_ALARM_AM_FB__DigitalOutput__ = 0;
const uint CUR_ALARM_PM_FB__DigitalOutput__ = 1;
const uint NEXT_ALARM_TIME__AnalogSerialOutput__ = 2;
const uint ALARM_HOUR__AnalogSerialOutput__ = 3;
const uint ALARM_MIN__AnalogSerialOutput__ = 4;
const uint SNOOZE_MIN__AnalogSerialOutput__ = 5;
const uint SNOOZE_TIME__AnalogSerialOutput__ = 6;
const uint SHOW_SNOOZE_PAGE__DigitalOutput__ = 2;
const uint SHOW_DISMISS_ALARM_PAGE__DigitalOutput__ = 3;
const uint TIME_FORMAT_12_HOUR_FB__DigitalOutput__ = 4;
const uint TIME_FORMAT_24_HOUR_FB__DigitalOutput__ = 5;
const uint ALARM_STATUS__AnalogSerialOutput__ = 7;
const uint ALARM_LIGHTS__DigitalOutput__ = 6;
const uint ALARM_SOUNDING__DigitalOutput__ = 7;
const uint INITIALIZATION_COMPLETE__DigitalOutput__ = 8;
const uint DAYS_FB__DigitalOutput__ = 9;

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

[SplusStructAttribute(-1, true, false)]
public class STTIME : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _HOUR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _MIN = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _DATE = 0;
    
    
    public STTIME( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class STALARM : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _HOUR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _MIN = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _ENABLE = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _SNOOZE_TIME = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  [] _DAYS;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _SNOOZING = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  _SNOOZE_HOUR = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  _SNOOZE_MIN = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  _ACTIVE = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  _SOUNDING = 0;
    
    [SplusStructAttribute(10, false, false)]
    public ushort  _AM = 0;
    
    [SplusStructAttribute(11, false, false)]
    public ushort  _PM = 0;
    
    
    public STALARM( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _DAYS  = new ushort[ 8 ];
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class STSETTINGS : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _12_HOUR_MODE = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _24_HOUR_MODE = 0;
    
    
    public STSETTINGS( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}

}
