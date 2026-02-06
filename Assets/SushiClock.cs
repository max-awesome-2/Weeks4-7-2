using UnityEngine;
using UnityEngine.UI;

public class SushiClock : MonoBehaviour
{
    public Slider sushiSlider;

    public GameObject warper;
    

    public float clockDuration;

    private float timeWaiting = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sushiSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime * 1;

        if (timeWaiting >= clockDuration)
        {
            print("time is up");
            timeWaiting = 0;

            sushiSlider.SetValueWithoutNotify(timeWaiting / clockDuration * sushiSlider.maxValue);
        }
    }
}
