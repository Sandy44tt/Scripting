using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI counterText;
    public Slider heathSlider;
    void Update()
    {
        heathSlider.maxValue = player.maxHealth;
        heathSlider.value = player.health;

        counterText.text = player.coins.ToString();
    }
}
