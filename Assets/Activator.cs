using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Activator : MonoBehaviour
{
public static GameObject [] spheres = new GameObject[13];// Array of Spheres we act upon
public GameObject [] balls = new GameObject[13];//non static array we can

public string fileLocation = @"C:\Users\Cj\Desktop\RandomNumberFiles\File";

// Array of Spheres we act upon0-12
List<int> selected = new List<int>(12);//Contains all gameobjects index that have been activated
public static int INDEX;// Displays index of sphere array that needs to activate

public System.Diagnostics.Stopwatch stopWatch = new Stopwatch();//stopwatch to track user time

long ellapsedTime;



void Start(){
  UnityEngine.Debug.Log("INDEX picked:"+INDEX);

  for (int i = 0;i==12;i++){
    UnityEngine.Debug.Log("Slot"+"["+i+"]"+":"+selected[i]);

  }

  loadArray();//
  swapArrays();//swaps data from inspector array (balls) to are static array spheres
  foreach (int i in selected)
{
  UnityEngine.Debug.Log("Contents or Array"+i);
}
  stopWatch.Start();//start timer

}//Start

void Update(){

if (ColorChanger2.trigger == true){//ColorChanger2 trigger  true ? if so index++;
UnityEngine.Debug.Log("Trigger True");

  INDEX++;//move index forward to say we are done with this random number because its already been selected
UnityEngine.Debug.Log("INDEX:"+INDEX);
  ColorChanger2.trigger = false;
  UnityEngine.Debug.Log("TRIGGER:"+ColorChanger2.trigger);

}


}//Update



public int RandomIndex(){
// Need System Random
System.Random rand = new System.Random();

int index = rand.Next(0,11);

UnityEngine.Debug.Log("Index picked:"+index);
return index; //selects random number fomr 0-11
}


public void loadArray(){
bool containsIndex;
int index;
for (int i=0;i<=11;i++){
  containsIndex = true;
  index = RandomIndex();// selects random number to index i

  while (containsIndex){
    if (selected.Contains(index)){
    //if selected already contains the newly generated  intF

    index = RandomIndex();




    }else {
      UnityEngine.Debug.Log("index(LoadAray):"+index);
      selected[i] = index;
      containsIndex = false;
    }


  }


}
selected[12] = 12;//MAKE SURE 12 IS LAST 12 IS ARE HIDDEN ONE THAT STOPS THE GAME a little hacky but hey it works


}

public void swapArrays(){

for(int i =0;i<12;i++){

spheres[i]=balls[i];


}



}











}
