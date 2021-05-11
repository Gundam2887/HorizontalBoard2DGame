using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    //记录血量最大值
    public static int lifeMax;
    //当前血量
    public static int lifeCurrent ;
    //血量显示
    public Image lifeBar;
    // Start is called before the first frame update
    void Start()
    {
        lifeBar = GetComponent<Image>();
        //lifeCurrent = lifeMax;
    }

    // Update is called once per frame
    void Update()
    {
        lifeBar.fillAmount = (float)lifeCurrent / (float)lifeMax;
    }
}
