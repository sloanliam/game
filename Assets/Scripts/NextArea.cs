using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextArea : MonoBehaviour
{
    public Camera mainCamera;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.NextRoom();
        Vector3 currentPosition = player.transform.position;
        currentPosition.x += 3;
        player.transform.position = currentPosition;
        mainCamera.transform.position = new Vector3(player.room * 19, 0, -10);
    }
}
