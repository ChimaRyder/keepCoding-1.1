using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryBar : MonoBehaviour
{
    private Slider slider;

    void Start()
    {
        slider = this.GetComponent<Slider>();
        InvokeRepeating("DepleteEnergy", 0f, 1.8f); //modify this to depend of GameManager
    }

    public void SetHealth(int health) {
        if (health > 100) {
            health = 100;
        } else if (health < 0) {
            health = 0;
        }

        slider.value = health;
    }
    
    public int GetHealth () {
        return (int) slider.value;
    }

    private void DepleteEnergy() {
        SetHealth(GetHealth() - 1);
    }
}
