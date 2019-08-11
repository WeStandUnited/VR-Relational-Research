using System.IO;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
  public GameObject[] stages =  new GameObject[3];
  public static string userid = "0";//this will be changed by the user
  public static string userScore;
  public static int currentStageNum;
  public static bool submit = false;
  public static string path = @"C:\Expirments\";
  /*0 is INTRO - User selects there ID number
    1 is The challenge game the User is given
    2 is the questionaire the user is given at the end
  */
    // Start is called before the first frame update
    void Start()
    {
      currentStageNum = 0;
      stages[0].SetActive(true);
      stages[1].SetActive(false);
      stages[2].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
      if (submit == true){
        //currentStageNum = 1;


        submit = false;
        switch(currentStageNum){

          case 1:
          path = path+userid+".csv";
          //if the submit button is selected with at least 1=> int eg(21 or 1)
          if (File.Exists(path)){

            currentStageNum = 0;
            path =  @"C:\Expirments\";

          }else {

            stages[0].SetActive(false);

            stages[currentStageNum].SetActive(true);
            currentStageNum = 1;


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
