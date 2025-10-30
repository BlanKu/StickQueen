using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Target;

    Transform _trTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _trTarget = Target.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_trTarget.position.x, 0, -10);
    }
}
