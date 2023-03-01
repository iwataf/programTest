using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Fader.Instance == null)
        {
            SceneManager.LoadSceneAsync("Boot");
            return;
        }
        Fader.Instance.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
