using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTyping : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Trigger(){

      if (StageController.userid.Length == 3){


StageController.userid = "0";

      }else {
StageController.userid += gameObject.name;


      }


    }
    public void submitTrigger(){



         StageController.submit = true;
          UnityEngine.Debug.Log(StageController.submit);



    }
    public void ClearTrigger(){

      StageController.userid = "0";


    }
    public void SurveyTrigger(){

      

      if (StageController.userScore.Length == 2){


        StageController.userScore = "0";

      }else {
      StageController.userScore += gameObject.name;


      }
}
}
