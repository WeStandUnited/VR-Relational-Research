using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class ColorChanger2 : MonoBehaviour
{
public static bool trigger;// trigger to let Activator.cs know that it can mave index++

public int value;
void Start(){
//  gameObject.GetComponent<Renderer>().material.color =Color.grey;

}//Start

void Update(){

if(gameObject.tag !="Done"){
if (value == RandomSelector.selectedNums[RandomSelector.selectedPointer]){

  Activate();
}
}

}//Update

public void Activate(){
//  gameObject.tag = "Activated";
    gameObject.GetComponent<Renderer>().material.color =Color.red;
    //trigger = true;
  }//Activate

  public void ChangeDone(){


    gameObject.GetComponent<Renderer>().material.color =Color.grey;
    ColorChanger2.trigger = true;
    gameObject.tag = "Done";
  }//ChangeDone


public void TriggerMe(){
  //UnityEngine.Debug.Log("Hit: "+value);
  if (value == RandomSelector.selectedNums[RandomSelector.selectedPointer]){
//UnityEngine.Debug.Log("Inside If");
    ChangeDone();
  }

}

}
