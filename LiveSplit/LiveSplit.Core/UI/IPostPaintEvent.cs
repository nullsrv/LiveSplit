using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.UI
{
    public interface IPostPaintEvent
    {
        void RegisterEventHandler(EventHandler<PostPaintEventArgs> handler);
        void UnregisterEventHandler(EventHandler<PostPaintEventArgs> handler);
    }
}
