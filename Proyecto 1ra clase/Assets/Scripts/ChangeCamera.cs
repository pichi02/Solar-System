using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    [SerializeField] private GameObject cam3;
    [SerializeField] private GameObject cam4;
    [SerializeField] private GameObject cam5;
    [SerializeField] private GameObject cam6;
    [SerializeField] private GameObject cam7;
    [SerializeField] private GameObject cam8;
    [SerializeField] private GameObject cam9;
    [SerializeField] private GameObject cam10;

    int num = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (num == 10)
            {
                num = 1;
            }
            else
            {
                num++;
            }
           
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (num == 1)
            {
                num = 10;
            }
            else
            {
                num--;
            }

        }

        switch (num)
        {
            case 1:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);

                break;
            case 2:
                cam2.SetActive(true);
                cam1.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 3:
                cam3.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam4.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 4:
                cam4.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 5:
                cam5.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 6:
                cam6.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam4.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 7:
                cam7.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam4.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 8:
                cam8.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam4.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                break;
            case 9:
                cam9.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam4.SetActive(false);
                cam10.SetActive(false);
                break;
            case 10:
                cam10.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam4.SetActive(false);
                break;
            default:
                break;
        }
    }
}
