using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public GameObject phone;

    #region Serialized Fields
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject dialogueText;
    [SerializeField] private GameObject displayName;
    [SerializeField] private TextAsset[] inkJSON;
    [SerializeField] private TextAsset[] listenAgain;
    [SerializeField] private GameObject[] choices;
    [SerializeField] private GameObject continueBtn;
    #endregion

    #region Private
    private Ink.Runtime.Story currentStory;
    private TextMeshProUGUI[] choicesText;
    private bool listenMore = false;
    private bool listenNext = false;
    private bool deliverNow = false;
    static private int caller;
    static private int prev_caller;

    private const string SPEAKER_TAG = "speaker";
    private const string LISTEN_TAG = "listen_again";
    private const string NEXT_TAG = "listen_next";
    private const string DELIVER_TAG = "deliver";
    private const string CALLER_TAG = "caller";
    private const string PREV_TAG = "prev_caller";
    //private const string PORTRAIT_TAG = "portrait";
    #endregion

    static public int storyOver;

    private void Awake()
    {
        dialoguePanel.SetActive(false);
    }
    private void Start()
    {
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            choices[index].SetActive(false);
            index++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DialogueTrigger"))
        {
            EnterDialogueMode();
        }
    }

    public void StartCall()
    {
        phone.SetActive(false);
        EnterDialogueMode();
    }

    private void EnterDialogueMode()
    {
        dialoguePanel.SetActive(true);
        if (caller == 11)
        {
            currentStory = new Ink.Runtime.Story(inkJSON[1].text);
        }
        else if (caller == 12 || caller == 22)
        {
            currentStory = new Ink.Runtime.Story(inkJSON[3].text);
        }
        else
        {
            currentStory = new Ink.Runtime.Story(inkJSON[0].text);
        }
        
        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        dialoguePanel.SetActive(false);
        dialogueText.GetComponent<TMP_Text>().text = "";
        storyOver += 1;

        if(deliverNow)
        {
            SceneManager.LoadScene("DrivingTest");
        }
        else if(listenMore)
        {
            if(caller == 12 || caller == 22)
            {
                currentStory = new Ink.Runtime.Story(listenAgain[1].text);
            }
            else if(caller == 13 || caller == 23 || caller == 33)
            {
                currentStory = new Ink.Runtime.Story(listenAgain[3].text);
            }
            else
            {
                currentStory = new Ink.Runtime.Story(listenAgain[0].text);
            }

            dialoguePanel.SetActive(true);
            ContinueStory();
        }
        else if (listenNext)
        {
            if (caller == 12)
            {
                if (prev_caller == 22)
                {
                    currentStory = new Ink.Runtime.Story(listenAgain[2].text);
                }
                else
                {
                    currentStory = new Ink.Runtime.Story(inkJSON[2].text);
                }
            }
            else if (caller == 13)
            {
                if(prev_caller == 33)
                {
                    currentStory = new Ink.Runtime.Story(listenAgain[4].text);
                }
                else
                {
                    currentStory = new Ink.Runtime.Story(inkJSON[4].text);
                }
            }
            else if(caller == 23)
            {
                if(prev_caller == 33)
                {
                    currentStory = new Ink.Runtime.Story(listenAgain[5].text);
                }
                else
                {
                    currentStory = new Ink.Runtime.Story(inkJSON[5].text);
                }
            }
            
            dialoguePanel.SetActive(true);
            ContinueStory();
        }
    }

    //checks if the next line in the story is plain text
    //or a branching choice
    public void checkChoices()
    {
        //ensuring that story isn't null
        if (currentStory == null)
        {
            currentStory = new Ink.Runtime.Story(inkJSON[storyOver].text);
        }

        if (currentStory.currentChoices.Count > 0)
        {
            DisplayChoices();
            dialogueText.GetComponent<TMP_Text>().text = "";
            continueBtn.SetActive(false);

            HandleTags(currentStory.currentTags);
        }
        else
        {
            ContinueStory();
        }
    }
    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //hide choice buttons and shows next button
            choices[0].SetActive(false);
            choices[1].SetActive(false);
            continueBtn.SetActive(true);

            //plays the next line of plain text
            dialogueText.GetComponent<TMP_Text>().text = currentStory.Continue();

            HandleTags(currentStory.currentTags);
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void HandleTags(List<string> tags)
    {
        //tags in ink allow you change parts
        //of the display in unity after parsing them
        foreach (string tag in tags)
        {
            string[] splitTag = tag.Split(":");
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                //changes the name of who is speaking
                //at the bottom left of dialogue panel
                case SPEAKER_TAG:
                    displayName.GetComponent<TMP_Text>().text = tagValue;
                    break;
                case LISTEN_TAG:
                    listenMore = tagValue == "true";
                    break;
                case DELIVER_TAG:
                    deliverNow = tagValue == "true";
                    break;
                case NEXT_TAG:
                    listenNext = tagValue == "true";
                    break;
                case CALLER_TAG:
                    switch (tagValue)
                    {
                        case "11":
                            caller = 11;
                            break;
                        case "12":
                            caller = 12;
                            break;
                        case "22":
                            caller = 22;
                            break;
                        case "13":
                            caller = 13;
                            break;
                        case "23":
                            caller = 23;
                            break;
                        case "33":
                            caller = 33;
                            break;
                    }
                    break;
                case PREV_TAG:
                    switch (tagValue)
                    {
                        case "11":
                            prev_caller = 11;
                            break;
                        case "12":
                            prev_caller = 12;
                            break;
                        case "22":
                            prev_caller = 22;
                            break;
                        case "13":
                            prev_caller = 13;
                            break;
                        case "23":
                            prev_caller = 23;
                            break;
                        case "33":
                            prev_caller = 33;
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    //shows the choice buttons and sets their text equal to
    //the line written in the ink story
    private void DisplayChoices()
    {
        List<Ink.Runtime.Choice> currentChoices = currentStory.currentChoices;

        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index].text = currentChoices[index].text;
            choices[index].SetActive(true);
            index++;
        }

        SelectFirstChoice();
    }

    //necessary so unity event system allows player to make choices
    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    //tells ink file which choice has been selected
    //then continues down the correct branch of the story
    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

}
