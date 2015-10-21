using UnityEngine;
using System.Collections;

public class BackGroundColor : MonoBehaviour {

    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    public AudioSource AudioMenu;
    float duration = 0.2f;
    bool TimeColor = true;
    void Start()
    {
        StartCoroutine(Timer());
    }

    void Update()
    {
       
        float[] samples = AudioMenu.GetSpectrumData(64, 0, FFTWindow.Rectangular);

        float red = 0;
        for (int i = 0; i < samples.Length / 4; i++)
            red += samples[i];
        red /= samples.Length/4;
        red /= 0.15f;
        red = red > 1 ? 1 : red;

        float green = 0;
        for (int i = samples.Length / 4; i < samples.Length / 4 * 2; i++)
            green += samples[i];
        green /= samples.Length / 4;
        green /= 0.03f;
        green = green > 1 ? 1 : green;

        float blue = 0;
        for (int i = samples.Length / 4 * 2; i < samples.Length / 4 * 3; i++)
            blue += samples[i];
        blue /= samples.Length / 4;
        blue /= 0.04f;
        blue = blue > 1 ? 1 : blue;

        float media = 0;
        Color color = new Color(red, green, blue, 1);//Mathf.PingPong(Time.time, duration) / duration;        
        camera.backgroundColor = color;
        //if (TimeColor)
        //{
        //    media = red;
        //    camera.backgroundColor = Color.Lerp(color1, color2, media);
        //}
        //else
        {
            //media = blue;
            //camera.backgroundColor = Color.Lerp(color2, color3, media);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        TimeColor = !TimeColor;
        StartCoroutine(Timer());
    }

    void Example()
    {
        camera.clearFlags = CameraClearFlags.SolidColor;
    }

}
