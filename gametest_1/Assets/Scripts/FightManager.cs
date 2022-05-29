using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FightManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Fightpanel;
    public GameObject GoPanel;
    public Text ScoreTxt;

    public Text QuestionTxt;
    int totalQuestions = 0;
    public int score;
    private void Start(){
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry(){
        SceneManager.LoadScene("Lvl1");
    }
    public void GameOver(){
        Fightpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void wrong(){
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    public void correct(){
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void SetAnswers(){

        for (int i = 0; i < options.Length; i++){
            options[i].GetComponent<AnswersScripts>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if(QnA[currentQuestion].CorrectAnswer == i+1){
                options[i].GetComponent<AnswersScripts>().isCorrect = true;
            }
        }
    }
    void generateQuestion(){
        if(QnA.Count > 0){
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else{
            Debug.Log("Out of Questions");
            GameOver();
        }
       
    }
}
