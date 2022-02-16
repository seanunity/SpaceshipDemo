using System.Collections;
using System.Collections.Generic;
using Unity.ClusterDisplay;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class RegisterTimeline : MonoBehaviour
{
    [SerializeField][HideInInspector]
    private PlayableDirector playableDirector;

    private readonly static Dictionary<string, PlayableDirector> playableDirectors = new Dictionary<string, PlayableDirector>();
    public string uniqueName = "Timeline";

    public static bool TryGet(string uniqueName, out PlayableDirector playableDirector) => playableDirectors.TryGetValue(uniqueName, out playableDirector);

    private void OnValidate()
    {
        playableDirector = GetComponent<PlayableDirector>();
        if (playableDirector == null)
            return;

        playableDirectors.TryAdd(uniqueName, playableDirector);
    }

    private void OnEnable () => OnValidate();
}
