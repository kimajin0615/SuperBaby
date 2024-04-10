using UnityEngine;
using UnityEngine.UI;

public class PhoneMove : MonoBehaviour
{
    public Transform targetPosition;
    public Transform targetPosition2;
    public float moveSpeed = 2.0f;

    private bool isMoving = false;
    private bool isMovingBack = false;

    private Vector3 startPosition;
    private float journeyLength;
    public Button button;
    private float startTime;



    void Start()
    {
        startPosition = transform.position;
        journeyLength = Vector3.Distance(startPosition, targetPosition.position);

        if (button != null)
        {
            button.onClick.AddListener(MoveObject);
        }
    }

    void Update()
    {


        if (isMoving)
        {
            float distanceCovered = (Time.time - startTime) * moveSpeed;
            float fractionOfJourney = distanceCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition, targetPosition.position, fractionOfJourney);

            if (fractionOfJourney >= 1.0f)
            {
                isMoving = false;
            }

        }

        if (isMovingBack)
        {
            float distanceCovered = (Time.time - startTime) * moveSpeed;
            float fractionOfJourney = distanceCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition, targetPosition2.position, fractionOfJourney);

            if (fractionOfJourney >= 1.0f)
            {
                isMovingBack = false;
            }
        }




    }

    private void MoveObject()
    {
        isMoving = true;
        startPosition = transform.position;
        journeyLength = Vector3.Distance(startPosition, targetPosition.position);
        startTime = Time.time;
    }

    public void MoveBack()
    {
        isMovingBack = true;
        startPosition = transform.position;
        journeyLength = Vector3.Distance(startPosition, targetPosition2.position);
        startTime = Time.time;
    }
}