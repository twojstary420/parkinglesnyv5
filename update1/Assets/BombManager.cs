using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BombManager : MonoBehaviour
{
    public int bombCount;
    public TextMeshProUGUI bombText;
    public GameObject autobus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bombText.text = "x" + bombCount.ToString();

        if(bombCount == 8)
        {
            Collider2D autobusCollider = autobus.GetComponent<Collider2D>();
            if (autobusCollider != null)
            {
                autobusCollider.enabled = false;
            }
        }
    }
}
