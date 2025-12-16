using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [Header("Change Scene Button")]
    public string sceneNameToGo;

    [Header("Show/Hide Objects Button")]
    public List<GameObject> ShowHideObjects;

    [Header("Quit Game Button")]
    public bool isQuitButton;


    private Button _button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _button = GetComponent<Button>();

        if (sceneNameToGo != "")
        {
            _button.onClick.AddListener(ChangeScene);
        }
        else if (isQuitButton)
        {
            _button.onClick.AddListener(ClickExitButton);
        }
        else if (ShowHideObjects != null)
        {
            _button.onClick.AddListener(ShowOrHideObejects);
        }
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneNameToGo);
    }

    void ClickExitButton()
    {
        Application.Quit();
    }

    void ShowOrHideObejects()
    {
        for (int i = 0; i < ShowHideObjects.Count; i++)
        {
            if(ShowHideObjects[i].active == false)
            {
                ShowHideObjects[i].SetActive(true);
            }
            else
            {
                ShowHideObjects[i].SetActive(false);
            }
        }
    }
}
