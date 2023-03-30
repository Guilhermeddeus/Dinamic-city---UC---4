using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEditor.Animations;



public class MovimetPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedPlayer;
    public float jump;
    public float gravity = 10f;
    public int health = 10;
    public Transform player,inicio;
    float x, y, z;
   






    private new Rigidbody2D rigidbody;

   
    void Start()
    {
        Debug.Log("começa jogo");
        rigidbody = GetComponent<Rigidbody2D>();
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");
        player.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speedPlayer * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && DataControl.podepular )
        {
           
           
            rigidbody.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }

        rigidbody.AddForce(Vector2.down * gravity * Time.deltaTime);
        Salva();
        Resete();   


      
    }

    void Salva()
    {
        if(Input.GetKeyDown(KeyCode.G) && DataControl.podesalva)
        {
            PlayerPrefs.SetFloat("x", player.transform.position.x);
            PlayerPrefs.SetFloat("y", player.transform.position.y);
            PlayerPrefs.SetFloat("z", player.transform.position.z);
        }
    }
    void Resete()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("x", inicio.transform.position.x);
            PlayerPrefs.SetFloat("y", inicio.transform.position.y);
            PlayerPrefs.SetFloat("z", inicio.transform.position.z);
        }
    }




}
