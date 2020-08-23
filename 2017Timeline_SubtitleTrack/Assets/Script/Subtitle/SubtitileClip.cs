using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[System.Serializable]
public class SubtitileClip : PlayableAsset, ITimelineClipAsset
{
    public SubtitileBehaviour template = new SubtitileBehaviour();

    public ClipCaps clipCaps
    {
        get
        {
            return ClipCaps.Blending; //选择None，clip当然不会支持快捷键淡入淡出操作
        }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        var playable = ScriptPlayable<SubtitileBehaviour>.Create(graph, template);       
        return playable;

    }

}
