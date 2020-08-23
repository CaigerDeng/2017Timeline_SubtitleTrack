using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
    public LightControlBehaviour template = new LightControlBehaviour();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        // template就是Clip暴露在Inspector面板的一系列值
        // 这里就是LightControlBehaviour那四个public属性值
        var playable = ScriptPlayable<LightControlBehaviour>.Create(graph, template);
        return playable;
    }
}
