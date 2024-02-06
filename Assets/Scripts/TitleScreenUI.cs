using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenUI : MonoBehaviour
{
    public Image cloud1;
    public Image cloud2;
    public Vector2 spawnPosition;
    public float resetPosition;
    public float cloudSpeed;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moveClouds();
    }

    public void moveClouds()
    {

        RectTransform cloudRect = cloud1.GetComponent<RectTransform>();
        RectTransform cloud2Rect = cloud2.GetComponent<RectTransform>();    
        cloudRect.anchoredPosition += new Vector2(cloudSpeed *  Time.deltaTime, 0f);
        cloud2Rect.anchoredPosition += new Vector2(cloudSpeed * Time.deltaTime, 0f);

        if(cloudRect.anchoredPosition.x > 1300f)
        {
            cloudRect.anchoredPosition = new Vector2(resetPosition, cloudRect.anchoredPosition.y);
        }

        if(cloud2Rect.anchoredPosition.x > 1300f)
        {
            cloud2Rect.anchoredPosition = new Vector2(resetPosition, cloud2Rect.anchoredPosition.y);
        }
    }
}
