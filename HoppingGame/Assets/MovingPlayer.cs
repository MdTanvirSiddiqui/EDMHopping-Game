using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    public float speedModifier;

    private Touch touch;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                     transform.position.y + touch.deltaPosition.y * speedModifier
                     , transform.position.z + touch.deltaPosition.y * speedModifier
                    );
                Debug.Log("Moving ball: " + transform.position);
            }
        }
    }
}
