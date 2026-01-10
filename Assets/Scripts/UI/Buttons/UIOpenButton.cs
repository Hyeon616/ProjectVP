using System;
using UnityEngine;
using UnityEngine.UI;

public class UIOpenButton : MonoBehaviour
{
    [SerializeField] private UIView _uiView;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(_uiView.Toggle);
    }
}
