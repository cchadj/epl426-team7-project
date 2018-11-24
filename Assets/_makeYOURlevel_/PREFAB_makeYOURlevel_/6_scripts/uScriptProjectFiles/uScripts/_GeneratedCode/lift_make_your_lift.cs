//uScript Generated Code - Build 0.9.1910
//Generated with Debug Info
using UnityEngine;
using System.Collections;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class lift_make_your_lift : uScriptLogic
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
   UnityEngine.GameObject local_etage_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_etage_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_12_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_12_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_13_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_13_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_14_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_14_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject_previous = null;
   public UnityEngine.KeyCode BOTTOM = UnityEngine.KeyCode.None;
   public UnityEngine.KeyCode TOP = UnityEngine.KeyCode.None;
   UnityEngine.GameObject local_43_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_43_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_45_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_45_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_47_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_47_UnityEngine_GameObject_previous = null;
   
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
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_4 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_4 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_4;
   bool logic_uScriptAct_GetParent_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_Teleport logic_uScriptAct_Teleport_uScriptAct_Teleport_5 = new uScriptAct_Teleport( );
   UnityEngine.GameObject[] logic_uScriptAct_Teleport_Target_5 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_Teleport_Destination_5 = null;
   System.Boolean logic_uScriptAct_Teleport_UpdateRotation_5 = (bool) false;
   bool logic_uScriptAct_Teleport_Out_5 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_6 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_6 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_6 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_6 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_6 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_6 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_7 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_7 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_7 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_7 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_7 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_7 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_9 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_9 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_9;
   bool logic_uScriptAct_GetParent_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_10 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_10 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_10 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_10 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_10 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_10;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_10;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_10;
   bool logic_uScriptAct_GetChildrenByName_Out_10 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_10 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_10 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_16 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_16 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_16;
   bool logic_uScriptAct_GetParent_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_18 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_18 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_18 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_18 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_20 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_20 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_20 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_20 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_20 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_20;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_20;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_20;
   bool logic_uScriptAct_GetChildrenByName_Out_20 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_20 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_20 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_21 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_21 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_21 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_21 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_21 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_21 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_23 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_23 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_23 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_23 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_23 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_26 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_26 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_26 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_26 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_26 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_26;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_26;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_26;
   bool logic_uScriptAct_GetChildrenByName_Out_26 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_26 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_26 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_27 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_27 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_27;
   bool logic_uScriptAct_GetParent_Out_27 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_28 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_28 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_28 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_28 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_28 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_28 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_29 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_29 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_29 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_29 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_29 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_29 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_29 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_31 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_31 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_31 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_31 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_32 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_32 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_32 = null;
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_32 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_32 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_32 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_33 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_33 = null;
   System.String logic_uScriptAct_GetChildrenByName_Name_33 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_33 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_33 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_33;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_33;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_33;
   bool logic_uScriptAct_GetChildrenByName_Out_33 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_33 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_33 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_37 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_37 = null;
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_37 = null;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_37 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_37 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_37 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_37 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_38 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_38 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_38;
   bool logic_uScriptAct_GetParent_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_41 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_41 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_41 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_41 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_41 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_42 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_42 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_42;
   bool logic_uScriptAct_GetParent_Out_42 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_44 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_44 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_44;
   bool logic_uScriptAct_GetParent_Out_44 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_46 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_46 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_46;
   bool logic_uScriptAct_GetParent_Out_46 = true;
   
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
         logic_uScriptCon_CompareGameObjects_B_1 = GameObject.Find( "detect_floor" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_6 )
      {
         logic_uScriptCon_CompareGameObjects_B_6 = GameObject.Find( "detect_lift_middle" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_29 )
      {
         logic_uScriptCon_CompareGameObjects_B_29 = GameObject.Find( "detect_lift_1st" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptCon_CompareGameObjects_B_37 )
      {
         logic_uScriptCon_CompareGameObjects_B_37 = GameObject.Find( "detect_lift_last" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_13_UnityEngine_GameObject )
      {
         local_13_UnityEngine_GameObject = GameObject.Find( "First Person Controller" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject )
      {
         //tear down old listeners
         if ( null != local_13_UnityEngine_GameObject_previous )
         {
            {
               uScript_Triggers component = local_13_UnityEngine_GameObject_previous.GetComponent<uScript_Triggers>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_13_UnityEngine_GameObject )
         {
            {
               uScript_Triggers component = local_13_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = local_13_UnityEngine_GameObject.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_0;
               }
            }
            {
               uScript_Triggers component = local_13_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = local_13_UnityEngine_GameObject.AddComponent<uScript_Triggers>();
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
      //if our game object reference was changed then we need to reset event listeners
      if ( local_14_UnityEngine_GameObject_previous != local_14_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_14_UnityEngine_GameObject_previous = local_14_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_45_UnityEngine_GameObject_previous != local_45_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_45_UnityEngine_GameObject_previous = local_45_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_13_UnityEngine_GameObject )
      {
         {
            uScript_Triggers component = local_13_UnityEngine_GameObject.GetComponent<uScript_Triggers>();
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_4.SetParent(g);
      logic_uScriptAct_Teleport_uScriptAct_Teleport_5.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_9.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_10.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_16.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_20.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_23.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_26.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_27.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_29.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_33.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_37.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_38.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_41.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_42.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_44.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_46.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.Finished += uScriptAct_MoveToLocationRelative_Finished_7;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.Finished += uScriptAct_MoveToLocationRelative_Finished_21;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Finished += uScriptAct_MoveToLocationRelative_Finished_28;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.Finished += uScriptAct_MoveToLocationRelative_Finished_32;
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
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.Update( );
   }
   
   public void OnDestroy()
   {
      UnregisterEventListeners( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.Finished -= uScriptAct_MoveToLocationRelative_Finished_7;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.Finished -= uScriptAct_MoveToLocationRelative_Finished_21;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Finished -= uScriptAct_MoveToLocationRelative_Finished_28;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.Finished -= uScriptAct_MoveToLocationRelative_Finished_32;
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
   
   void uScriptAct_MoveToLocationRelative_Finished_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_7( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_21(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_21( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_28(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_28( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_32(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_32( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_OnEnterTrigger_0)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_1();
   }
   
   void Relay_OnExitTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_OnExitTrigger_0)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      if (true == CheckDebugBreak("8ee2df63-551d-4a9e-8edf-09cfa12ff6a8", "Trigger Events", Relay_WhileInsideTrigger_0)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_6();
      Relay_In_29();
      Relay_In_37();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ca69d325-6eef-4701-9f7b-117b292604ad", "Compare GameObjects", Relay_In_1)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_1 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.In(logic_uScriptCon_CompareGameObjects_A_1, logic_uScriptCon_CompareGameObjects_B_1, logic_uScriptCon_CompareGameObjects_CompareByTag_1, logic_uScriptCon_CompareGameObjects_CompareByName_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_1.Same;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2cb50571-1072-4a3c-9e23-e16f61318ef4", "Get Children By Name", Relay_In_3)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_3 = local_lift_make_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.In(logic_uScriptAct_GetChildrenByName_Target_3, logic_uScriptAct_GetChildrenByName_Name_3, logic_uScriptAct_GetChildrenByName_SearchMethod_3, logic_uScriptAct_GetChildrenByName_recursive_3, out logic_uScriptAct_GetChildrenByName_FirstChild_3, out logic_uScriptAct_GetChildrenByName_Children_3, out logic_uScriptAct_GetChildrenByName_ChildrenCount_3);
         local_14_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_3;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_14_UnityEngine_GameObject_previous != local_14_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_14_UnityEngine_GameObject_previous = local_14_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_3.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0df03390-95eb-4b60-893b-60ce88ca11fd", "Get Parent", Relay_In_4)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_4 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_4.In(logic_uScriptAct_GetParent_Target_4, out logic_uScriptAct_GetParent_Parent_4);
         local_etage_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_4;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_16();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9d17dd69-8681-4c93-b7af-56bd784a5e60", "Teleport", Relay_In_5)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_14_UnityEngine_GameObject_previous != local_14_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_14_UnityEngine_GameObject_previous = local_14_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Teleport_Target_5.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Teleport_Target_5, index + 1);
            }
            logic_uScriptAct_Teleport_Target_5[ index++ ] = local_14_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_Teleport_Destination_5 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_Teleport_uScriptAct_Teleport_5.In(logic_uScriptAct_Teleport_Target_5, logic_uScriptAct_Teleport_Destination_5, logic_uScriptAct_Teleport_UpdateRotation_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Teleport.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6309f7bb-d587-4df6-8942-a710e664501e", "Compare GameObjects", Relay_In_6)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_6 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.In(logic_uScriptCon_CompareGameObjects_A_6, logic_uScriptCon_CompareGameObjects_B_6, logic_uScriptCon_CompareGameObjects_CompareByTag_6, logic_uScriptCon_CompareGameObjects_CompareByName_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_6.Same;
         
         if ( test_0 == true )
         {
            Relay_In_42();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_Finished_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_In_7)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_7, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_7[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_7 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.In(logic_uScriptAct_MoveToLocationRelative_targetArray_7, logic_uScriptAct_MoveToLocationRelative_location_7, logic_uScriptAct_MoveToLocationRelative_source_7, logic_uScriptAct_MoveToLocationRelative_totalTime_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a3643de2-b282-404d-88b0-97ec04f028d1", "Move To Location Relative", Relay_Cancel_7)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_7, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_7[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_7 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_7.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_7, logic_uScriptAct_MoveToLocationRelative_location_7, logic_uScriptAct_MoveToLocationRelative_source_7, logic_uScriptAct_MoveToLocationRelative_totalTime_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("de030022-124d-4d65-a15d-90017b9a6a98", "Get Parent", Relay_In_9)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_9 = local_43_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_9.In(logic_uScriptAct_GetParent_Target_9, out logic_uScriptAct_GetParent_Parent_9);
         local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_9;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_18();
            Relay_In_41();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("17552b6c-c59a-4db1-aa82-bb6c6a3de43d", "Get Children By Name", Relay_In_10)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_10 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_10.In(logic_uScriptAct_GetChildrenByName_Target_10, logic_uScriptAct_GetChildrenByName_Name_10, logic_uScriptAct_GetChildrenByName_SearchMethod_10, logic_uScriptAct_GetChildrenByName_recursive_10, out logic_uScriptAct_GetChildrenByName_FirstChild_10, out logic_uScriptAct_GetChildrenByName_Children_10, out logic_uScriptAct_GetChildrenByName_ChildrenCount_10);
         local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_10;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_10.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_16()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4b0915e5-3c99-45c4-9286-f4b70e6a7fea", "Get Parent", Relay_In_16)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_16 = local_etage_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_16.In(logic_uScriptAct_GetParent_Target_16, out logic_uScriptAct_GetParent_Parent_16);
         local_lift_make_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_16;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_16.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a96feed3-8268-4703-b42e-b767f84e5d93", "Input Events Filter", Relay_In_18)) return; 
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_18 = BOTTOM;
            
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.In(logic_uScriptAct_OnInputEventFilter_KeyCode_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("38dcce60-190d-4ff6-97e2-7d91591d688b", "Get Children By Name", Relay_In_20)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_20 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_20.In(logic_uScriptAct_GetChildrenByName_Target_20, logic_uScriptAct_GetChildrenByName_Name_20, logic_uScriptAct_GetChildrenByName_SearchMethod_20, logic_uScriptAct_GetChildrenByName_recursive_20, out logic_uScriptAct_GetChildrenByName_FirstChild_20, out logic_uScriptAct_GetChildrenByName_Children_20, out logic_uScriptAct_GetChildrenByName_ChildrenCount_20);
         local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_20;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_20.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b8df41e7-1625-445e-9873-51d9c7ebc210", "Move To Location Relative", Relay_Finished_21)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b8df41e7-1625-445e-9873-51d9c7ebc210", "Move To Location Relative", Relay_In_21)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_21.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_21, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_21[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_21 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.In(logic_uScriptAct_MoveToLocationRelative_targetArray_21, logic_uScriptAct_MoveToLocationRelative_location_21, logic_uScriptAct_MoveToLocationRelative_source_21, logic_uScriptAct_MoveToLocationRelative_totalTime_21);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b8df41e7-1625-445e-9873-51d9c7ebc210", "Move To Location Relative", Relay_Cancel_21)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_21.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_21, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_21[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_21 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_21.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_21, logic_uScriptAct_MoveToLocationRelative_location_21, logic_uScriptAct_MoveToLocationRelative_source_21, logic_uScriptAct_MoveToLocationRelative_totalTime_21);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_23()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b76eb2ba-b75a-423a-8c4c-1433f15d07c4", "Input Events Filter", Relay_In_23)) return; 
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_23 = TOP;
            
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_23.In(logic_uScriptAct_OnInputEventFilter_KeyCode_23);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_23.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("20a322d6-6b73-4b24-8601-259043fa36ca", "Get Children By Name", Relay_In_26)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_26 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_26.In(logic_uScriptAct_GetChildrenByName_Target_26, logic_uScriptAct_GetChildrenByName_Name_26, logic_uScriptAct_GetChildrenByName_SearchMethod_26, logic_uScriptAct_GetChildrenByName_recursive_26, out logic_uScriptAct_GetChildrenByName_FirstChild_26, out logic_uScriptAct_GetChildrenByName_Children_26, out logic_uScriptAct_GetChildrenByName_ChildrenCount_26);
         local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_26;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_26.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_28();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_27()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("37bbdfd8-a8ef-46a6-a229-3828db2549b1", "Get Parent", Relay_In_27)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_45_UnityEngine_GameObject_previous != local_45_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_45_UnityEngine_GameObject_previous = local_45_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_27 = local_45_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_27.In(logic_uScriptAct_GetParent_Target_27, out logic_uScriptAct_GetParent_Parent_27);
         local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_27;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_27.Out;
         
         if ( test_0 == true )
         {
            Relay_In_23();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c4af9b20-5e7b-42dc-a745-fff2b51e8994", "Move To Location Relative", Relay_Finished_28)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c4af9b20-5e7b-42dc-a745-fff2b51e8994", "Move To Location Relative", Relay_In_28)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_28.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_28, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_28[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_28 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.In(logic_uScriptAct_MoveToLocationRelative_targetArray_28, logic_uScriptAct_MoveToLocationRelative_location_28, logic_uScriptAct_MoveToLocationRelative_source_28, logic_uScriptAct_MoveToLocationRelative_totalTime_28);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c4af9b20-5e7b-42dc-a745-fff2b51e8994", "Move To Location Relative", Relay_Cancel_28)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_28.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_28, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_28[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_28 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_28, logic_uScriptAct_MoveToLocationRelative_location_28, logic_uScriptAct_MoveToLocationRelative_source_28, logic_uScriptAct_MoveToLocationRelative_totalTime_28);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ab6e6b20-5a5f-4784-9c09-29c3a4e128ee", "Compare GameObjects", Relay_In_29)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_29 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_29.In(logic_uScriptCon_CompareGameObjects_A_29, logic_uScriptCon_CompareGameObjects_B_29, logic_uScriptCon_CompareGameObjects_CompareByTag_29, logic_uScriptCon_CompareGameObjects_CompareByName_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_29.Same;
         
         if ( test_0 == true )
         {
            Relay_In_44();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("73fcc802-3dc5-4ec4-bab1-c36007d8b1ab", "Input Events Filter", Relay_In_31)) return; 
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_31 = BOTTOM;
            
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.In(logic_uScriptAct_OnInputEventFilter_KeyCode_31);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_33();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_32()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4c66ab0a-3a27-4808-9184-8cdb0dc613ae", "Move To Location Relative", Relay_Finished_32)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_32()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4c66ab0a-3a27-4808-9184-8cdb0dc613ae", "Move To Location Relative", Relay_In_32)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_32.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_32, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_32[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_32 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.In(logic_uScriptAct_MoveToLocationRelative_targetArray_32, logic_uScriptAct_MoveToLocationRelative_location_32, logic_uScriptAct_MoveToLocationRelative_source_32, logic_uScriptAct_MoveToLocationRelative_totalTime_32);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_32()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4c66ab0a-3a27-4808-9184-8cdb0dc613ae", "Move To Location Relative", Relay_Cancel_32)) return; 
         {
            int index;
            index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_32.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_32, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_32[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_32 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_32.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_32, logic_uScriptAct_MoveToLocationRelative_location_32, logic_uScriptAct_MoveToLocationRelative_source_32, logic_uScriptAct_MoveToLocationRelative_totalTime_32);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Move To Location Relative.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_33()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("68de71ef-62d8-492a-8154-96a0ef445ab3", "Get Children By Name", Relay_In_33)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_33 = local_lift_make_your_lift_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_33.In(logic_uScriptAct_GetChildrenByName_Target_33, logic_uScriptAct_GetChildrenByName_Name_33, logic_uScriptAct_GetChildrenByName_SearchMethod_33, logic_uScriptAct_GetChildrenByName_recursive_33, out logic_uScriptAct_GetChildrenByName_FirstChild_33, out logic_uScriptAct_GetChildrenByName_Children_33, out logic_uScriptAct_GetChildrenByName_ChildrenCount_33);
         local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_33;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_33.ChildrenFound;
         
         if ( test_0 == true )
         {
            Relay_In_32();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_37()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c43008c0-9576-424d-ac8a-2de38922b136", "Compare GameObjects", Relay_In_37)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_37 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_37.In(logic_uScriptCon_CompareGameObjects_A_37, logic_uScriptCon_CompareGameObjects_B_37, logic_uScriptCon_CompareGameObjects_CompareByTag_37, logic_uScriptCon_CompareGameObjects_CompareByName_37);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_37.Same;
         
         if ( test_0 == true )
         {
            Relay_In_46();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_38()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ea21426a-8391-4691-a28a-9185070bdf07", "Get Parent", Relay_In_38)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_38 = local_47_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_38.In(logic_uScriptAct_GetParent_Target_38, out logic_uScriptAct_GetParent_Parent_38);
         local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_38;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_38.Out;
         
         if ( test_0 == true )
         {
            Relay_In_31();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_41()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9d53b0cb-274a-4f01-9e88-833fc7695171", "Input Events Filter", Relay_In_41)) return; 
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_41 = TOP;
            
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_41.In(logic_uScriptAct_OnInputEventFilter_KeyCode_41);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_41.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_42()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9a902131-41cf-4701-b0eb-cc051eb365d8", "Get Parent", Relay_In_42)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_42 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_42.In(logic_uScriptAct_GetParent_Target_42, out logic_uScriptAct_GetParent_Parent_42);
         local_43_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_42;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_42.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_44()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("53fce264-1704-49c0-9bc4-8c1b573e42c3", "Get Parent", Relay_In_44)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_44 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_44.In(logic_uScriptAct_GetParent_Target_44, out logic_uScriptAct_GetParent_Parent_44);
         local_45_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_44;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_45_UnityEngine_GameObject_previous != local_45_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_45_UnityEngine_GameObject_previous = local_45_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_44.Out;
         
         if ( test_0 == true )
         {
            Relay_In_27();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_46()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5cd17dff-62a2-457e-853c-1cfe76c09a6e", "Get Parent", Relay_In_46)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_46 = local_12_UnityEngine_GameObject;
            
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_46.In(logic_uScriptAct_GetParent_Target_46, out logic_uScriptAct_GetParent_Parent_46);
         local_47_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_46;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject )
            {
               //tear down old listeners
               
               local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_46.Out;
         
         if ( test_0 == true )
         {
            Relay_In_38();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lift_make_your_lift.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:etage", local_etage_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3d764c5d-d10d-489a-aeb1-c733a622146c", local_etage_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:12", local_12_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5bbf7f6d-dfe0-48de-a429-5574f14b4b4c", local_12_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:13", local_13_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7df04ec4-a081-4a58-9bcc-5eb0615894e4", local_13_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:14", local_14_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "d2d95bcd-f2d1-4d77-9276-535ca8ead528", local_14_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:lift_make", local_lift_make_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "304178db-ed3a-47d3-b2e5-77fe40363be0", local_lift_make_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:lift_active", local_lift_active_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3a74dabc-c45b-4556-a6bb-638f1ca3db1b", local_lift_active_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:lift_make_your_lift", local_lift_make_your_lift_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3613e438-cb0d-42fc-8499-68edfedcb560", local_lift_make_your_lift_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:BOTTOM", BOTTOM);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "10be814b-383a-4919-b455-fbdd2ba70488", BOTTOM);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:TOP", TOP);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "548b6e61-7b91-454d-995c-6daddba755b7", TOP);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:43", local_43_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b52cbf7d-a0fb-4d61-9220-94e16ab8c0cc", local_43_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:45", local_45_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7415d94e-44b0-47f9-a393-eeb328827ce5", local_45_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lift_make_your_lift.uscript:47", local_47_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "dbd8c7d6-f977-424c-aca9-38b3ff308fb2", local_47_UnityEngine_GameObject);
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
