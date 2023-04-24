using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo_Restart : MonoBehaviour
{

    public GameObject player;
   
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //verifica quando o personagem esta em contato com um solo para liberra a flag q permite o personagem pular
        if (collision.gameObject == player)
        {

            DataControl.podepular = true;
            DataControl.skill = true;
            


        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //verifica quando o personagem nao esta em contato com um solo para bloquear a flag q permite o personagem pular
        if (collision.gameObject == player)
        {

            DataControl.podepular = false;


        }
    }
}
