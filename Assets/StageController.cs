using System.IO;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
  public static string userid = "1";
  public static int currentStageNum;
  public static bool submit = true;
  public static string path = @"C:\Expirments\";
  /*0 is INTRO - User selects there ID number
    1 is The challenge game the User is given
    2 is the questionaire the user is given at the end
  */
    // Start is called before the first frame update
    void Start()
    {
      currentStageNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (userid.Length >= 1 && submit == true){
        currentStageNum = 1;
        path = path+userid+".csv";

        submit = false;
        switch(currentStageNum){

          case 1:
          //if the submit button is selected with at least 1=> int eg(21 or 1)
          if (File.Exists(path)){

            currentStageNum = 0;


          }
          break;

          case 2:



          break;

          default:


          break;
  }
      }












      }
    }
