using DG.Tweening;
using System;
using UnityEngine;

public class UIPopupAnimation : MonoBehaviour, IUIOpen, IUIClose
{
    private RectTransform _rect;

    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    public void Open()
    {
        _rect.DOKill();
        _rect.localScale = Vector3.zero;
        _rect.DOScale(1f,0.3f).SetEase(Ease.OutBack);
    }

    public void Close()
    {
        _rect.DOKill();
        _rect.DOScale(0f,0.2f)
            .SetEase(Ease.InBack)
            .OnComplete(()=> gameObject.SetActive(false));
            
    }
}
