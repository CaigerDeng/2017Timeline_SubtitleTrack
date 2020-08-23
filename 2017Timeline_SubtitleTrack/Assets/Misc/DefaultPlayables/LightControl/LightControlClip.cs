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
        // template����Clip��¶��Inspector����һϵ��ֵ
        // �������LightControlBehaviour���ĸ�public����ֵ
        var playable = ScriptPlayable<LightControlBehaviour>.Create(graph, template);
        return playable;
    }
}
