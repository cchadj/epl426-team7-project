//uScript Generated Code - Build 0.9.1910
//Generated with Debug Info
using UnityEngine;
using System.Collections;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class lift_module : uScriptLogic
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
   UnityEngine.GameObject local_4_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_5_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_5_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_7_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_7_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_8_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_8_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_16_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_16_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_22_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_22_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_module_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_module_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_27_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_27_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_29_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_29_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_1 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_1 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_1 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_1 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_1 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_2 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_2 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_2;
   bool logic_uScriptAct_GetParent_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_3 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_3 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_3 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_3 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_3;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_3;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_3;
   bool logic_uScriptAct_GetChildrenByName_Out_3 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_3 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_3 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_6 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_6 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_6 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_6 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_6 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_6 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_9 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_9 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_9 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_9 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_9;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_9;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_9;
   bool logic_uScriptAct_GetChildrenByName_Out_9 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_9 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_9 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_10 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_10 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_10;
   bool logic_uScriptAct_GetParent_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_Teleport logic_uScriptAct_Teleport_uScriptAct_Teleport_11 = new uScriptAct_Teleport( );
   UnityEngine.GameObject[] logic_uScriptAct_Teleport_Target_11 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_Teleport_Destination_11 = null;
   System.Boolean logic_uScriptAct_Teleport_UpdateRotation_11 = (bool) false;
   bool logic_uScriptAct_Teleport_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_Teleport logic_uScriptAct_Teleport_uScriptAct_Teleport_12 = new uScriptAct_Teleport( );
   UnityEngine.GameObject[] logic_uScriptAct_Teleport_Target_12 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_Teleport_Destination_12 = null;
   System.Boolean logic_uScriptAct_Teleport_UpdateRotation_12 = (bool) false;
   bool logic_uScriptAct_Teleport_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_13 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_13 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_13 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_13 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_13 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_13 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_14 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_14 = UnityEngine.KeyCode.Mouse0;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_14 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_14 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_14 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_15 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_15 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_15 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_15 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_15 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_15 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_17 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_17 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_17;
   bool logic_uScriptAct_GetParent_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_18 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_18 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_18 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_18 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_18;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_18;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_18;
   bool logic_uScriptAct_GetChildrenByName_Out_18 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_18 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_18 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_20 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_20 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_20 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_20 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_20 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_20 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_21 = UnityEngine.KeyCode.Mouse0;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_21 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_21 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_21 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_23 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_23 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_23 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_23 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_23 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_23;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_23;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_23;
   bool logic_uScriptAct_GetChildrenByName_Out_23 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_23 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_23 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_25 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_25 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_25;
   bool logic_uScriptAct_GetParent_Out_25 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_26 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_26 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_26 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_26 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_26 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_26 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_26 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_28 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_28 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_28 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_28 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_0 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = null;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptCon_CompareGameObjects_B_1 )
      {
         logic_uScriptCon_CompareGameObjects_B_1 = GameObject.Find( "detect_01" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_6 )
      {
         logic_uScriptCon_CompareGameObjects_B_6 = GameObject.Find( "detect_02" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_13 )
      {
         logic_uScriptCon_CompareGameObjects_B_13 = GameObject.Find( "detect_lift_01" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_26 )
      {
         logic_uScriptCon_CompareGameObjects_B_26 = GameObject.Find( "detect_lift_02" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_7_UnityEngine_GameObject_previous != local_7_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_7_UnityEngine_GameObject_previous = local_7_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_22_UnityEngine_GameObject_previous != local_22_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_22_UnityEngine_GameObject_previous = local_22_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_29_UnityEngine_GameObject )
      {
         local_29_UnityEngine_GameObject = GameObject.Find( "First Person Controller" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_29_UnityEngine_GameObject_previous != local_29_UnityEngine_GameObject )
      {
         //tear down old listeners
         if ( null != local_29_UnityEngine_GameObject_previous )
         {
            {
               uScript_Triggers component = local_29_UnityEngine_GameObject_previous.GetComponent<uScript_Triggers>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         local_29_UnityEngine_GameObject_previous = local_29_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_29_UnityEngine_GameObject )
         {
            {
               uScript_Triggers component = local_29_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = local_29_UnityEngine_GameObject.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_0;
               }
            }
            {
               uScript_Triggers component = local_29_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = local_29_UnityEngine_GameObject.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
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
      if ( null != local_29_UnityEngine_GameObject )
      {
         {
            uScript_Triggers component = local_29_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_2.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_10.SetParent(g);
      logic_uScriptAct_Teleport_uScriptAct_Teleport_11.SetParent(g);
      logic_uScriptAct_Teleport_uScriptAct_Teleport_12.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_14.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_17.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_23.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_25.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_26.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_28.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.Finished += uScriptAct_MoveToLocationRelative_Finished_15;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Finished += uScriptAct_MoveToLocationRelative_Finished_20;
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
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Update( );
   }
   
   public void OnDestroy()
   {
      UnregisterEventListeners( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.Finished -= uScriptAct_MoveToLocationRelative_Finished_15;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Finished -= uScriptAct_MoveToLocationRelative_Finished_20;
   }
   
   void Instance_OnEnterTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Instance_WhileInsideTrigger_0(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_0( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_15( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_20( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_OnEnterTrigger_0)) return; 
      local_27_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_1();
      Relay_In_6();
      Relay_In_28();
   }
   
   void Relay_OnExitTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_OnExitTrigger_0)) return; 
      local_27_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_WhileInsideTrigger_0)) return; 
      local_27_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_13();
      Relay_In_26();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f9bcc836-b71e-4805-9aa2-c26779ee857f", "Compare GameObjects", Relay_In_1)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_1 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.In(logic_uScriptCon_CompareGameObjects_A_1, logic_uScriptCon_CompareGameObjects_B_1, logic_uScriptCon_CompareGameObjects_CompareByTag_1, logic_uScriptCon_CompareGameObjects_CompareByName_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.Same;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4d4d854a-cc26-4a1b-a013-ee67dfee39d0", "Get Parent", Relay_In_2)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_2 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_2.In(logic_uScriptAct_GetParent_Target_2, out logic_uScriptAct_GetParent_Parent_2);
         local_4_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_2;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3b77fbbc-835c-4b66-bb75-26578777f43f", "Get Children By Name", Relay_In_3)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_3 = local_4_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.In(logic_uScriptAct_GetChildrenByName_Target_3, logic_uScriptAct_GetChildrenByName_Name_3, logic_uScriptAct_GetChildrenByName_SearchMethod_3, logic_uScriptAct_GetChildrenByName_recursive_3, out logic_uScriptAct_GetChildrenByName_FirstChild_3, out logic_uScriptAct_GetChildrenByName_Children_3, out logic_uScriptAct_GetChildrenByName_ChildrenCount_3);
         local_5_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_3;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ca69d325-6eef-4701-9f7b-117b292604ad", "Compare GameObjects", Relay_In_6)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_6 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.In(logic_uScriptCon_CompareGameObjects_A_6, logic_uScriptCon_CompareGameObjects_B_6, logic_uScriptCon_CompareGameObjects_CompareByTag_6, logic_uScriptCon_CompareGameObjects_CompareByName_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.Same;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2cb50571-1072-4a3c-9e23-e16f61318ef4", "Get Children By Name", Relay_In_9)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_7_UnityEngine_GameObject_previous != local_7_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_7_UnityEngine_GameObject_previous = local_7_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_9 = local_7_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.In(logic_uScriptAct_GetChildrenByName_Target_9, logic_uScriptAct_GetChildrenByName_Name_9, logic_uScriptAct_GetChildrenByName_SearchMethod_9, logic_uScriptAct_GetChildrenByName_recursive_9, out logic_uScriptAct_GetChildrenByName_FirstChild_9, out logic_uScriptAct_GetChildrenByName_Children_9, out logic_uScriptAct_GetChildrenByName_ChildrenCount_9);
         local_8_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_9;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_9.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_11();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0df03390-95eb-4b60-893b-60ce88ca11fd", "Get Parent", Relay_In_10)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_10 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_10.In(logic_uScriptAct_GetParent_Target_10, out logic_uScriptAct_GetParent_Parent_10);
         local_7_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_10;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_7_UnityEngine_GameObject_previous != local_7_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_7_UnityEngine_GameObject_previous = local_7_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_10.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9d17dd69-8681-4c93-b7af-56bd784a5e60", "Teleport", Relay_In_11)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Teleport_Target_11.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Teleport_Target_11, index + 1);
            }
            logic_uScriptAct_Teleport_Target_11[ index++ ] = local_8_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_Teleport_Destination_11 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_Teleport_uScriptAct_Teleport_11.In(logic_uScriptAct_Teleport_Target_11, logic_uScriptAct_Teleport_Destination_11, logic_uScriptAct_Teleport_UpdateRotation_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Teleport.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("80cafc97-c17e-48b4-8177-5dfd56913e76", "Teleport", Relay_In_12)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Teleport_Target_12.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Teleport_Target_12, index + 1);
            }
            logic_uScriptAct_Teleport_Target_12[ index++ ] = local_5_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_Teleport_Destination_12 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_Teleport_uScriptAct_Teleport_12.In(logic_uScriptAct_Teleport_Target_12, logic_uScriptAct_Teleport_Destination_12, logic_uScriptAct_Teleport_UpdateRotation_12);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Teleport.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6309f7bb-d587-4df6-8942-a710e664501e", "Compare GameObjects", Relay_In_13)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_13 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.In(logic_uScriptCon_CompareGameObjects_A_13, logic_uScriptCon_CompareGameObjects_B_13, logic_uScriptCon_CompareGameObjects_CompareByTag_13, logic_uScriptCon_CompareGameObjects_CompareByName_13);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.Same;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9d53b0cb-274a-4f01-9e88-833fc7695171", "Input Events Filter", Relay_In_14)) return; 
         {
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_14.In(logic_uScriptAct_OnInputEventFilter_KeyCode_14);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_14.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_Finished_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_In_15)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_15.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_15, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_15[ index++ ] = local_16_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_15 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.In(logic_uScriptAct_MoveToLocationRelative_targetArray_15, logic_uScriptAct_MoveToLocationRelative_location_15, logic_uScriptAct_MoveToLocationRelative_source_15, logic_uScriptAct_MoveToLocationRelative_totalTime_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_Cancel_15)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_15.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_15, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_15[ index++ ] = local_16_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_15 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_15.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_15, logic_uScriptAct_MoveToLocationRelative_location_15, logic_uScriptAct_MoveToLocationRelative_source_15, logic_uScriptAct_MoveToLocationRelative_totalTime_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("de030022-124d-4d65-a15d-90017b9a6a98", "Get Parent", Relay_In_17)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_17 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_17.In(logic_uScriptAct_GetParent_Target_17, out logic_uScriptAct_GetParent_Parent_17);
         local_lift_module_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_17;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_17.Out;
         
         if ( test_0 == true )
         {
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("17552b6c-c59a-4db1-aa82-bb6c6a3de43d", "Get Children By Name", Relay_In_18)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_18 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.In(logic_uScriptAct_GetChildrenByName_Target_18, logic_uScriptAct_GetChildrenByName_Name_18, logic_uScriptAct_GetChildrenByName_SearchMethod_18, logic_uScriptAct_GetChildrenByName_recursive_18, out logic_uScriptAct_GetChildrenByName_FirstChild_18, out logic_uScriptAct_GetChildrenByName_Children_18, out logic_uScriptAct_GetChildrenByName_ChildrenCount_18);
         local_16_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_18;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fd4b771e-d8f2-42d0-a97f-4305c83efc1c", "Move To Location Relative", Relay_Finished_20)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fd4b771e-d8f2-42d0-a97f-4305c83efc1c", "Move To Location Relative", Relay_In_20)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_22_UnityEngine_GameObject_previous != local_22_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_22_UnityEngine_GameObject_previous = local_22_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_20.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_20, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_20[ index++ ] = local_22_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_20 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.In(logic_uScriptAct_MoveToLocationRelative_targetArray_20, logic_uScriptAct_MoveToLocationRelative_location_20, logic_uScriptAct_MoveToLocationRelative_source_20, logic_uScriptAct_MoveToLocationRelative_totalTime_20);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fd4b771e-d8f2-42d0-a97f-4305c83efc1c", "Move To Location Relative", Relay_Cancel_20)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_22_UnityEngine_GameObject_previous != local_22_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_22_UnityEngine_GameObject_previous = local_22_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_20.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_20, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_20[ index++ ] = local_22_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_20 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_20.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_20, logic_uScriptAct_MoveToLocationRelative_location_20, logic_uScriptAct_MoveToLocationRelative_source_20, logic_uScriptAct_MoveToLocationRelative_totalTime_20);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4abbceb2-bfbd-4078-a68f-f62c799d1d92", "Input Events Filter", Relay_In_21)) return; 
         {
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.In(logic_uScriptAct_OnInputEventFilter_KeyCode_21);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_23();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_23()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2d8b7506-0142-45c7-9ae2-841e0d254a7d", "Get Children By Name", Relay_In_23)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_23 = local_lift_module_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_23.In(logic_uScriptAct_GetChildrenByName_Target_23, logic_uScriptAct_GetChildrenByName_Name_23, logic_uScriptAct_GetChildrenByName_SearchMethod_23, logic_uScriptAct_GetChildrenByName_recursive_23, out logic_uScriptAct_GetChildrenByName_FirstChild_23, out logic_uScriptAct_GetChildrenByName_Children_23, out logic_uScriptAct_GetChildrenByName_ChildrenCount_23);
         local_22_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_23;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_22_UnityEngine_GameObject_previous != local_22_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_22_UnityEngine_GameObject_previous = local_22_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_23.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bb41c067-14da-457a-8674-cb2aefb48177", "Get Parent", Relay_In_25)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_25 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_25.In(logic_uScriptAct_GetParent_Target_25, out logic_uScriptAct_GetParent_Parent_25);
         local_lift_module_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_25;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_module_UnityEngine_GameObject_previous != local_lift_module_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_module_UnityEngine_GameObject_previous = local_lift_module_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_25.Out;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("05600ee2-1ea3-46cf-99df-9db28c6d1cc3", "Compare GameObjects", Relay_In_26)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_27_UnityEngine_GameObject_previous != local_27_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_27_UnityEngine_GameObject_previous = local_27_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_26 = local_27_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_26.In(logic_uScriptCon_CompareGameObjects_A_26, logic_uScriptCon_CompareGameObjects_B_26, logic_uScriptCon_CompareGameObjects_CompareByTag_26, logic_uScriptCon_CompareGameObjects_CompareByName_26);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_26.Same;
         
         if ( test_0 == true )
         {
            Relay_In_25();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bc2a8c19-66cc-44c9-ac3e-1b8c497b7bd8", "Destroy", Relay_In_28)) return; 
         {
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_28.In(logic_uScriptAct_Destroy_Target_28, logic_uScriptAct_Destroy_DelayTime_28);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_module.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:4", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c942031a-9dce-423c-9d19-3586be665ac0", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:5", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "8f71f447-7794-40ef-b47e-649989a30fb9", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:7", local_7_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3d764c5d-d10d-489a-aeb1-c733a622146c", local_7_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:8", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "d2d95bcd-f2d1-4d77-9276-535ca8ead528", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:16", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ef936d3f-1097-4469-a3af-ed810c2e1d78", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:22", local_22_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "1695acc3-9c1a-48fc-849a-d0f9743da76f", local_22_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:lift module", local_lift_module_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7663f660-e9cb-4319-b4a1-94d1f92a3b1b", local_lift_module_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:27", local_27_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5bbf7f6d-dfe0-48de-a429-5574f14b4b4c", local_27_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_module.uscript:29", local_29_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7df04ec4-a081-4a58-9bcc-5eb0615894e4", local_29_UnityEngine_GameObject);
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
