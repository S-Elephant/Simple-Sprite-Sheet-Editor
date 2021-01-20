using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteSheetEditor
{
    public class ImgInfo
    {
        public string FileName;
        public string FullPath;
        public ImgInfo(string fileName, string fullPath)
        {
            FileName = fileName;
            FullPath = fullPath;
        }
        public override string ToString()
        {
            return FileName.ToString();
        }
    }
}
