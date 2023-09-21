using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    public AudioSource source;
    public void ProcessHit()
    {
        // TODO React to hit
        source.Play();
        Invoke("HideTarget", 0.25f);
        GameManager.Instance.IncrementScore();
        Invoke("ResetTarget", 0.5f);
    }

    void HideTarget()
    {
        gameObject.SetActive(false);
    }

    void ResetTarget()
    {
        gameObject.SetActive(true);
        transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }

}
