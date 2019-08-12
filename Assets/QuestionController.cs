using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System;

public class QuestionController : MonoBehaviour
{
  private string path = @"C:\Expirments\bin\Questions.txt";
  //@"C:\Expirments\Questions.txt";


  List<string> questionList = new List<string>(12);
  public static string currentQuestion;
  public static int currentQuestionPointer = 0;
  public static bool Qsubmit;
  public static string currentScore = "0";







    // Start is called before the first frame update
    void Start()
    {
        //Load List of Strings
        LoadQuestionList();//NullReferenceException
        currentQuestion = questionList[currentQuestionPointer];

        UnityEngine.Debug.Log(questionList[0]);

    }

    // Update is called once per frame
    void Update()
    {

      try {

      if (Qsubmit){// if question score is sumbitted and Score is not null
        Qsubmit = false;
        StageController.userScore = StageController.userScore + currentScore + ",";
      //  UnityEngine.Debug.Log("StageC_UserScore:"+StageController.userScore);
      //  UnityEngine.Debug.Log("currentScore:"+currentScore);
        currentQuestionPointer++;

        currentQuestion = questionList[currentQuestionPointer];


        currentScore = null;



      }
    }
    catch(ArgumentOutOfRangeException ex){

      currentQuestion = "Done!";
      RandomSelector.WriteAll();
    }
    }



    public void LoadQuestionList(){


        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                //UnityEngine.Debug.Log(s);
              questionList.Add(s.Substring(9));
            }
        }
    }//LoadQuestionList







}
