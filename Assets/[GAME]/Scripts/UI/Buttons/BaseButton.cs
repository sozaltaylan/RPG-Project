using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    #region Variables

    [SerializeField] protected Button button;

    #endregion
    protected virtual void OnEnable()
    {
        button.onClick.AddListener(HandleButtonClicked);
    }
    protected virtual void OnDisable()
    {
        button.onClick.RemoveListener(HandleButtonClicked);
    }

    protected abstract void HandleButtonClicked();

}
