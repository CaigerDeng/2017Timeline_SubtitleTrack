using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

[TrackColor(0.854f, 0.274f, 0.811f)]
[TrackClipType(typeof(SubtitileClip))]
[TrackBindingType(typeof(Text))]
[System.Serializable]
public class SubtitileTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<SubtitileMixerBehaviour>.Create(graph, inputCount);

    }

}
