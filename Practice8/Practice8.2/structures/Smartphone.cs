using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class Smartphone : ColorScreenPhone
    {
        private int ScreenMaxTouches;
        private Camera[] Cameras;
        public Smartphone(Operator mobileOperator, ConsoleColor color, Screen screen, int maxTouches, int camerasCount) : base(mobileOperator, color, screen)
        {
            this.ScreenMaxTouches = maxTouches;
            this.Cameras = new Camera[camerasCount];
            for (int i = 0; i < camerasCount; i++)
            {
                Cameras[i] = new Camera();
            }
            
        }
        public Image TakePhotoUsingCamera(int CameraIndex)
        {
            if (CameraIndex >= Cameras.Length)
            {
                throw new Exception("Camera not found");
            }
            return Cameras[CameraIndex].TakePhoto();

        }
        public Image[] TakeVideoUsingCamera(int CameraIndex)
        {
            if (CameraIndex >= Cameras.Length)
            {
                throw new Exception("Camera not found");
            }
            return Cameras[CameraIndex].TakeVideo();

        }
        public int GetMaxScreenTouches()
        {
            return this.ScreenMaxTouches;
        }
    }


    class Camera
    {
        public Image TakePhoto()
        {
            return new Image("file.jpg", "Image here");
        }
        public Image[] TakeVideo()
        {
            Image[] video = new Image[10];
            for (int i = 0; i < video.Length; i++)
            {
                video[i] = new Image(i.ToString(), "Image here " + i);
            }
            return video;
        }
    }
}
