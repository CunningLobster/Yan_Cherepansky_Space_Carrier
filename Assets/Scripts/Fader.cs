using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fader : MonoBehaviour
{
    CanvasGroup canvasGroup;
    [SerializeField] float startValue = 1f;
    [SerializeField] float duration = 2f;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha =startValue;
    }

    private void Start()
    {
        canvasGroup?.DOFade(0, duration);
    }

    public void FadeIn()
    {
        if(canvasGroup != null)
            canvasGroup.DOFade(1, .5f);
    }

}
