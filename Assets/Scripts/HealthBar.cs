using TMPro;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthBar : MonoBehaviour
{
    public HitPoints hitPoints;
    [HideInInspector] public Player character;
    public Image meterImage;
    public TextMeshProUGUI hpText;
    float maxHitPoints;

    void Start()
    {
        maxHitPoints = character.maxHitPoints;
    }void Update()
    {
        if (character != null)
        {
            meterImage.fillAmount = hitPoints.value / maxHitPoints;
            hpText.text = "Health: " + (meterImage.fillAmount * 100) + "/"+(maxHitPoints* 10);

        }
        else
        {
            meterImage.fillAmount = 0;
            hpText.text = "Game Over!";

        } 
       
    }



}