using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pickle;

public class Boot : MonoBehaviour
{
    [SerializeField] private GameObject systemCanvas;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(systemCanvas);
        Fader.Instance.FadeOut(1,0, () =>
        {
            SceneManager.LoadSceneAsync("Title");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
