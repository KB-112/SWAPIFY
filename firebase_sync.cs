using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Analytics;


public class firebase_sync : MonoBehaviour
{

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction: task =>
        {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

    }

   

