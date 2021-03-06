using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointsBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxSkill(int skill)
    {
        slider.maxValue = skill;
        slider.value = skill;
    }

    public void SetSkill(int skill)
    {
        slider.value = skill;
    }
}
