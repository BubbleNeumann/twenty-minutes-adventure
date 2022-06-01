using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
 
public class VideoManager : MonoBehaviour
{
    public VideoPlayer vid;    
    
    public void Start(){vid.loopPointReached += CheckOver;}
    
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Menu");
    }
 
}