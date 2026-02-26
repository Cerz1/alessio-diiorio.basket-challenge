using UnityEngine;

public class HoopDetector : MonoBehaviour
{
    private bool _passedTop = false;

    public void TriggerEntered(bool isTop)
    {
        if (isTop)
        {
            _passedTop = true;
            Debug.Log("Up trigger");
        }
        else
        {
            if (_passedTop)
            {
                ScoreConfirmed();
                _passedTop = false; // Reset for next shoot
            }
        }
    }

    private void ScoreConfirmed()
    {
        Debug.Log("Buket!");
        
        GameEvents.OnScoreUpdated?.Invoke(2);
        GameEvents.OnComboUpdated?.Invoke(0.2f);
    }

    // Ball exit from the rim, reset
    public void TriggerExited(bool isTop)
    {
        if (isTop && _passedTop)
        {
            

        }
    }
}