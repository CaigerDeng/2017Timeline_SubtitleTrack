using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class SubtitileMixerBehaviour : PlayableBehaviour
{
    private Text trackBinding = null;

    public override void OnGraphStart(Playable playable)
    {
        // 这个playable就是SubtitileMixerBehaviour

    }

    public override void OnGraphStop(Playable playable)
    {

    }

    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {

    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {

    }

    public override void PrepareFrame(Playable playable, FrameData info)
    {

    }

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        trackBinding = playerData as Text;
        if (trackBinding == null)
        {
            return;
        }
        string content = "";
        int inputCount = playable.GetInputCount();
        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            if (!Mathf.Approximately(inputWeight, 0f))
            {
                ScriptPlayable<SubtitileBehaviour> inputPlayable = (ScriptPlayable<SubtitileBehaviour>)playable.GetInput(i);
                SubtitileBehaviour input = inputPlayable.GetBehaviour();
                content = input.content;
            }
        }
        trackBinding.text = content;
        trackBinding.gameObject.SetActive(trackBinding.text != "");

    }

}
