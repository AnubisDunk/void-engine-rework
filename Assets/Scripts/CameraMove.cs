using UnityEngine;

public class CameraMove : MonoBehaviour
{
   
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
