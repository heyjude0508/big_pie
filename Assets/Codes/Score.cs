using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 45).ToString("0");
    }
}
