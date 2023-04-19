using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMusic : MonoBehaviour
{
    private float volumeMusic;
    public Slider volumeSlider;
    public GameObject objMusic;
    private AudioSource audioSource;

    private void Start()
    {
        objMusic = GameObject.FindWithTag("GameMusic");// pega o gameObject que recebe a tag do audiosource do menu
        audioSource = objMusic.GetComponent<AudioSource>();// chama o audio source do menu
        volumeMusic = PlayerPrefs.GetFloat("volume");// cria um player prefs no valor float
        volumeMusic = audioSource.volume; // recebe o valor atual do volume do menu
        volumeSlider.value = volumeMusic; // passa o valor do volume do menu para o slider do jogo
    }
    private void Update()
    {
        audioSource.volume = volumeSlider.value;// poder alterar o volume com o slider
        PlayerPrefs.SetFloat("volume", volumeMusic);
    }


}
