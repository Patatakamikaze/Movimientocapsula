//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("uMovimiento", "")]
public class uMovimiento : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.Vector3 Direcciones = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_10_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_6_System_Single = (float) 0;
   System.Single local_9_System_Single = (float) 0;
   public System.Single Speed = (float) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_11 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_0 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_0 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_0 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_XMin_0 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_XMax_0 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_0 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_YMin_0 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_YMax_0 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampZ_0 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_ZMin_0 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_ZMax_0 = (float) 1;
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Result_0;
   bool logic_uScriptAct_ClampVector3_Out_0 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_3 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_3 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_3 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_3;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_5 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_5;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_5;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_5;
   bool logic_uScriptAct_GetDeltaTime_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_7 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_7 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_7;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_7;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_7 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_8 = new Vector3( );
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_11 || false == m_RegisteredForEvents )
      {
         owner_Connection_11 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_4 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_4 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_4 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_4.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_4;
                  component.OnLateUpdate += Instance_OnLateUpdate_4;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_4;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_4 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_4;
               component.OnLateUpdate -= Instance_OnLateUpdate_4;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_4;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_0.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_3.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_5.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.SetParent(g);
      owner_Connection_11 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3e1b961-3561-430d-83a6-36980e094269", "Clamp_Vector3", Relay_In_0)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_0 = Direcciones;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_0.In(logic_uScriptAct_ClampVector3_Target_0, logic_uScriptAct_ClampVector3_ClampX_0, logic_uScriptAct_ClampVector3_XMin_0, logic_uScriptAct_ClampVector3_XMax_0, logic_uScriptAct_ClampVector3_ClampY_0, logic_uScriptAct_ClampVector3_YMin_0, logic_uScriptAct_ClampVector3_YMax_0, logic_uScriptAct_ClampVector3_ClampZ_0, logic_uScriptAct_ClampVector3_ZMin_0, logic_uScriptAct_ClampVector3_ZMax_0, out logic_uScriptAct_ClampVector3_Result_0);
         Direcciones = logic_uScriptAct_ClampVector3_Result_0;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_0.Out;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript uMovimiento.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("247167bf-88ea-4c5c-8641-4f35fbe871a2", "Multiply_Vector3_With_Float", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_3 = Direcciones;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_3 = local_9_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_3.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_3, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_3, out logic_uScriptAct_MultiplyVector3WithFloat_Result_3);
         local_10_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_3.Out;
         
         if ( test_0 == true )
         {
            Relay_Translate_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript uMovimiento.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_4()
   {
      if (true == CheckDebugBreak("6e687165-d460-49a1-ba03-9a608ee0b746", "Global_Update", Relay_OnUpdate_4)) return; 
      Relay_In_0();
   }
   
   void Relay_OnLateUpdate_4()
   {
      if (true == CheckDebugBreak("6e687165-d460-49a1-ba03-9a608ee0b746", "Global_Update", Relay_OnLateUpdate_4)) return; 
   }
   
   void Relay_OnFixedUpdate_4()
   {
      if (true == CheckDebugBreak("6e687165-d460-49a1-ba03-9a608ee0b746", "Global_Update", Relay_OnFixedUpdate_4)) return; 
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a83599bf-53d6-4dfd-b945-d4de83f83281", "Get_Delta_Time", Relay_In_5)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_5.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_5, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_5, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_5);
         local_6_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_5;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_5.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript uMovimiento.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3f074ec6-632d-4cfc-ac3f-635ca91b6a41", "Multiply_Float", Relay_In_7)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_7 = Speed;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_7 = local_6_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.In(logic_uScriptAct_MultiplyFloat_v2_A_7, logic_uScriptAct_MultiplyFloat_v2_B_7, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_7, out logic_uScriptAct_MultiplyFloat_v2_IntResult_7);
         local_9_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript uMovimiento.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("162bd196-7405-4629-b749-0214ebfde885", "UnityEngine_Transform", Relay_Translate_8)) return; 
         {
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_8 = local_10_UnityEngine_Vector3;
               
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_11.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_8);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript uMovimiento.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "uMovimiento.uscript:Speed", Speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e0b70b15-6010-4dd0-bfa1-e97ed7c1efa2", Speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "uMovimiento.uscript:Direcciones", Direcciones);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2bd30532-3fc5-4adb-b8fc-1663b4cba3f8", Direcciones);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "uMovimiento.uscript:6", local_6_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "78198a3d-512c-45d8-b43d-384aa92ae205", local_6_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "uMovimiento.uscript:9", local_9_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "8d49a49a-a8dd-40f7-bad8-e70dab7c3192", local_9_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "uMovimiento.uscript:10", local_10_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "330c7cec-758b-4ca8-9231-e5640b460e2c", local_10_UnityEngine_Vector3);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
