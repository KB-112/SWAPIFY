using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class image_swapify : MonoBehaviour
{
    RawImage Image_1, Image_2, Image_3, Image_4, Image_5, Image_6, Image_7, Image_8, Image_9, Image_10;
    float next_spawn = 1f;
    private float spawnNewEnemyTimer;
    int whatToSpawn;

    
    //---------------------------------------------------------------------//
    //---------------------------------------------------------------------//

    IEnumerator LoadImage_1(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(10);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
       else

        {

            Image_1.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_2(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(18);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_2.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }
        
    }

    //---------------------------------------------------------------------//
    IEnumerator LoadImage_3(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(24);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_3.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }

    //---------------------------------------------------------------------//
    IEnumerator LoadImage_4(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(30);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_4.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_5(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(37);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_5.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_6(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(45);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
       else
        {

            Image_6.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_7(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(52);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_7.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_8(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(60);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            Image_8.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_9(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(65);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
     else
        {

            Image_9.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
    //---------------------------------------------------------------------//
    IEnumerator LoadImage_10(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        yield return new WaitForSeconds(72);
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
      else
        {

            Image_10.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;


        }


    }
   
    //---------------------------------------------------------------------//
    //---------------------------------------------------------------------//


    void Start()
    {
       
        Image_1 = gameObject.GetComponent<RawImage>();
        Image_2 = gameObject.GetComponent<RawImage>();
        Image_3 = gameObject.GetComponent<RawImage>();

        Image_4 = gameObject.GetComponent<RawImage>();
        Image_5 = gameObject.GetComponent<RawImage>();
        Image_6 = gameObject.GetComponent<RawImage>();

        Image_7 = gameObject.GetComponent<RawImage>();
        Image_8 = gameObject.GetComponent<RawImage>();
        Image_9 = gameObject.GetComponent<RawImage>();

        Image_10 = gameObject.GetComponent<RawImage>();

        StartCoroutine(LoadImage_1("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/cannon3.PNG?alt=media&token=5a87adc1-366b-4686-b340-1356fb6596f0"));
        StartCoroutine(LoadImage_2("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/cannon1.PNG?alt=media&token=b282d17e-cd40-4e4b-b51a-db3a43eed7f5"));
        StartCoroutine(LoadImage_3("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/cannon2.PNG?alt=media&token=1d15b117-ead3-4cb1-a58a-41cdad23b0ce"));

        StartCoroutine(LoadImage_4("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_04.png?alt=media&token=f60f7b07-688b-4501-80c5-813dcd50c529"));
        StartCoroutine(LoadImage_5("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_05.png?alt=media&token=07771545-2d81-411d-97d0-b1ba05c6744a"));
        StartCoroutine(LoadImage_6("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_06.png?alt=media&token=3b3c84f0-8330-4504-8f3c-58e636128b38"));

        StartCoroutine(LoadImage_7("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_07.png?alt=media&token=07b9cb7a-324c-444b-9055-07d83799e2c2"));
        StartCoroutine(LoadImage_8("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_08.png?alt=media&token=5ea27831-f8f7-4fb4-b992-b1737898468d"));
        StartCoroutine(LoadImage_9("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_09.png?alt=media&token=c2a9a403-608b-454f-a236-d0d3ec6ee05f"));

        StartCoroutine(LoadImage_10("https://firebasestorage.googleapis.com/v0/b/ezyhelperindia.appspot.com/o/Hull_10.png?alt=media&token=f356eda8-f6fa-4158-bea2-5dcc58177f2c"));


    }


    //---------------------------------------------------------------------//
    //---------------------------------------------------------------------//
void Update()
{
   
    if (spawnNewEnemyTimer > next_spawn)
    {
        whatToSpawn = Random.Range(1, 10);
    }
    switch (whatToSpawn)
    {
        case 1:
               
                 Instantiate(Image_1.texture, transform.position, Quaternion.identity); 
                

                break;
        case 2:
            
                Instantiate(Image_2.texture, transform.position, Quaternion.identity);
                
                break;
        case 3:
            
            
                Instantiate(Image_3.texture, transform.position, Quaternion.identity);
                
                break;

            case 4:


                Instantiate(Image_4.texture, transform.position, Quaternion.identity);

                break;
            case 5:


                Instantiate(Image_5.texture, transform.position, Quaternion.identity);

                break;


            case 6:

                Instantiate(Image_6.texture, transform.position, Quaternion.identity);


                break;
            case 7:

                Instantiate(Image_7.texture, transform.position, Quaternion.identity);

                break;
            case 8:


                Instantiate(Image_8.texture, transform.position, Quaternion.identity);

                break;

            case 9:


                Instantiate(Image_9.texture, transform.position, Quaternion.identity);

                break;
            case 10:


                Instantiate(Image_10.texture, transform.position, Quaternion.identity);

                break;

        }

    




}


}


