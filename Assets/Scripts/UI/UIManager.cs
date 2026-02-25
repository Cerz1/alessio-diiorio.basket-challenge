using UnityEngine;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<UIPanel> panels;

    private void OnEnable() => GameEvents.OnStateRequest += HandleStateRequest;
    private void OnDisable() => GameEvents.OnStateRequest -= HandleStateRequest;

    private void Start() => HandleStateRequest(GameState.MainMenu); // Initial state

    private void HandleStateRequest(GameState newState)
    {
        foreach (var panel in panels)
        {
            panel.SetVisible(panel.State == newState);
        }
    }

    // Inspector methods for buttons
    public void RequestGameplay() => GameEvents.OnStateRequest?.Invoke(GameState.Gameplay);
    public void RequestMainMenu() => GameEvents.OnStateRequest?.Invoke(GameState.MainMenu);
    public void QuitGame() => Application.Quit();
}