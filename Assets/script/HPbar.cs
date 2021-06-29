using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public Slider slider;
    public Gradient color;
    public Image fill;
    public void setMaxHP(int Hp)
    {
        slider.maxValue = Hp;
        slider.value = Hp;
        fill.color = color.Evaluate(1f);
    }
    public void setCurHP(int Hp)
    {
        slider.value = Hp;
        fill.color = color.Evaluate(slider.normalizedValue);
    }
}
