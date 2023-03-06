using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Pickle;

public class Title : MonoBehaviour
{
    [SerializeField] private Button startPanel;
    [SerializeField] private TextMeshProUGUI titleText;

    // Start is called before the first frame update
    void Start()
    {
        if (Fader.Instance == null)
        {
            SceneManager.LoadSceneAsync("Boot");
            return;
        }
        Fader.Instance.FadeIn(1);

        startPanel.onClick.AddListener(() =>
        {
            Fader.Instance.FadeOut(1,0,() =>
            {
                SceneManager.LoadSceneAsync("GameMain");
            });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
