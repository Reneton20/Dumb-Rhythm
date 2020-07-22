using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class Document1 : MonoBehaviour
{
private string adid = "3580853";

private string videoad = "video";

    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(adid, true);
    }

public void AdShower(){
if (Monetization.IsReady(videoad)){
ShowAdPlacementContent ad = null;
ad = Monetization.GetPlacementContent(videoad) as ShowAdPlacementContent;
if (ad != null) {
ad.Show();
}
}
}
}
