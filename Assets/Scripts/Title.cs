using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
        Fader.Instance.FadeIn();

        startPanel.onClick.AddListener(() =>
        {
            Fader.Instance.FadeOut(() =>
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
