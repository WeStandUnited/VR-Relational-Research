using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System;


public class RandomSelector : MonoBehaviour
{
private string filepath = @"C:\Users\Cj\Desktop\File.txt";
public List<GameObject> sphereList = new List<GameObject>(12);//List of spheres
public static List<int> selectedNums = new List<int>(12);//list of index order for spherelist spheres will be activated
public static int selectedPointer = 0;//starts at 0 when trigger from ColorChanger2 is delivered we increment by 1 index
int randomLineSelector = new System.Random().Next(0,35);//Selects Line from Set File with random sets from 0-11
public System.Diagnostics.Stopwatch stopWatch = new Stopwatch();



    // Start is called before the first frame update
    void Start()
    {
    ReadFromFile();
    selectedNums.Add(12);//THIS IS HERE TO BE ON THE END OF THE selectedNums to make it activate the hidden sphere
    UnityEngine.Debug.Log("NUMS:"+selectedNums[1]);
    stopWatch.Start();//start timer


    }

    // Update is called once per frame
    void Update()
    {
      if(ColorChanger2.trigger){

      selectedPointer++;
      WriteTime(stopWatch.ElapsedMilliseconds);
      ColorChanger2.trigger = false;
      stopWatch.Reset();
      }


    }

public void loadRandomSelection(){

for (int i=0;i<12;i++){
int index = RandomNumberGen();
while (selectedNums.Contains(index)){

index = RandomNumberGen();
}
selectedNums[i] = index;


selectedNums[11] = 11;


}
}


public int RandomNumberGen(){

int num = new System.Random().Next(0,35);//only 35 lines in the text doc (this is kinda sloppy i could use the lines of the File)





  return num;
}//Random Num Gen


public void ReadFromFile(){

StreamReader sr = new StreamReader(filepath);

string line = File.ReadLines(filepath).Skip(randomLineSelector).Take(1).First();
WriteHeader(line);
UnityEngine.Debug.Log(line);

//need to split line for commas into array them move array to List

selectedNums = StringToIntList(line).ToList();

}// ENd Read From File






//Testing
/*
foreach(int q in selectedNums){

  UnityEngine.Debug.Log(q);
}
*/
public static IEnumerable<int> StringToIntList(string str) {
    if (String.IsNullOrEmpty(str))
        yield break;

    foreach(var s in str.Split(',')) {
        int num;
        UnityEngine.Debug.Log(s);
        if (int.TryParse(s, out num))
            yield return num;
    }
}//End StringToIntList
public void WriteTime(long time){




}


public void WriteHeader(string line){




}



}
