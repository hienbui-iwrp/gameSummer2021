using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    Vector3 offset = new Vector3(0, 0, -50);
    float smoothing;

    private void FixedUpdate()
    {
        if (transform.position != player.position)
        {
            Vector3 newPosition = new Vector3(player.position.x, player.position.y, transform.position.z);
            newPosition.x = Mathf.Clamp(newPosition.x, minPosition.x, maxPosition.x);
            newPosition.y = Mathf.Clamp(newPosition.y, minPosition.y, maxPosition.y);
            transform.position = newPosition;
            // transform.position = Vector3.Lerp(transform.position, newPosition, smoothing);
            // Debug.Log(smoothing);
        }
    }



}
