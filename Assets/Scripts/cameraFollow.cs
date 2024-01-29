using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float speed;
    public Vector3 offset;

    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z) + offset;
    }

}