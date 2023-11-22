using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUIController : MonoBehaviour
{
	public GameObject hearts;

	private float fillValue;

    // Update is called once per frame
    void Update()
    {
        fillValue = (float)GameController.HP;
		fillValue = fillValue / GameController.MaxHP;
		hearts.GetComponent<Image>().fillAmount = fillValue;
    }
}
