using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject PauseMenu;
    [SerializeField]
    private bool IsPaused = false; 
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
            if(IsPaused) { PauseGame(); }
            else { ResumeGame(); }
        }
        
    }

    void PauseGame (){
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        Debug.Log("tou em pausa");
    }
    void ResumeGame (){
         Time.timeScale = 1;
         PauseMenu.SetActive(false);
        Debug.Log("Voltei!");
    }

}
