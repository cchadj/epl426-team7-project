//uScript Generated Code - Build 0.9.1910
//Generated with Debug Info
using UnityEngine;
using System.Collections;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class push : uScriptLogic
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
   UnityEngine.Vector3 local_2_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_5_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_5_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_6 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_1 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_1 = null;
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_1 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_1 = (float) 10;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_1 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_1 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_1 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_3 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_3 = null;
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_3 = new System.String[] {"push"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_3 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_3 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_3 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = null;
   UnityEngine.CharacterController event_UnityEngine_GameObject_Controller_0 = null;
   UnityEngine.Collider event_UnityEngine_GameObject_Collider_0 = null;
   UnityEngine.Rigidbody event_UnityEngine_GameObject_RigidBody_0 = null;
   UnityEngine.Transform event_UnityEngine_GameObject_Transform_0 = null;
   UnityEngine.Vector3 event_UnityEngine_GameObject_Point_0 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 event_UnityEngine_GameObject_Normal_0 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 event_UnityEngine_GameObject_MoveDirection_0 = new Vector3( );
   System.Single event_UnityEngine_GameObject_MoveLength_0 = (float) 0;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_6 )
      {
         owner_Connection_6 = parentGameObject;
         if ( null != owner_Connection_6 )
         {
            {
               uScript_ProxyController component = owner_Connection_6.GetComponent<uScript_ProxyController>();
               if ( null == component )
               {
                  component = owner_Connection_6.AddComponent<uScript_ProxyController>();
               }
               if ( null != component )
               {
                  component.OnHit += Instance_OnHit_0;
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
      if ( null != owner_Connection_6 )
      {
         {
            uScript_ProxyController component = owner_Connection_6.GetComponent<uScript_ProxyController>();
            if ( null != component )
            {
               component.OnHit -= Instance_OnHit_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AddForce_uScriptAct_AddForce_1.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_3.SetParent(g);
   }
   public void Awake()
   {
      
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
      
   }
   
   public void OnDestroy()
   {
      UnregisterEventListeners( );
   }
   
   void Instance_OnHit_0(object o, uScript_ProxyController.ProxyControllerCollisionEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      event_UnityEngine_GameObject_Controller_0 = e.Controller;
      event_UnityEngine_GameObject_Collider_0 = e.Collider;
      event_UnityEngine_GameObject_RigidBody_0 = e.RigidBody;
      event_UnityEngine_GameObject_Transform_0 = e.Transform;
      event_UnityEngine_GameObject_Point_0 = e.Point;
      event_UnityEngine_GameObject_Normal_0 = e.Normal;
      event_UnityEngine_GameObject_MoveDirection_0 = e.MoveDirection;
      event_UnityEngine_GameObject_MoveLength_0 = e.MoveLength;
      //relay event to nodes
      Relay_OnHit_0( );
   }
   
   void Relay_OnHit_0()
   {
      if (true == CheckDebugBreak("427af407-3512-4bbb-bc42-451645e46d4a", "Controller Collision", Relay_OnHit_0)) return; 
      local_5_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
         {
            //tear down old listeners
            
            local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      local_2_UnityEngine_Vector3 = event_UnityEngine_GameObject_MoveDirection_0;
      Relay_In_3();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("deb67f9a-cf50-47bf-aa11-bbe05128d5e4", "Add Force", Relay_In_1)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_AddForce_Target_1 = local_5_UnityEngine_GameObject;
            
            logic_uScriptAct_AddForce_Force_1 = local_2_UnityEngine_Vector3;
            
         }
         logic_uScriptAct_AddForce_uScriptAct_AddForce_1.In(logic_uScriptAct_AddForce_Target_1, logic_uScriptAct_AddForce_Force_1, logic_uScriptAct_AddForce_Scale_1, logic_uScriptAct_AddForce_UseForceMode_1, logic_uScriptAct_AddForce_ForceModeType_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript push.uscript at Add Force.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("73819075-fa3e-468d-b07b-aeb2662e700c", "GameObject Has Tag", Relay_In_3)) return; 
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject )
               {
                  //tear down old listeners
                  
                  local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_GameObjectHasTag_GameObject_3 = local_5_UnityEngine_GameObject;
            
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_3.In(logic_uScriptCon_GameObjectHasTag_GameObject_3, logic_uScriptCon_GameObjectHasTag_Tag_3);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_3.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript push.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "push.uscript:2", local_2_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f72569a1-17dc-403e-949b-7db4e5e4b37e", local_2_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "push.uscript:5", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f26ad684-b179-4a55-9134-44d9ae518967", local_5_UnityEngine_GameObject);
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
