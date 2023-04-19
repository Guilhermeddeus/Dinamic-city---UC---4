using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private Transform playerPosition;
    public GameObject player;
    public float height;
    void Awake()
    {
        playerPosition = player.transform;// retornar a posicao do player
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPosition.position.x, height, transform.position.z);// fazer a camera seguir o player
    }
}
