using UnityEngine;

public class WelcomeNPCScript : MonoBehaviour
{
    public GameObject NPCText;

    public bool showDebugMessages;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            NPCText.active = true;
            if (showDebugMessages)
            {
                Debug.Log("Collision Enter");
               
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            NPCText.active = false;
            if (showDebugMessages)
            {
                Debug.Log("Collision Exit");
            }
        }
    }

    public void StartAnimation()
    {

    }

    public void EndAnimation()
    {

    }
}
