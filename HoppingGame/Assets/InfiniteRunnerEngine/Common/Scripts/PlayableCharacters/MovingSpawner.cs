using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpawner : MonoBehaviour
{
    public GameObject targetB;
    public GameObject targetC;
    public float t;
    private bool turn;
    // Start is called before the first frame update
    void Start()
    {
        turn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveSpawner();
    }

    public void MoveSpawner() {
        Vector3 a = transform.position;
        Vector3 b = targetB.transform.position;
        Vector3 c = targetC.transform.position;
        if (turn)
        {
            transform.position = Vector3.Lerp(a, b, t);
            turn = false;
            Debug.Log("Spawner position b");
        }
        else
        {
            transform.position = Vector3.Lerp(b, c, t);
            turn = true;
            Debug.Log("Spawner position c");
        }
    }
}
