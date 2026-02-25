public enum GameState
{
    MainMenu = 0, // State for the main menu
    Gameplay = 1, // State for the HUD
    Reward = 2    // State for the reward menu
}

public static class GameEvents
{
    public static System.Action<GameState> OnStateRequest; // Invoked when a change state is required 

    public static System.Action<int> OnScoreUpdated; // Invoked when a bucket is scored
    public static System.Action<float> OnComboUpdated; // 0.0f a 1.0f
}