using OpenCvSharp;

namespace OpenCvC_deneme
{
    class Root
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Görüntü İşleme Deneme Uygulaması");
            Console.WriteLine($"OpenCV Versiyonu: {Cv2.GetVersionString()}");

            // Görüntüyü Yükle 
            Mat resim = Cv2.ImRead("DosyaYolu");

            // Görüntü yoksa mesaj ver
            if (resim.Empty())
            {
                Console.WriteLine("Görüntü Yüklenemedi !");
                return;
            }

            // Görüntüyü göster
            Cv2.ImShow("Görüntü Ekranı", resim);
            Cv2.WaitKey(0);
        }
    }
}
