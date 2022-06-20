using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frozing : MonoBehaviour
{
    public AudioClip crack;
    private AudioSource player;
    private float[] data;
    public Sprite[] frozing;
    public Image Wind;
    private int counter;
    public Sprite filledTexture;
    public GameObject FrozedWindow;

    void Start()
    {
        FrozedWindow.SetActive(false);
        player = GetComponent<AudioSource>();
        player.clip = crack;
        player.Play();
         data = new float[crack.samples * crack.channels];
        crack.GetData(data, 0);
            print(data.Length);
        float mx = 0;
        
        foreach (float d in data)
            if (d > mx)
            {
                mx = d;
            }
        print("max=" + mx);
        counter = frozing.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        float current = data[player.timeSamples];
        
        if(current>0.005f)
        {
            print("*************************");
            if(counter>0)
            Wind.sprite = frozing[counter--];
            
        }
        if (!player.isPlaying)
        {
            Wind.sprite = filledTexture;
            Wind.gameObject.SetActive(false);
            FrozedWindow.SetActive(true);
        }
    }
}
