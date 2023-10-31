using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float edgeScrollSpeed = 5f;
    public float cameraLockX = 0f;
    public float cameraLockY = 0f;

    private bool cameraLocked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);

        Vector3 targetPosition = target.transform.position;
        Vector3 cameraPosition = transform.position;

        if (targetPosition.x > cameraPosition.x && targetPosition.x > cameraLockX && !cameraLocked)
        {
            float moveAmount = (targetPosition.x - cameraPosition.x) * edgeScrollSpeed * Time.deltaTime;
            cameraPosition.x = moveAmount;
            transform.position = cameraPosition;
        }

        if (cameraPosition.x >= cameraLockX && !cameraLocked)
        {
            cameraLocked = true;
            transform.position = new Vector3(cameraLockX, cameraPosition.y, cameraPosition.z);
        }

    }
}
