using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideos : MonoBehaviour
{
    public VideoPlayer vp1, vp2, vp3;

    // Start is called before the first frame update
    void Start()
    {
        vp1.url = System.IO.Path.Combine(Application.streamingAssetsPath, "DignitaryOfficersSaluteHaitianGendarmerie.mp4");
        vp2.url = System.IO.Path.Combine(Application.streamingAssetsPath, "CrowdNnativesAttMarketplace.mp4");
        vp3.url = System.IO.Path.Combine(Application.streamingAssetsPath, "HaitianPrisonersToMarinePrison.mp4");

        vp1.Play();
        vp2.Play();
        vp3.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
