using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Enigma_3 : MonoBehaviour
{
    OrderManager orderManager;

    public bool mousePressed;
    public GameObject coin;

    public Vector3 mouseStartPosition;
    public Vector3 mouseEndPosition;
    string finalDirection;


    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;
    public bool swipedInArea = false;



    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
        m_Raycaster = GetComponent<GraphicRaycaster>();
        m_EventSystem = GetComponent<EventSystem>();

        coin.transform.gameObject.SetActive(true);
        coin.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                mousePressed = true;
                Ray vRayStart = Camera.main.ScreenPointToRay(Input.mousePosition);
                mouseStartPosition = vRayStart.origin;

                //RayCasting
                m_PointerEventData = new PointerEventData(m_EventSystem);
                m_PointerEventData.position = Input.mousePosition;
                List<RaycastResult> results = new List<RaycastResult>();
                m_Raycaster.Raycast(m_PointerEventData, results);

                foreach (RaycastResult result in results)
                {
                    if (result.gameObject.tag == "SwipeArea")
                    {
                        if (orderManager.order != 3)
                        {
                            Wrong();
                            break;
                        }
                        else
                        {
                            swipedInArea = true;
                            break;
                        }
                    }
                }
        }

        if (Input.GetMouseButtonUp(0) && swipedInArea)
        {
            swipedInArea = false;
            if (mousePressed)
            {
                Ray vRayEnd = Camera.main.ScreenPointToRay(Input.mousePosition);

                mouseEndPosition = vRayEnd.origin;
                Vector3 direction = mouseEndPosition - mouseStartPosition;

                if (Mathf.Abs(direction.x) != Mathf.Abs(direction.y))
                {
                    if (direction.x > 0 && direction.y > 0)
                    {
                        Correct();
                    }

                }

            }
        }
    }

    public void Correct()
    {
        coin.transform.gameObject.SetActive(false);
        orderManager.Procede();
    }

    public void Wrong()
    {
        orderManager.Error();
    }
}
