using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
  public static int currentStageNum;
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
      switch(currentStageNum){

        case 1:
        //if the submit button is selected with at least 1=> int eg(21 or 1)

        break;

        case 2:



        break;

        default:


        break;
}
      }
    }
