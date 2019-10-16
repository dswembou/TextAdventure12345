using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MijnStart : MonoBehaviour
{
    public string FinalText;
    private int i = 0;
    
    [SerializeField] Terminal connectedToTerminal;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void NieuwKarakter()
    {
        if (Time.time > 2f)
        {
            if (connectedToTerminal)
            {
                connectedToTerminal.ReceiveFrameInput(FinalText.Substring(i, 1));
                i++;
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {

        if (i < FinalText.Length)
        {
            NieuwKarakter();
        }
    }
}
