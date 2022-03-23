using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TutorialScript : MonoBehaviour
{
    private int tutorialCounter;
    [SerializeField] private string[] tutorialText;
    [SerializeField] private TextMeshPro tutorial;
    [SerializeField] private GameObject tutorObj;
        
    void Start () {
        tutorialCounter = 0;
        Debug.Log(tutorialText.Length);
        TutorialSwitch();
    }
    
    public void Next () {
        tutorialCounter++;
        TutorialSwitch();
    }

    public void Previous () {
        if(tutorialCounter != 0) {
            tutorialCounter--;
            TutorialSwitch();
        }
    }

    private void TutorialSwitch () {
        if (tutorialCounter == tutorialText.Length) {
            tutorObj.SetActive(false);
        }

        tutorial.text = tutorialText[tutorialCounter];
    }
}
