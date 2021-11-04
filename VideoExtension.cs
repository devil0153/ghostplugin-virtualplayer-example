using Ghost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VirtualPlayer
{
    public class VideoExtension : IVirtualViewExtension
    {
        public HubBase Hub { get; private set; }

        public void Dispose()
        {

        }

        public FrameworkElement GetView()
        {
            return ((VideoHub)this.Hub).Media;
        }

        public void Initialize(IExtensionConfig config)
        {
            this.Hub = new VideoHub();
        }

        public void OnConnected()
        {

        }

        public void OnDisconnect()
        {

        }
    }
}
