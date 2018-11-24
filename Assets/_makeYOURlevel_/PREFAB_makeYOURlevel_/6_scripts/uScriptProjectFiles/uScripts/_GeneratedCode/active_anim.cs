//uScript Generated Code - Build 0.9.1910
//Generated with Debug Info
using UnityEngine;
using System.Collections;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class active_anim : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   //external output properties
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String[] local_3_System_StringArray = new System.String[] {};
   System.String local_4_System_String = "";
   System.Object local_6_System_Object = "";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_10 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_0 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_0 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_0 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_0 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_0 = (bool) false;
   bool logic_uScriptAct_PlayAnimation_Out_0 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_1 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_1 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_1 = (float) -1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_1 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_1 = (bool) false;
   bool logic_uScriptAct_PlayAnimation_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimations logic_uScriptAct_GetAnimations_uScriptAct_GetAnimations_2 = new uScriptAct_GetAnimations( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimations_Target_2 = null;
   System.String logic_uScriptAct_GetAnimations_Filter_2 = "";
   System.String[] logic_uScriptAct_GetAnimations_Animations_2;
   bool logic_uScriptAct_GetAnimations_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetObjectFromList logic_uScriptAct_GetObjectFromList_uScriptAct_GetObjectFromList_5 = new uScriptAct_GetObjectFromList( );
   System.Object[] logic_uScriptAct_GetObjectFromList_list_5 = new System.Object[] {};
   System.Int32 logic_uScriptAct_GetObjectFromList_index_5 = (int) 1;
   System.Object logic_uScriptAct_GetObjectFromList_item_5;
   bool logic_uScriptAct_GetObjectFromList_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_ConvertListToString logic_uScriptAct_ConvertListToString_uScriptAct_ConvertListToString_7 = new uScriptAct_ConvertListToString( );
   System.Object[] logic_uScriptAct_ConvertListToString_Target_7 = new System.Object[] {};
   System.String logic_uScriptAct_ConvertListToString_Delimiter_7 = ",";
   System.Boolean logic_uScriptAct_ConvertListToString_CleanNames_7 = (bool) true;
   System.String logic_uScriptAct_ConvertListToString_Result_7;
   bool logic_uScriptAct_ConvertListToString_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_8 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_8 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_8;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_8;
   System.Single logic_uScriptAct_GetAnimationState_animLength_8;
   System.Single logic_uScriptAct_GetAnimationState_speed_8;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_8;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_8;
   bool logic_uScriptAct_GetAnimationState_Out_8 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_11 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_11 = null;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_10 )
      {
         owner_Connection_10 = parentGameObject;
         if ( null != owner_Connection_10 )
         {
            {
               uScript_Triggers component = owner_Connection_10.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_10.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_11;
               }
            }
            {
               uScript_Triggers component = owner_Connection_10.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_10.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_11;
                  component.OnExitTrigger += Instance_OnExitTrigger_11;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_11;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_10 )
      {
         {
            uScript_Triggers component = owner_Connection_10.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_11;
               component.OnExitTrigger -= Instance_OnExitTrigger_11;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_11;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1.SetParent(g);
      logic_uScriptAct_GetAnimations_uScriptAct_GetAnimations_2.SetParent(g);
      logic_uScriptAct_GetObjectFromList_uScriptAct_GetObjectFromList_5.SetParent(g);
      logic_uScriptAct_ConvertListToString_uScriptAct_ConvertListToString_7.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0.Finished += uScriptAct_PlayAnimation_Finished_0;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1.Finished += uScriptAct_PlayAnimation_Finished_1;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      
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
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1.Update( );
   }
   
   public void OnDestroy()
   {
      UnregisterEventListeners( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0.Finished -= uScriptAct_PlayAnimation_Finished_0;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1.Finished -= uScriptAct_PlayAnimation_Finished_1;
   }
   
   void Instance_OnEnterTrigger_11(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_11 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_11( );
   }
   
   void Instance_OnExitTrigger_11(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_11 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_11( );
   }
   
   void Instance_WhileInsideTrigger_11(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_11 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_11( );
   }
   
   void uScriptAct_PlayAnimation_Finished_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_0( );
   }
   
   void uScriptAct_PlayAnimation_Finished_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_1( );
   }
   
   void Relay_Finished_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("65fcf456-0f17-47c2-918b-bf3a33ae8cc9", "Play Animation", Relay_Finished_0)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Play Animation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("65fcf456-0f17-47c2-918b-bf3a33ae8cc9", "Play Animation", Relay_In_0)) return; 
         {
            int index;
            index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_0.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_0, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_0[ index++ ] = owner_Connection_10;
            
            logic_uScriptAct_PlayAnimation_Animation_0 = local_4_System_String;
            
         }
         logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_0.In(logic_uScriptAct_PlayAnimation_Target_0, logic_uScriptAct_PlayAnimation_Animation_0, logic_uScriptAct_PlayAnimation_SpeedFactor_0, logic_uScriptAct_PlayAnimation_AnimWrapMode_0, logic_uScriptAct_PlayAnimation_StopOtherAnimations_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Play Animation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0bb51c13-20fa-4fd1-b306-aae2107b1cac", "Play Animation", Relay_Finished_1)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Play Animation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0bb51c13-20fa-4fd1-b306-aae2107b1cac", "Play Animation", Relay_In_1)) return; 
         {
            int index;
            index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_1, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_1[ index++ ] = owner_Connection_10;
            
            logic_uScriptAct_PlayAnimation_Animation_1 = local_4_System_String;
            
         }
         logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_1.In(logic_uScriptAct_PlayAnimation_Target_1, logic_uScriptAct_PlayAnimation_Animation_1, logic_uScriptAct_PlayAnimation_SpeedFactor_1, logic_uScriptAct_PlayAnimation_AnimWrapMode_1, logic_uScriptAct_PlayAnimation_StopOtherAnimations_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Play Animation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("78e98396-86b9-4fa4-b790-d9af79ce8535", "Get Animations", Relay_In_2)) return; 
         {
            logic_uScriptAct_GetAnimations_Target_2 = owner_Connection_10;
            
         }
         logic_uScriptAct_GetAnimations_uScriptAct_GetAnimations_2.In(logic_uScriptAct_GetAnimations_Target_2, logic_uScriptAct_GetAnimations_Filter_2, out logic_uScriptAct_GetAnimations_Animations_2);
         local_3_System_StringArray = logic_uScriptAct_GetAnimations_Animations_2;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetAnimations_uScriptAct_GetAnimations_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Get Animations.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2cb8c65f-8e10-445b-bb12-740ca48d6dce", "Get Object From List", Relay_In_5)) return; 
         {
            int index;
            System.Array properties;
            index = 0;
            properties = null;
            properties = local_3_System_StringArray;
            if ( logic_uScriptAct_GetObjectFromList_list_5.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_GetObjectFromList_list_5, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_GetObjectFromList_list_5, index, properties.Length);
            index += properties.Length;
            
         }
         logic_uScriptAct_GetObjectFromList_uScriptAct_GetObjectFromList_5.In(logic_uScriptAct_GetObjectFromList_list_5, logic_uScriptAct_GetObjectFromList_index_5, out logic_uScriptAct_GetObjectFromList_item_5);
         local_6_System_Object = logic_uScriptAct_GetObjectFromList_item_5;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetObjectFromList_uScriptAct_GetObjectFromList_5.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Get Object From List.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("78da6ba5-62de-4772-b227-13d1fe675ae1", "Convert List to String", Relay_In_7)) return; 
         {
            int index;
            index = 0;
            if ( logic_uScriptAct_ConvertListToString_Target_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_ConvertListToString_Target_7, index + 1);
            }
            logic_uScriptAct_ConvertListToString_Target_7[ index++ ] = local_6_System_Object;
            
         }
         logic_uScriptAct_ConvertListToString_uScriptAct_ConvertListToString_7.In(logic_uScriptAct_ConvertListToString_Target_7, logic_uScriptAct_ConvertListToString_Delimiter_7, logic_uScriptAct_ConvertListToString_CleanNames_7, out logic_uScriptAct_ConvertListToString_Result_7);
         local_4_System_String = logic_uScriptAct_ConvertListToString_Result_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ConvertListToString_uScriptAct_ConvertListToString_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_0();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Convert List to String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bb6bde5b-b7a9-4d38-b42c-ac4e65bdebfb", "Get Animation State", Relay_In_8)) return; 
         {
            logic_uScriptAct_GetAnimationState_target_8 = owner_Connection_10;
            
            logic_uScriptAct_GetAnimationState_animationName_8 = local_4_System_String;
            
         }
         logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.In(logic_uScriptAct_GetAnimationState_target_8, logic_uScriptAct_GetAnimationState_animationName_8, out logic_uScriptAct_GetAnimationState_weight_8, out logic_uScriptAct_GetAnimationState_normalizedPosition_8, out logic_uScriptAct_GetAnimationState_animLength_8, out logic_uScriptAct_GetAnimationState_speed_8, out logic_uScriptAct_GetAnimationState_layer_8, out logic_uScriptAct_GetAnimationState_wrapMode_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript active_anim.uscript at Get Animation State.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnEnterTrigger_11()
   {
      if (true == CheckDebugBreak("80d1336b-eade-4916-a717-e1550bec753d", "Trigger Events", Relay_OnEnterTrigger_11)) return; 
      Relay_In_2();
   }
   
   void Relay_OnExitTrigger_11()
   {
      if (true == CheckDebugBreak("80d1336b-eade-4916-a717-e1550bec753d", "Trigger Events", Relay_OnExitTrigger_11)) return; 
      Relay_In_8();
   }
   
   void Relay_WhileInsideTrigger_11()
   {
      if (true == CheckDebugBreak("80d1336b-eade-4916-a717-e1550bec753d", "Trigger Events", Relay_WhileInsideTrigger_11)) return; 
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "active_anim.uscript:3", local_3_System_StringArray);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b6b7a830-dec5-4d36-853d-3beb4b27b545", local_3_System_StringArray);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "active_anim.uscript:4", local_4_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "8d0d2617-7704-4fc3-9b4b-fe20ef1eebb1", local_4_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "active_anim.uscript:6", local_6_System_Object);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c7a55fed-886d-455a-83fc-b28ba26f076c", local_6_System_Object);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.LatestMasterComponent.HasBreakpoint(guid))
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
            m_ContinueExecution = new ContinueExecution(method);
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
