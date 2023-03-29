using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGenerator : MonoBehaviour
{
    public AudioClip se;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            audiosource.PlayOneShot(se);
        }
    }
}
