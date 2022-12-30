using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{
    private float variable;

    private void Start()
    {
        variable = 0.01f;
    }
    public void IncreaseSize()
    {
        if (variable < 0.05f)
        {
            variable += 0.001f;
            gameObject.transform.localScale = new Vector3(variable, variable, variable);
        }
    }
    public void DecreaseSize()
    {
        if (variable > 0.001f)
        {
            variable -= 0.001f;
            gameObject.transform.localScale = new Vector3(variable, variable, variable);
        }
    }
}
