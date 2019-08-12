using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntroTyping : MonoBehaviour
{
  public static string currentID = "0";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*

    Intro Methods

    */

    public void Trigger(){
      if (IntroTyping.currentID.Length == 3){
        IntroTyping.currentID = "0";

      }

    


if (IntroTyping.currentID != "0"){

  IntroTyping.currentID = IntroTyping.currentID + gameObject.name;
}else {
  IntroTyping.currentID = gameObject.name;

}





/*
else if (StageController.userid.Substring(2) != "0"){

  StageController.userid.Substring(2) = gameObject.name;
}

*/






    }

    public void ClearTrigger(){

      IntroTyping.currentID = "0";}

/*

Survey Methods

*/

      public void submitTrigger(){



           StageController.submit = true;
           StageController.userid = IntroTyping.currentID;
            //UnityEngine.Debug.Log(StageController.submit);
          }



    public void SurveyTrigger(){


      QuestionController.currentScore += gameObject.name;



}
public void SurveyTrigger10(){


  //  QuestionController.currentScore = null;

//    }else {
  QuestionController.currentScore = "10";


//  }
}
public void SurveysubmitTrigger(){



     QuestionController.Qsubmit = true;

}
public void SurveyClearTrigger(){




QuestionController.currentScore = "0";


}
}
