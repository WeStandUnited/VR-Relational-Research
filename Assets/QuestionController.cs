using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System;

public class QuestionController : MonoBehaviour
{
  private string path = @"C:\Users\Cj\Desktop\Questions.txt";
  //@"C:\Expirments\Questions.txt";


  List<string> questionList;










    // Start is called before the first frame update
    void Start()
    {
        //Load List of Strings
        LoadQuestionList();
        UnityEngine.Debug.Log(questionList[1]);
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void LoadQuestionList(){


        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                //UnityEngine.Debug.Log(s);
              questionList.Add(s.Substring(8));
            }
        }
    }//LoadQuestionList







}
