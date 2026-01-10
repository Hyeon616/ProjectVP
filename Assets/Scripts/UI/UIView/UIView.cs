using System;
using UnityEngine;

public class UIView : MonoBehaviour, IUIToggle
{
    private IUIOpen[] _openActions;
    private IUIClose[] _closeActions;

    private bool _isOpen;
    
    private void Awake()
    {
        _openActions = GetComponents<IUIOpen>();
        _closeActions = GetComponents<IUIClose>();
        _isOpen = gameObject.activeSelf;
    }

    public void Open()
    {
        if(_isOpen)
            return;
        
        _isOpen = true;
        
        gameObject.SetActive(true);

        foreach (var openAction in _openActions)
        {
            openAction.Open();
        }
        
    }
    
    public void Close()
    {
        if(!_isOpen)
            return;
        
        _isOpen = false;
        
        foreach (var closeAction in _closeActions)
        {
            closeAction.Close();
        }
    }

    public void Toggle()
    {
        if(_isOpen)
            Close();
        else
            Open();
        
    }
}
