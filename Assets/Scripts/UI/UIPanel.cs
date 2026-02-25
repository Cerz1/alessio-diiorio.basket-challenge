using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class UIPanel : MonoBehaviour
{
    [SerializeField] private GameState _panelState;
    public GameState State => _panelState;

    private CanvasGroup _canvasGroup;

    private void Awake() => _canvasGroup = GetComponent<CanvasGroup>();

    public void SetVisible(bool visible) // Toggle for activation and deactivation
    {
        _canvasGroup.alpha = visible ? 1 : 0;
        _canvasGroup.interactable = visible;
        _canvasGroup.blocksRaycasts = visible;
    }
}