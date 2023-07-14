using System;
using System.Drawing;

namespace LiveSplit.Model
{
    public class PostPaintEventArgs : EventArgs
    {
        public int FrameId { get; set; }
        public Bitmap Bitmap { get; set; }
        public Region Clip { get; set; }
        public DateTime Rendered { get; set; }

        public PostPaintEventArgs(int frameId, Bitmap bitmap, Region clip, DateTime rendered)
        {
            FrameId = frameId;
            Bitmap = bitmap;
            Clip = clip;
            Rendered = rendered;
        }
    }
}
