using UnityEngine;

public class HoopTriggerProxy : MonoBehaviour
{
    [SerializeField] private bool isTopTrigger;
    [SerializeField] private HoopDetector mainDetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (mainDetector != null)
                mainDetector.TriggerEntered(isTopTrigger);
            else
                Debug.LogError($"Missing reference {gameObject.name}");
        }
    }
}