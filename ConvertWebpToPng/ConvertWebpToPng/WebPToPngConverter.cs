using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConvertWebpToPng
{
    public class WebPToPngConverter
    {
        public bool ConvertWebPToPng(string webpFilePath, string pngFilePath, bool useOriginalSize)
        {
            try
            {
                byte[] webpBytes = File.ReadAllBytes(webpFilePath);
                using SKBitmap webpBitmap = SKBitmap.Decode(webpBytes);

                if (webpBitmap == null)
                {
                    Console.WriteLine("Failed to decode the WebP image.");
                    return false;
                }

                SKBitmap resizedBitmap = useOriginalSize
                    ? webpBitmap
                    : webpBitmap.Resize(new SKImageInfo(128, 128), SKFilterQuality.High);

                using SKImage image = SKImage.FromBitmap(resizedBitmap);
                using SKData pngData = image.Encode(SKEncodedImageFormat.Png, 100);
                File.WriteAllBytes(pngFilePath, pngData.ToArray());

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConvertWebPToIco(string webpFilePath, string icoFilePath, bool useOriginalSize)
        {
            try
            {
                byte[] webpBytes = File.ReadAllBytes(webpFilePath);
                using SKBitmap webpBitmap = SKBitmap.Decode(webpBytes);

                if (webpBitmap == null)
                {
                    Console.WriteLine("Failed to decode the WebP image.");
                    return false;
                }

                SKBitmap resizedBitmap = useOriginalSize
                    ? webpBitmap
                    : webpBitmap.Resize(new SKImageInfo(128, 128), SKFilterQuality.High);

                using Bitmap bitmap = new Bitmap(resizedBitmap.Width, resizedBitmap.Height);
                for (int y = 0; y < resizedBitmap.Height; y++)
                {
                    for (int x = 0; x < resizedBitmap.Width; x++)
                    {
                        SKColor color = resizedBitmap.GetPixel(x, y);
                        bitmap.SetPixel(x, y, Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue));
                    }
                }

                using FileStream fs = new FileStream(icoFilePath, FileMode.Create);
                Icon.FromHandle(bitmap.GetHicon()).Save(fs);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
