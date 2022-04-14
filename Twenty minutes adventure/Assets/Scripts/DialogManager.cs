using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogManager : MonoBehaviour
{
    [Header("Dialog UI")]
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private TextMeshProUGUI dialogText;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;
    public bool dialogIsPlaying;

    private static DialogManager instance;

    private void Start()
    {
        dialogIsPlaying = false;
        dialogPanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index++] = choice.GetComponentInChildren<TextMeshProUGUI>();
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public static DialogManager GetInstance()
    {
        return instance;
    }

    public void EnterDialogMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogIsPlaying = true;
        dialogPanel.SetActive(true);
        ContinueStory();
    }

    private void ExitDialogMode()
    {
        dialogIsPlaying = false;
        dialogPanel.SetActive(false);
        dialogText.text = "";
    }

    private void Update()
    {
        if (!dialogIsPlaying)
        {
            return;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                ContinueStory();
            }
        }
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogText.text = currentStory.Continue();
            DisplayChoices();
        }
        else
        {
            ExitDialogMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;
        int index = 0;
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex) 
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }
}
