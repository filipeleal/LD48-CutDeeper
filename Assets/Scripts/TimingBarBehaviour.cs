using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TimingBarBehaviour : MonoBehaviour
{
    public GameObject Container;
    public Color FillColor;
    public Color SweetSpotColor;

    [Range(0.001f, 0.9f)]
    public float Tolerance;
    public ShapeEnum Shape;

    public Transform StartPosition;

    public ParticleSystem PerfectEffect;

    public float Speed;

    [SerializeField]
    float sweetSpot;

    GameObject fill;

    [SerializeField]
    float currentFillSize;

    int direction = 1;
    GameObject sweetSpotGO;

    private void Awake()
    {
        fill = Instantiate(Container, transform);
        sweetSpotGO = Instantiate(Container, transform);
        fill.GetComponent<MeshRenderer>().material.color = FillColor;
        sweetSpotGO.GetComponent<MeshRenderer>().material.color = SweetSpotColor;

        Reload();
    }

    void Reload()
    {
        sweetSpot = Random.Range(-1f, 1f);

        //// S*P + E*(1-P)
        //float p = 0.5f;
        //float s = -1f;
        //float e = 1f;
        //sweetSpot = s*p + e*(1-p);

        fill.transform.position = new Vector3(fill.transform.position.x, fill.transform.position.y, Container.transform.position.z - 1);

        currentFillSize = 0.5f;

        float size = Container.transform.localScale.z * Tolerance;

        sweetSpotGO.transform.localPosition = new Vector3(StartPosition.localPosition.x * (1 - size) * sweetSpot, sweetSpotGO.transform.localPosition.y, Container.transform.position.z - 2);
        sweetSpotGO.transform.localScale = new Vector3(sweetSpotGO.transform.localScale.x, sweetSpotGO.transform.localScale.y, Container.transform.localScale.z * Tolerance);

    }

    // Update is called once per frame
    void Update()
    {
        //Calculate new fill size
        UpdateFillSize();
        DrawFill();
    }

    void UpdateFillSize()
    {
        currentFillSize += Time.deltaTime * Speed * direction;

        if (currentFillSize > 1)
        {
            currentFillSize = 1;
            direction *= -1;
        }
        else if (currentFillSize < 0)
        {
            currentFillSize = 0;
            direction *= -1;
        }

    }

    void DrawFill()
    {
        //Update the size based on the parent
        float size = Container.transform.localScale.z * currentFillSize;

        //Update the size from left to right
        float newPositionX = StartPosition.localPosition.x * (1 - size);

        fill.transform.localPosition = new Vector3(newPositionX, fill.transform.localPosition.y, fill.transform.localPosition.z);
        fill.transform.localScale = new Vector3(fill.transform.localScale.x, fill.transform.localScale.y, size);
    }

    public float Attack()
    {
        float wait = 0f;
        float relativeSweetSpot = 1f - ((sweetSpot + 1f) / 2f);

        float hit = Mathf.Abs(currentFillSize - relativeSweetSpot);
        //if (hit <= Tolerance / 2f)
        //{
        //    PerfectEffect.gameObject.SetActive(false);
        //    PerfectEffect.transform.localPosition = sweetSpotGO.transform.localPosition;
        //    PerfectEffect.gameObject.SetActive(true);
        //    wait = 2f;
        //}

        

        StartCoroutine("DeactivateBars", wait);

        return hit;
    }

    IEnumerator DeactivateBars(float wait)
    {
        Container.SetActive(false);
        sweetSpotGO.SetActive(false);
        fill.SetActive(false);

        yield return new WaitForSeconds(wait);

        gameObject.SetActive(false);
    }

    public void ShowTimeBars()
    {
        Reload();
        gameObject.SetActive(true);
        Container.SetActive(true);
        sweetSpotGO.SetActive(true);
        fill.SetActive(true);
    }
    //private void OnDrawGizmos()
    //{
    //    if (sweetSpotGO == null)
    //        return;
    //    float relativeSweetSpot = 1f-((sweetSpot + 1f)/2f);
    //    Debug.Log($"{relativeSweetSpot} | {currentFillSize}");
    //    float size = Container.transform.localScale.z * Tolerance;
    //    float newPositionX = StartPosition.localPosition.x * relativeSweetSpot;

    //    //S*P + E*(1-P) = sweetSpot

    //    // S*P + E - E*P= sweetSpot
    //    // P*(S-E) = sweetSpot - E
    //    // P = (sweetSpot - E) / (S-E)

    //    //float newPositionX = sweetSpotGO.transform.position.x;

    //    Gizmos.DrawWireSphere(new Vector3(newPositionX, sweetSpotGO.transform.position.y, sweetSpotGO.transform.position.z),1f/(1-Tolerance));
    //}
}

public enum ShapeEnum
{
    Square
}
