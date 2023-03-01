using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boot : MonoBehaviour
{
    [SerializeField] private GameObject systemCanvas;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(systemCanvas);
        Fader.Instance.FadeOut(() =>
        {
            SceneManager.LoadSceneAsync("Title");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
