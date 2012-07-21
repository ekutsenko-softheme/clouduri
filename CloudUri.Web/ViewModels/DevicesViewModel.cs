using System.Collections.Generic;
using CloudUri.DAL.Entities;

namespace CloudUri.Web.ViewModels
{
    public class DevicesViewModel
    {
        public List<DeviceType> DeviceTypes { get; set; }

        public Device CurrentDevice { get; set; }
    }
}