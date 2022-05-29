using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class NPC_Fight : MonoBehaviour
{
    public Transform NPCCharacter;

    private DiaFightManager dialogueSystem;

    public string Name;
    
    [TextArea(5, 10)]
    public string[] sentences;
    void Start()
    {
        dialogueSystem = FindObjectOfType<DiaFightManager>();
    }

    // Update is called once per fram
     public void OnTriggerStay(Collider other)
    {   
        if(other.gameObject.tag != "Player") return;
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
          SceneManager.LoadScene("WordFight 1");
        }
    }
    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag != "Player") return;
        this.gameObject.GetComponent<NPC_Fight>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
    }
     public void OnTriggerExit(Collider other)
    {   if(other.gameObject.tag != "Player") return;
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<NPC_Fight>().enabled = false;
    }
}
