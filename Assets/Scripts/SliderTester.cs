using UnityEngine;

public class SliderTester : MonoBehaviour
{

    public float currentSliderValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(float val)
    {
        currentSliderValue = val;
    }
}
