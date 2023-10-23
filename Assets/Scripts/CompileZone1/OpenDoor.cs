using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OpenDoor : MonoBehaviour
{
    public PlayableDirector playableDirector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            playableDirector.Play();
            Debug.Log("Open！");
        }
    }

}
