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

namespace UserModule_NV_ANALOG_TO_DISK
{
    public class UserModuleClass_NV_ANALOG_TO_DISK : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput INSTANCE_ID;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> IN;
        Crestron.Logos.SplusObjects.DigitalOutput FILEOP_BUSY;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUT;
        ushort GDEFINEDINPUTS = 0;
        ushort GSTARTUP = 0;
        ushort GTHREAD = 0;
        ushort [] GVALUE;
        CrestronString GFILEPATH__DOLLAR__;
        private void SAVEVALUES (  SplusExecutionContext __context__ ) 
            { 
            short IHANDLE = 0;
            short IRESULT = 0;
            
            
            __context__.SourceCodeLine = 112;
            FILEOP_BUSY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 113;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 115;
            IHANDLE = (short) ( FileOpen( GFILEPATH__DOLLAR__ ,(ushort) ((1 | 256) | 512) ) ) ; 
            __context__.SourceCodeLine = 117;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 118;
                IRESULT = (short) ( WriteIntegerArray( (short)( IHANDLE ) , GVALUE ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 120;
                GenerateUserError ( "Unable to open file for writing") ; 
                }
            
            __context__.SourceCodeLine = 122;
            FileClose (  (short) ( IHANDLE ) ) ; 
            __context__.SourceCodeLine = 124;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 125;
            FILEOP_BUSY  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void RECALLVALUES (  SplusExecutionContext __context__ ) 
            { 
            short IHANDLE = 0;
            short IRESULT = 0;
            
            
            __context__.SourceCodeLine = 132;
            FILEOP_BUSY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 133;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 135;
            IHANDLE = (short) ( FileOpen( GFILEPATH__DOLLAR__ ,(ushort) 0 ) ) ; 
            __context__.SourceCodeLine = 137;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 138;
                IRESULT = (short) ( ReadIntegerArray( (short)( IHANDLE ) , ref GVALUE ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 140;
                GenerateUserError ( "Unable to open file for reading") ; 
                }
            
            __context__.SourceCodeLine = 142;
            FileClose (  (short) ( IHANDLE ) ) ; 
            __context__.SourceCodeLine = 144;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 145;
            FILEOP_BUSY  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort IINDEX = 0;
                ushort ITHREAD = 0;
                
                
                __context__.SourceCodeLine = 156;
                if ( Functions.TestForTrue  ( ( GSTARTUP)  ) ) 
                    {
                    __context__.SourceCodeLine = 157;
                    Functions.TerminateEvent (); 
                    }
                
                __context__.SourceCodeLine = 159;
                IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 161;
                GVALUE [ IINDEX] = (ushort) ( IN[ IINDEX ] .UshortValue ) ; 
                __context__.SourceCodeLine = 163;
                GTHREAD = (ushort) ( (GTHREAD + Mod( 1 , 256 )) ) ; 
                __context__.SourceCodeLine = 164;
                ITHREAD = (ushort) ( GTHREAD ) ; 
                __context__.SourceCodeLine = 166;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITHREAD == GTHREAD))  ) ) 
                    {
                    __context__.SourceCodeLine = 169;
                    SAVEVALUES (  __context__  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        ushort I = 0;
        
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 179;
            GSTARTUP = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 181;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 183;
            GFILEPATH__DOLLAR__  .UpdateValue ( "\\NVRAM\\Analogs" + Functions.ItoA (  (int) ( INSTANCE_ID  .UshortValue ) ) + ".dat"  ) ; 
            __context__.SourceCodeLine = 186;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 50 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( GDEFINEDINPUTS  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (GDEFINEDINPUTS  >= __FN_FORSTART_VAL__1) && (GDEFINEDINPUTS  <= __FN_FOREND_VAL__1) ) : ( (GDEFINEDINPUTS  <= __FN_FORSTART_VAL__1) && (GDEFINEDINPUTS  >= __FN_FOREND_VAL__1) ) ; GDEFINEDINPUTS  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 188;
                if ( Functions.TestForTrue  ( ( IsSignalDefined( IN[ GDEFINEDINPUTS ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 189;
                    break ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 191;
                    GVALUE [ GDEFINEDINPUTS] = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 186;
                } 
            
            __context__.SourceCodeLine = 194;
            GVALUE [ 0] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 196;
            Functions.Delay (  (int) ( 500 ) ) ; 
            __context__.SourceCodeLine = 198;
            RECALLVALUES (  __context__  ) ; 
            __context__.SourceCodeLine = 200;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)GDEFINEDINPUTS; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                {
                __context__.SourceCodeLine = 201;
                OUT [ I]  .Value = (ushort) ( GVALUE[ I ] ) ; 
                __context__.SourceCodeLine = 200;
                }
            
            __context__.SourceCodeLine = 203;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 205;
            GSTARTUP = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        GVALUE  = new ushort[ 51 ];
        GFILEPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
        
        FILEOP_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( FILEOP_BUSY__DigitalOutput__, this );
        m_DigitalOutputList.Add( FILEOP_BUSY__DigitalOutput__, FILEOP_BUSY );
        
        INSTANCE_ID = new Crestron.Logos.SplusObjects.AnalogInput( INSTANCE_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INSTANCE_ID__AnalogSerialInput__, INSTANCE_ID );
        
        IN = new InOutArray<AnalogInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( IN__AnalogSerialInput__ + i, IN__AnalogSerialInput__, this );
            m_AnalogInputList.Add( IN__AnalogSerialInput__ + i, IN[i+1] );
        }
        
        OUT = new InOutArray<AnalogOutput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUT__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( OUT__AnalogSerialOutput__ + i, OUT[i+1] );
        }
        
        
        for( uint i = 0; i < 50; i++ )
            IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( IN_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_NV_ANALOG_TO_DISK ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INSTANCE_ID__AnalogSerialInput__ = 0;
    const uint IN__AnalogSerialInput__ = 1;
    const uint FILEOP_BUSY__DigitalOutput__ = 0;
    const uint OUT__AnalogSerialOutput__ = 0;
    
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
