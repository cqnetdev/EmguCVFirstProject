using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EmguCVHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String win1 = "EmguCV Create Image";
            //新建窗口
            CvInvoke.NamedWindow(win1,NamedWindowType.Normal);
            //新建图像
            Mat img = new Mat(200, 500, DepthType.Cv8U, 3);
            
            //设置图像颜色
            img.SetTo(new Bgr(255, 0, 0).MCvScalar);
            //绘制文字
            CvInvoke.PutText(img, "Hello, world", new System.Drawing.Point(10, 80), FontFace.HersheyComplex, 2.0, new Bgr(0, 255, 255).MCvScalar, 4);
            //显示
            CvInvoke.Imshow(win1, img);
           

            string win2 = "EmguCV Read Image";
            string imgurl = AppDomain.CurrentDomain.BaseDirectory+"b4d1e3f48eb87d5f4768e9b6c96cb19d.jpg";
            var image = CvInvoke.Imread(imgurl, LoadImageType.Color); //从文件中读取图像
            //新建窗口
            CvInvoke.NamedWindow(win2, NamedWindowType.Normal);
            CvInvoke.Imshow(win2, image); //显示图片

            CvInvoke.WaitKey(0);
            CvInvoke.DestroyWindow(win1);
            CvInvoke.DestroyWindow(win2);
        }
    }
}
