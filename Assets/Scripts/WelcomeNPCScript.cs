using UnityEngine;

public class WelcomeNPCScript : MonoBehaviour
{
    public GameObject NPCText;
    public Animator NPCTextAnimation;

    public bool showDebugMessages;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NPCText.active = false;
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
            NPCTextAnimation.Play("TextAreaOpenAnimation");
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
            NPCTextAnimation.Play("TextAreaExitAnimation");
            if (showDebugMessages)
            {
                Debug.Log("Collision Exit");
            }
        }
    }

    private void HideTextAfterEndAnimationEnds()
    {
        NPCText.active = false;
    }
}
