using UnityEngine;

public class test : MonoBehaviour, ITestInteract
{
    public float timer;
    public float coolDownTime;
    public string Description()
    {
        return "This is test";
    }

    public void Execute()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > coolDownTime)
        {
            timer = 0;
            Execute();
        }

        timer += Time.deltaTime;
    }
}
