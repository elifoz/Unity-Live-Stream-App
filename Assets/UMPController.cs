using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMP;
using System.Linq;

public class UMPController : MonoBehaviour
{
    public string URL;
    public UniversalMediaPlayer ump;
   // public List<UniversalMediaPlayer> liveStreams;
    Coroutine normalCoroutine;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {       
            PrepareVideo();
        
    }

    public void PrepareVideo()
    {
        //foreach (UniversalMediaPlayer item in liveStreams)
        //{
            ump.Path = URL;
           // item.Path = URL;
            ump.Prepare();
           // item.Prepare();
            CheckEnum = true;
            normalCoroutine = StartCoroutine(CheckUMPIsReadyNormal());
        //}
        
      
      
    }

    public bool CheckEnum = true;
    IEnumerator CheckUMPIsReadyNormal()
    {
        while (CheckEnum)
        {
            //foreach (var item in liveStreams)
            //{
                if (ump.IsReady)
                {
                    ump.Play();
                    CheckEnum = false;
                    Debug.LogError("hazýr");
                }

                else
                {
                    Debug.LogError("hazýr deðil");
                }
           // }
           
            yield return new WaitForSeconds(0.1f);
        }
    }
}
