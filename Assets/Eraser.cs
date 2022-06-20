using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eraser : MonoBehaviour
{
    public Image IM;
    public Texture2D tex;
    
    private float factorX;
    private float factorY;

    private void Awake()
    {
       
     
        IM.sprite = Sprite.Create(tex, new Rect(0, 0, 1024, 718), Vector2.zero);
        factorX = tex.width / IM.rectTransform.rect.width;
        factorY = tex.height / IM.rectTransform.rect.height;
        
    }
    void Start()
    {
        IM = GetComponent<Image>();
        print(IM + "  " + IM.mainTexture);
        tex = IM.mainTexture as Texture2D;
       // IM.sprite = Sprite.Create(tex, ew Rect(0, 0, 1024, 718), Vector2.zero);
        //IM = GetComponent<Image>();
        /*
         tex = new Texture2D(IM.sprite.texture.width, IM.sprite.texture.height);
       Color[] buff = IM.sprite.texture.GetPixels();
        tex.SetPixels(buff);
        tex.Apply();*/

    }

    // Update is called once per frame
    void Update()
    {

        

   
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = new Vector3(Input.mousePosition.x * factorX, Input.mousePosition.y * factorY, 0);
            tex = IM.mainTexture as Texture2D;
            print(pos);
            for (int x = -50; x < 50; x++)
            {
                for (int y = -50; y < 50; y++)
                {
                    Color col = tex.GetPixel((int)(pos.x + x), (int)(pos.y + y));
                    float alpha=(x * x + y * y) / 8000f;

                    Color ncol = new Color(col.r,col.g,col.b,alpha);

                    tex.SetPixel((int)(pos.x + x), (int)(pos.y + y), ncol);
                }
                
            }
            tex.Apply();
            IM.sprite = Sprite.Create(tex, new Rect(0, 0, 1024, 718), Vector2.zero);
        }
        

    }

    private void FixedUpdate()
    {
        
    }
}
