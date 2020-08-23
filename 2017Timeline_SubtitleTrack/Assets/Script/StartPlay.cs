using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class StartPlay : MonoBehaviour
{
    public PlayableDirector dire; 

    public void ClickStart()
    {
        dire.Play();
    }

}
