using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI;


public class Healt : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHealt(int health)
    {

        slider.maxValue = health;
        slider.value = health;

    }

    public void SetHealt(int health)
    {

        slider.value = health;

    }



}
