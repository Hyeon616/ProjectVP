using UnityEngine;
using UnityEngine.UI;

public class UICloseButton : MonoBehaviour
{
    private UIView _uiView;
    private void Awake()
    {
        _uiView = GetComponentInParent<UIView>(true);

        GetComponent<Button>().onClick.AddListener(_uiView.Toggle);
    }
    
    
}
