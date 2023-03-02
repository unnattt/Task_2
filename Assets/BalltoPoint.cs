using UnityEngine;
using System.Collections;

public class BalltoPoint : MonoBehaviour
{
    public Transform p1;
    public Transform p2;

    public float TimeForFly;
    public float height;
    public Vector3 random;
    

    Vector3 StartPoint;
    Vector3 EndPoint;



    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Randmize();
            StartCoroutine(BallThrown());
            
        }

    }

    private IEnumerator BallThrown()

    {

        StartPoint = p1.position;
        EndPoint = p2.position;
        

    Vector3 ControlPoint = StartPoint + (EndPoint - StartPoint) / 2 + Vector3.up * height;

        for (float t = 0; t < 1; t += Time.deltaTime / TimeForFly)
        {
            Vector3 Final = Mathf.Pow(1 - t, 2) * StartPoint + 2 * (1 - t) * t * ControlPoint + Mathf.Pow(t, 2) * EndPoint;
            Final += new Vector3(0f, 2f, 0);
            p1.position = Final;

           yield return null;
           
        }
        
    }

    private void Randmize()
    {
        random.x = Random.Range(0f,7f);
        random.y = Random.Range(0f, 0f);
        random.z = Random.Range(0f, 7f);

        p2.position = random;
    }
}
   
            

             

        

        
   
    

    
