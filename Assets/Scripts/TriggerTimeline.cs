using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTimeline : MonoBehaviour
{
    [SerializeField] private string timelineName;
    private void OnEnable ()
    {
        if (RegisterTimeline.TryGet(timelineName, out var playableDirector))
            playableDirector.Play();
    }
}
