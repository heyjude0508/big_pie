using UnityEngine;

public class ClickTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {

        GameManager.Instance.CompleteLevel();

    }

}
