using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurboMode : MonoBehaviour
{
    public float charge;
    public float overchargeTime;
    public bool overcharged;
    private Slider slider;
    private bool cooldown;
    private Gradient gradDef;
    private Gradient chargeGrad;
    private HealthBar healthScript;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        cooldown = true;
        healthScript = GetComponent<HealthBar>();
        gradDef = healthScript.gradient;
        chargeGrad = new Gradient();
        GradientColorKey[] colorKey;
        GradientAlphaKey[] alphaKey;
        colorKey = new GradientColorKey[1];
        colorKey[0].color = Color.blue;
        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        chargeGrad.SetKeys(colorKey, alphaKey);

        //charge = 1;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Mathf.Clamp(charge, 0, 1);
        healthScript.Sethealth(charge);
        if (charge > 1 && cooldown)
        {
            Invoke("ResetBar", overchargeTime);
            cooldown = false;
            overcharged = true;
            healthScript.gradient = chargeGrad;
        }
    }

    private void ResetBar()
    {
        charge = 0;
        cooldown = true;
        overcharged = false;
        healthScript.gradient = gradDef;
    }
}
