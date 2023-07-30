using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalloons : MonoBehaviour
{
    public float timer = 0f;
     float timeLeft = 0f;
    
    public AudioClip audioClip;
    public GameObject effect;

     void Update()
    {
        if(timeLeft >=timer)
        {
            BlowUp();
        }
        else
        {
            timeLeft = timeLeft = Time.deltaTime;
        }
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        PlaySounnd();
    }
    
    void BlowUp()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void PlaySounnd()
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
    }
}
