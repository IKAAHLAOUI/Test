using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
        transform.position = newPosition;
    }

    void FixedUpdate()
    {
        
    }
}  
