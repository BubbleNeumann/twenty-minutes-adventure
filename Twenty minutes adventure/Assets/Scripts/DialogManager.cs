using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


namespace DialogWindow
{
    public class DialogManager : MonoBehaviour
    {
        [Header("Dialog UI")]
        [SerializeField] private GameObject dialogPanel;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI dialogText;
        [SerializeField] private Animator portraitAnimator;

        [Header("Choices UI")]
        [SerializeField] private GameObject[] choices;
        private TextMeshProUGUI[] choicesText;

        [Header("Load Globals JSON")]
        [SerializeField] private TextAsset loadGlobalsJSON;

        private Story currentStory;
        public static bool dialogIsPlaying = false;

        private const string SPEAKER_TAG = "speaker";
        private const string PORTRAIT_TAG = "portrait";

        private static DialogManager instance;
        private DialogueVariables dialogueVariables;
        public static string sceneName;


        public static bool getDialogWindowIsActive()
        {
            return dialogIsPlaying;
        }

        private void Start()
        {

            dialogIsPlaying = false;
            dialogPanel.SetActive(false);
            choicesText = new TextMeshProUGUI[choices.Length];
            int index = 0;
            foreach (GameObject choice in choices)
            {
                choicesText[index++] = choice.GetComponentInChildren<TextMeshProUGUI>();
            }
        }

        private void Awake()
        {
            instance = this;
            sceneName = SceneManager.GetActiveScene().name;
            dialogueVariables = new DialogueVariables(loadGlobalsJSON);
        }

        public static DialogManager GetInstance()
        {
            return instance;
        }

        public void EnterDialogMode(TextAsset inkJSON)
        {
            currentStory = new Story(inkJSON.text);
            dialogIsPlaying = true;
            dialogueVariables.StartListening(currentStory);
            nameText.text = "???";
            portraitAnimator.Play("default");
            dialogPanel.SetActive(true);
            ContinueStory();
        }

        private IEnumerator ExitDialogMode()
        {
            yield return new WaitForSeconds(0.2f);
            dialogIsPlaying = false;
            dialogueVariables.StopListening(currentStory);
            dialogPanel.SetActive(false);
            dialogText.text = "";
            dialogueVariables.SaveVariables();
        }

        private void Update()
        {
            if (!dialogIsPlaying)
            {
                return;
            }
            else
            {
                if (currentStory.currentChoices.Count == 0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)))
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
                HandleTags(currentStory.currentTags);
            }
            else
            {
                StartCoroutine(ExitDialogMode());
            }
        }

        private void DisplayChoices()
        {
            List<Choice> currentChoices = currentStory.currentChoices;



            // defensive check to make sure our UI can support the number of choices coming in
            if (currentChoices.Count > choices.Length)
            {
                Debug.LogError("More choices were given than the UI can support. Number of choices given: "
                    + currentChoices.Count);
            }

            int index = 0;
            foreach (Choice choice in currentChoices)
            {
                choices[index].gameObject.SetActive(true);
                choicesText[index++].text = choice.text;
            }

            for (int i = index; i < choices.Length; i++)
            {
                choices[i].gameObject.SetActive(false);
            }

            StartCoroutine(SelectFirstChoice());
        }


        private IEnumerator SelectFirstChoice()
        {
            EventSystem.current.SetSelectedGameObject(null);
            yield return new WaitForEndOfFrame();
            EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
        }

        public void MakeChoice(int choiceIndex)
        {
            currentStory.ChooseChoiceIndex(choiceIndex);
            ContinueStory();
        }

        private void HandleTags(List<string> currentTags)
        {
            // loop through each tag and handle it accordingly
            foreach (string tag in currentTags)
            {
                // parse the tag
                string[] splitTag = tag.Split(':');
                if (splitTag.Length != 2)
                {
                    Debug.LogError("Tag could not be appropriately parsed: " + tag);
                }
                string tagKey = splitTag[0].Trim();
                string tagValue = splitTag[1].Trim();

                // handle the tag
                switch (tagKey)
                {
                    case SPEAKER_TAG:
                        nameText.text = tagValue;
                        break;
                    case PORTRAIT_TAG:
                        portraitAnimator.Play(tagValue);
                        break;
                    default:
                        Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                        break;
                }
            }
        }

        public Ink.Runtime.Object GetVariableState(string variableName)
        {
            Ink.Runtime.Object variableValue = null;
            dialogueVariables.variables.TryGetValue(variableName, out variableValue);
            if (variableValue == null)
            {
                Debug.LogWarning("Ink Variable was found to be null: " + variableName);
            }
            return variableValue;
        }
    }

}
