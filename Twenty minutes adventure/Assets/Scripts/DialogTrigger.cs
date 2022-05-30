using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogWindow;
using UnityEngine.SceneManagement;
using Ink.Runtime;
// using static VideoPlayer.VideoPlayer;
// using System;
// using System.Windows.Forms;

namespace DialogTrigger
{
    public class DialogTrigger : MonoBehaviour
    {
        private bool playerInRange = false;

        [SerializeField] private bool objectIsTrigger;
        [Header("InkJSON")]
        [SerializeField] private TextAsset inkJSON;
        // private GameObject player;
        private UnityEngine.Video.VideoPlayer videoPlayer;


        void Start()
        {
            try
            {
                videoPlayer = GameObject.Find("Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
                videoPlayer.Pause();
                videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraFarPlane;
            }
            catch
            {
                
            }

        }

        public void StartConversation()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

        public void Update()
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("donuts_chosen")).value || ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("case_closed")).value)
            {
                // var videoPlayer = GameObject.Find("Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
                try
                {
                    videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
                    // videoPlayer.frame = 1;
                    videoPlayer.Play();
                }
                catch
                {
                    
                }
                
                // while(videoPlayer.frame < 100)
                // {
                //     videoPlayer.Play();
                //     videoPlayer.frame += 1;
                //     videoPlayer.Pause();
                // }
               
                // Destroy(videoPlayer, 10000);
                // play credits cutscene
            
                // VideoPlayer.playCredits();
                
                // gameObject.GetComponent<VideoPlayer>().playCredits();
                // VideoPlayer.playCredits();
                // VideoPlayer player = new VideoPlayer();
                // player.playCredits();
                // Action foobar = () => foo.bar.foobar();
                // Action playCredits = () => VideoPlayer.VideoPlayer.playCredits();
                // GameObject camera = GameObject.Find("Main Camera");
                
                // camera.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
                // var videoPlayer = camera.GetComponent<UnityEngine.Video.VideoPlayer>();

                // Debug.Log(videoPlayer);


                // videoPlayer.url = "/Users/graham/movie.mov";
                // videoPlayer.SetActive(true);
                // videoPlayer.url = "Titry_3.mp4";
                // videoPlayer.Play();
                // videoPlayer.SetActive(true);
                // GameObject player = GameObject.Find("Video Player");
                // player.SetActive(true);
                // Destroy(player, 10000);
                // player.Play();

                // GameObject camera = GameObject.Find("Main Camera");

                // VideoPlayer automatically targets the camera backplane when it is added
                // to a camera object, no need to change videoPlayer.targetCamera.
                // var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();

                // Play on awake defaults to true. Set it to false to avoid the url set
                // below to auto-start playback since we're in Start().
                

                // By default, VideoPlayers added to a camera will use the far plane.
                // Let's target the near plane instead.
                // videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;

                // This will cause our Scene to be visible through the video being played.
                // videoPlayer.targetCameraAlpha = 0.5F;

                // Set the video to play. URL supports local absolute or relative paths.
                // Here, using absolute.
                // videoPlayer.url = "file://C:/Users/bubbl/twenty-minutes-adventure/Twenty minutes adventure/Assets/Sprites/Titry_3.mp4";
                // videoPlayer.playOnAwake = true;
                // Skip the first 100 frames.
                // videoPlayer.frame = 100;

                // Restart from beginning when done.
                // videoPlayer.isLooping = true;

                // Each time we reach the end, we slow down the playback by a factor of 10.
                // videoPlayer.loopPointReached += EndReached;

                // Start playback. This means the VideoPlayer may have to prepare (reserve
                // resources, pre-load a few frames, etc.). To better control the delays
                // associated with this preparation one can use videoPlayer.Prepare() along with
                // its prepareCompleted event.
                // videoPlayer.Play();

                SceneManager.LoadScene("Menu");
            }
        }

        public void ToCrimeScene()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && !((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value) {
                SceneManager.LoadScene("CrimeScene");
            }
        }

        public void toSecondLoc()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
            {
                SceneManager.LoadScene("SecondLocation");
                PlayerPrefs.SetString("current_scene", "SecondLocation");
            }
        }

        public void RightDoor()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                SceneManager.LoadScene("cabinet");
                PlayerPrefs.SetString("current_scene", "cabinet");
            }
        }

        public void ToPoliceStation()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive())
            {
                SceneManager.LoadScene("police station");
                PlayerPrefs.SetString("current_scene", "police station");
            }
        }

        public void myCar2()
        {
            if (playerInRange && !DialogManager.getDialogWindowIsActive() && ((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("started_conversation_Stepanida")).value)
            {
                SceneManager.LoadScene("police station");
                PlayerPrefs.SetString("current_scene", "police station");
            }
        }

        public void myCar()
        {
            if (((Ink.Runtime.BoolValue)DialogManager.GetInstance().GetVariableState("call_accepted")).value)
            {
                SceneManager.LoadScene("SecondLocation");
                PlayerPrefs.SetString("current_scene", "SecondLocation");
            }
            else
            {
                DialogManager.GetInstance().EnterDialogMode(inkJSON);
            }
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = true;
                if (objectIsTrigger)
                {
                    StartConversation();
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = false;
            }
        }
    }
}

