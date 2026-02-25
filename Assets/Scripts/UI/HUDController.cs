using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private Image _comboBar;

    private const string k_prefix = "SCORE: ";

    private void OnEnable()
    {
        GameEvents.OnScoreUpdated += UpdateScoreText;
        GameEvents.OnComboUpdated += UpdateComboBar;
    }

    private void OnDisable()
    {
        GameEvents.OnScoreUpdated -= UpdateScoreText;
        GameEvents.OnComboUpdated -= UpdateComboBar;
    }

    private void UpdateScoreText(int newScore) => _scoreText.text = k_prefix + newScore;
    private void UpdateComboBar(float ratio) => _comboBar.fillAmount = ratio;
}