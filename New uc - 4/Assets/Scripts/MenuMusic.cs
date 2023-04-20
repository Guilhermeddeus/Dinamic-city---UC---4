using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMusic : MonoBehaviour
{
    public Slider music;
    public AudioSource sound;
    void Start()
    {
        music.value = 0;// valor da musica recebe 0
    }

    // Update is called once per frame
    void Update()
    {
        sound.GetComponent<AudioSource>().volume = music.value;// para poder mexer o volume com o slider
    }
}
