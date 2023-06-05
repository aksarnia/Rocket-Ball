using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RocketBall.Scenes;

namespace RocketBall.Video
{
    public class VideoController : MonoBehaviour
    {
    bool videoLoadingStarted = false;
    float secondsRemaining = 0f;
    
    private void Start() 
    {
            StartCoroutine(DelayLoadLevel(12)); // Best to add 2-3 seconds to video length (seconds)
    }

        IEnumerator DelayLoadLevel(float seconds)
        {
            secondsRemaining = seconds;
            videoLoadingStarted = true;

            do
            {
                yield return new WaitForSeconds(1);
            } while (--secondsRemaining > 0);

            SceneManager.LoadScene(1);
        }

        private void OnGUI() 
        {
            if (videoLoadingStarted)
            {
                GUI.Label(new Rect(0, 0, 100, 20), secondsRemaining.ToString());
            }
        }
    }
}
