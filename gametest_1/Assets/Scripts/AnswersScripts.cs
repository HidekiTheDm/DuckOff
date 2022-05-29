using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswersScripts : MonoBehaviour
{   public bool isCorrect = false;
    public FightManager quizManager;
    // Start is called before the first frame update
    public void Answer(){
        if(isCorrect){
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else{
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
