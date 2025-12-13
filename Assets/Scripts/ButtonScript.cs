using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public string sceneNameToGo;

    private Button _button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeScene);
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneNameToGo);
    }
}
