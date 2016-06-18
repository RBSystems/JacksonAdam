[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.03.11
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
  Cmn1=This module is designed to be used inside of the "Analog Increment||1
  Cmn2=with Variable Limits" module.\\Please see that module's help for||1
  Cmn3=more details.\\\\Revision History\\================\\v1.0.0\\---
  Cmn4=---\\-initial release\\
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=Analog Increment with Variable Limits (driver) v1.0.0 (cm)
  SmplCName=Analog Increment with Variable Limits (driver).csp
  Code=1
  SysRev5=4.000
  SMWRev=2.02.05
  InputCue1=diUp
  InputSigType1=Digital
  InputCue2=diDown
  InputSigType2=Digital
  InputCue3=diMute
  InputSigType3=Digital
  InputList2Cue1=aiIncrement
  InputList2SigType1=Analog
  InputList2Cue2=aiLowerLimit
  InputList2SigType2=Analog
  InputList2Cue3=aiUpperLimit
  InputList2SigType3=Analog
  InputList2Cue4=aiMuteLevel
  InputList2SigType4=Analog
  OutputList2Cue1=aoLevel
  OutputList2SigType1=Analog
  ParamCue1=[Reference Name]
  MinVariableInputs=3
  MaxVariableInputs=3
  MinVariableInputsList2=4
  MaxVariableInputsList2=4
  MinVariableOutputs=0
  MaxVariableOutputs=0
  MinVariableOutputsList2=1
  MaxVariableOutputsList2=1
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=0
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_Analog_Increment_with_Variable_Limits__driver_
  SymJam=NonExclusive
  FileName=Analog Increment with Variable Limits (driver).csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
