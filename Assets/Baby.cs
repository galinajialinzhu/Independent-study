using UnityEngine;
using UnityEngine.UI;

public class Baby : MonoBehaviour
{
    public Slider foodBar;
    public float maxFoodLevel = 100f;
    public float foodIncreaseRate = 10f;

    private float currentFoodLevel;

    private void Start()
    {
        currentFoodLevel = maxFoodLevel;
        foodBar.maxValue = maxFoodLevel;
    }

    private void Update()
    {
        if (currentFoodLevel > 0)
        {
            currentFoodLevel -= (Time.deltaTime*2);
            foodBar.value = currentFoodLevel;
        }
    }

    public void EatFood(float foodValue)
    {
        currentFoodLevel = Mathf.Clamp(currentFoodLevel + foodValue, 0, maxFoodLevel);
        foodBar.value = currentFoodLevel;
    }
}
