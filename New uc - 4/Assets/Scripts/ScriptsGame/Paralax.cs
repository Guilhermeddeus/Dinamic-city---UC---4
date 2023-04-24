using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public GameObject objectMove,endLine,originalPosition;
    public float speed;
    float altura;


    // Start is called before the first frame update
    void Start()
    {
        altura=objectMove.transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        //realoca o fundo pra origialPosition conforme atinge a posiçao endline e movimenta a sprite na velocidade speed 
        objectMove.transform.Translate( -speed * Time.deltaTime, 0,0);
        if(objectMove.transform.position.x<=endLine.transform.position.x) 
        {
             objectMove.transform.position = new Vector2(originalPosition.transform.position.x,altura);
           
        }
    }
}
