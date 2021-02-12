using UnityEngine;

public class CamFollower : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
