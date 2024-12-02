using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uLipSync;
using UnityEngine;

public class AnimatorController : AutoActor, ISubActor, ISubNode, ISubSentiment
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private uLipSyncTexture _lipSync;

    [SerializeField]
    private Transform _eyebrows;

    [SerializeField]
    private float minEyebrowY;

    [SerializeField]
    private float maxEyebrowY;

    [SerializeField]
    private float speed = 2f;

    private float _eyebrowY;
    private Sentiment _sentiment;

    private void Update()
    {
        _eyebrows.localPosition = Vector3.Lerp(
            _eyebrows.localPosition,
            new Vector3(
                _eyebrows.localPosition.x,
                Mathf.Lerp(minEyebrowY, maxEyebrowY, _eyebrowY),
                _eyebrows.localPosition.z),
            Time.deltaTime * speed);

        _animator.SetBool("Talking", ActorController.IsTalking);

        var mood = Mathf.Lerp(
            _animator.GetFloat("Mood"),
            _sentiment.Score,
            Time.deltaTime * speed);
        _animator.SetFloat("Mood", mood);

        var weight = ActorController.VoiceVolume;
        if (ActorController.IsTalking)
            weight += 0.5f;
        weight = Mathf.Lerp(
            _animator.GetLayerWeight(1),
            weight,
            Time.deltaTime * speed);
        _animator.SetLayerWeight(1, weight);
    }

    public void Activate(ChatNode node)
    {

    }

    public void UpdateActor(ActorContext context)
    {
        _animator.Play(context.Actor.Name, 2);
    }

    public void UpdateSentiment(Sentiment sentiment)
    {
        if (sentiment == null)
            return;

        _animator.Play(sentiment.Name, 0);

        _eyebrowY = (sentiment.Score + 1f) / 2f;

        _lipSync.initialTexture = sentiment.Lips;
        _lipSync.textures.First().texture = sentiment.Lips;
        _sentiment = sentiment;
    }
}